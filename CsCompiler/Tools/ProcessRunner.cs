using System;
using System.Text;

namespace CsCompiler.Tools {
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.IO;
	using System.Threading;

	public static class ProcessRunner {
		public static bool Run(string pFileName, string pArguments, bool pIgnoreExitCode, out string[] pMessages, out ICollection<Error> pErrors) {
			Process process = new Process {
				StartInfo = {
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					StandardOutputEncoding = Encoding.Default,
					StandardErrorEncoding = Encoding.Default,
					CreateNoWindow = true,
					FileName = pFileName,
					Arguments = pArguments,
					WorkingDirectory = Environment.CurrentDirectory
				}
			};

			process.Start();

			// capture output in a separate thread
			LineFilter stdoutFilter = new LineFilter(process.StandardOutput);
			LineFilter stderrFilter = new LineFilter(process.StandardError);

			Thread outThread = new Thread(stdoutFilter.Filter);
			Thread errThread = new Thread(stderrFilter.Filter);

			outThread.Start();
			errThread.Start();

			process.WaitForExit();

			outThread.Join(1000);
			errThread.Join(1000);

			pMessages = stdoutFilter.Lines.ToArray();

			pErrors = new List<Error>();
			foreach (string line in stderrFilter.Lines) {
				pErrors.Add(new Error{Message = line});
			}

			return (pIgnoreExitCode) ? stderrFilter.Lines.Count == 0 : process.ExitCode == 0;
		}
	}

	sealed class LineFilter {
		readonly TextReader _reader;
		
		public LineFilter(TextReader pReader) {
			_reader = pReader;
			Lines = new List<string>();
		}

		public List<string> Lines {
			get; private set; }

		public void Filter() {
			while (true) {
				string line = _reader.ReadLine();
				if (line == null)
					break;

				if (string.IsNullOrEmpty(line)) {
					continue;
				}

				Lines.Add(line);	
			}
		}
	}

}
