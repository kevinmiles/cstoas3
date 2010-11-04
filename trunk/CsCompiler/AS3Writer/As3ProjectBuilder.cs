using System;
using System.Runtime.Remoting.Channels;

namespace CsCompiler.AS3Writer {
	using System.IO;
	using System.Runtime.Remoting;
	using System.Runtime.Remoting.Channels.Ipc;
	using Tools;

	internal class As3ProjectBuilder {
		readonly FlexCompilerShell _fcsh;
		const string VMARGS = @"-Xmx384m -Xmx1024m -Dsun.io.useCanonCaches=false -Duser.language=en";
		readonly string _sdkPath;
		readonly string _mxmlcPath;
		readonly string _fcshPath;

		private static readonly string _ipcName = Guid.NewGuid().ToString();
		private static bool _isInited;

		private static void setupRemotingServer() {
			if (_isInited) return;
			_isInited = true;
			IpcChannel channel = new IpcChannel(_ipcName);
			ChannelServices.RegisterChannel(channel, false);
			RemotingConfiguration.RegisterWellKnownServiceType(typeof(FlexCompilerShell), "FlexCompilerShell", WellKnownObjectMode.Singleton);
		}

		public As3ProjectBuilder(string pFlexsdkPath) {
			if (Path.GetFileName(pFlexsdkPath) == "bin")
				pFlexsdkPath = Path.GetDirectoryName(pFlexsdkPath);

			setupRemotingServer();

			_sdkPath = pFlexsdkPath;
			_mxmlcPath = Path.Combine(Path.Combine(pFlexsdkPath, "lib"), @"mxmlc.jar");
			_fcshPath = Path.Combine(Path.Combine(pFlexsdkPath, "lib"), @"fcsh.jar");

			bool mxmlcExists = File.Exists(_mxmlcPath);
			bool fcshExists = File.Exists(_fcshPath);

			if (!mxmlcExists)
				throw new Exception(@"Could not locate lib\mxmlc.jar in Flex SDK. Please set the correct path to the Flex SDK in AS3Context plugin settings.");

			if (!fcshExists) {
				return;
			}

			_fcsh = Activator.GetObject(typeof(FlexCompilerShell),
										@"ipc://" + _ipcName + "/FlexCompilerShell") as FlexCompilerShell;
		}

		public string[] Compile(string pWorkingdir, string pArguments, bool pConfigChanged, out string pOutput) {
			string[] errors;

			if (_fcsh != null) {
				string jvmarg1 = VMARGS + @" -Dapplication.home=""" + _sdkPath + @""" -jar """ + _fcshPath + @"""";
				
				Console.WriteLine(@"Compiling with fcsh...");
				_fcsh.Compile(pWorkingdir, pConfigChanged, pArguments, out pOutput, out errors, jvmarg1);

				return errors;

			} 

			string jvmarg2 = VMARGS + " -jar \"" + _mxmlcPath + @""" +flexlib=""" + Path.Combine(_sdkPath, "frameworks") + "\" ";
			Console.WriteLine(@"Compiling with mxmlc...");
			string[] output;

			if (!ProcessRunner.Run(@"java.exe", jvmarg2 + pArguments, false, out output, out errors)) {
				pOutput = string.Join("\n", output);
				return new[] { @"Build halted with errors (mxmlc)." };
			}

			pOutput = string.Empty;
			return new string[0];
			
		}
	}
}
