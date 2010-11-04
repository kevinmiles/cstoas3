namespace CStoFlash {
	using System;
	using System.IO;
	using System.Reflection;
	using System.Xml;
	using System.Xml.Serialization;

	public abstract class Configuration<T> where T : Configuration<T>, new() {
		static string _localPath;
		protected static T load(string pFileName) {
			string codeBase = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
			if (codeBase == null) {
				return default(T);
			}

			Uri uri = new Uri(codeBase);
			_localPath = uri.LocalPath;
			string file = Path.Combine(uri.LocalPath, pFileName);

			using (
				XmlReader xtr = XmlReader.Create(file,
													new XmlReaderSettings {
														IgnoreComments = true,
														IgnoreWhitespace = true,
														DtdProcessing = DtdProcessing.Ignore,
														XmlResolver = null
													})) {
				XmlSerializer serializer = new XmlSerializer(typeof (T));

				return (T)serializer.Deserialize(xtr);
			}
		}

		public static string ParsePath(string pPath) {
			return pPath.Replace("%root%", _localPath);
		}
	}
}
