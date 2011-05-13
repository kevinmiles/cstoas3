using System;
using System.Runtime.Remoting.Channels;

namespace CsCompiler.JsWriter {
	using System.Collections.Generic;
	using System.IO;
	using System.Runtime.Remoting;
	using System.Runtime.Remoting.Channels.Ipc;
	using Tools;

	internal class JsProjectBuilder {
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

		public JsProjectBuilder(string pFlexsdkPath) {
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

		public ICollection<Error> Compile(string pWorkingdir, string pArguments, bool pConfigChanged, out string pOutput) {
			string[] errors;
			pOutput = null;
			return new List<Error>();
		}
	}
}
