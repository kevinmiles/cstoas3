namespace CsCompiler.VsProjectParser {
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Xml;

	public class VsProject {
		private readonly List<VsProjectConfiguration> _configurations = new List<VsProjectConfiguration>();
		private readonly List<VsProjectItem> _items = new List<VsProjectItem>();
		private readonly string _projectFileName;
		private readonly Dictionary<string, string> _properties = new Dictionary<string, string>();
		private bool _propertiesDictionary;

		private VsProject(string pProjectFileName) {
			_projectFileName = pProjectFileName;
		}

		/// <summary>
		/// 	Gets a read-only collection of project configurations.
		/// </summary>
		/// <value>A read-only collection of project configurations.</value>
		public IList<VsProjectConfiguration> Configurations {
			get { return _configurations; }
		}

		/// <summary>
		/// 	Gets a read-only collection of all .cs files in the solution.
		/// </summary>
		/// <value>A read-only collection of all the .cs files in the solution.</value>
		public IList<VsProjectItem> Items {
			get { return _items; }
		}

		public string ProjectFileName {
			get { return _projectFileName; }
		}

		/// <summary>
		/// 	Gets a read-only collection of project properties.
		/// </summary>
		/// <value>A read-only collection of project properties.</value>
		public IDictionary<string, string> Properties {
			get { return _properties; }
		}

		/// <summary>
		/// 	Finds the VisualStudio project configuration specified by a condition.
		/// </summary>
		/// <param name = "pCondition">The condition which identifies the configuration 
		/// 	(example: " '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ").</param>
		/// <returns><see cref = "VsProjectConfiguration" /> object if found; <c>null</c> if no configuration was found that meets the
		/// 	specified condition.</returns>
		public VsProjectConfiguration FindConfiguration(string pCondition) {
			return
				_configurations.FirstOrDefault(
				                               pConfiguration =>
				                               0 == string.Compare(pConfiguration.Condition, pCondition, StringComparison.Ordinal));
		}

		/// <summary>
		/// 	Loads the specified project file name.
		/// </summary>
		/// <param name = "pProjectFileName">Name of the project file.</param>
		/// <returns>VSProject class containing project information.</returns>
		public static VsProject Load(string pProjectFileName) {
			using (Stream stream = File.OpenRead(pProjectFileName)) {
				VsProject data = new VsProject(pProjectFileName) {_propertiesDictionary = true};

				XmlReaderSettings xmlReaderSettings = new XmlReaderSettings {
					IgnoreComments = true,
					IgnoreProcessingInstructions = true,
					IgnoreWhitespace = true
				};

				using (XmlReader xmlReader = XmlReader.Create(stream, xmlReaderSettings)) {
					xmlReader.Read();
					while (false == xmlReader.EOF) {
						switch (xmlReader.NodeType) {
							case XmlNodeType.XmlDeclaration:
								xmlReader.Read();
								break;


							case XmlNodeType.Element:
								if (xmlReader.Name == "Project") {
									data.readProject(xmlReader);
								}


								xmlReader.Read();
								break;
							default:
								xmlReader.Read();
								continue;
						}
					}
				}
				return data;
			}
		}

		/// <summary>
		/// 	Gets the List of VSProjectItem single type items.
		/// </summary>
		/// <param name = "pGetItemType">Type of the item.</param>
		/// <returns>List of items of specific itemType.</returns>
		public IList<VsProjectItem> GetSingleTypeItems(VsItemType pGetItemType) {
			return Items.Where(pItem => pItem.ItemType == pGetItemType).ToList();
		}

		private void readProject(XmlReader pXmlReader) {
			pXmlReader.Read();

			while (pXmlReader.NodeType != XmlNodeType.EndElement && false == pXmlReader.EOF) {
				switch (pXmlReader.Name) {
					case "PropertyGroup":
						if (_propertiesDictionary) {
							readPropertyGroup(pXmlReader);
							_propertiesDictionary = false;
						} else {
							_configurations.Add(readPropertyGroup(pXmlReader));
						}

						pXmlReader.Read();
						break;
					case "ItemGroup":
						readItemGroup(pXmlReader);
						pXmlReader.Read();
						break;
					default:
						pXmlReader.Read();
						continue;
				}
			}
		}

		private VsProjectConfiguration readPropertyGroup(XmlReader pXmlReader) {
			VsProjectConfiguration configuration = new VsProjectConfiguration();

			if (pXmlReader["Condition"] != null && _propertiesDictionary == false) {
				configuration.Condition = pXmlReader["Condition"];
			}

			pXmlReader.Read();

			while (pXmlReader.NodeType != XmlNodeType.EndElement) {
				if (_propertiesDictionary) {
					if (_properties.ContainsKey(pXmlReader.Name)) {
						throw new ArgumentException(
							string.Format(
							              CultureInfo.InvariantCulture,
							              "Property '{0}' has already been added to the group. VS project '{1}'",
							              pXmlReader.Name,
							              ProjectFileName));
					}

					_properties.Add(pXmlReader.Name, pXmlReader.ReadElementContentAsString());

				} else {
					if (configuration.Properties.ContainsKey(pXmlReader.Name)) {
						throw new ArgumentException(
							string.Format(
							              CultureInfo.InvariantCulture,
							              "Property '{0}' has already been added to the group. VS project '{1}'",
							              pXmlReader.Name,
							              ProjectFileName));
					}

					configuration.Properties.Add(pXmlReader.Name, pXmlReader.ReadElementContentAsString());
				}
			}

			return configuration;
		}
		
		private void readItemGroup(XmlReader pXmlReader) {
			pXmlReader.Read();
			
			while (pXmlReader.NodeType != XmlNodeType.EndElement && false == pXmlReader.EOF) {
				switch (pXmlReader.Name) {
					case "Content":
						VsProjectItem contentItem = readItem(pXmlReader, VsItemType.Content);
						_items.Add(contentItem);
						break;

					case "EmbeddedResource":
						VsProjectItem resourceItem = readItem(pXmlReader, VsItemType.EmbeddedResource);
						_items.Add(resourceItem);
						break;

					case "Compile":
						VsProjectItem compileItems = readItem(pXmlReader, VsItemType.CompileItem);
						_items.Add(compileItems);
						break;
						
					case "None":
						VsProjectItem noneItem = readItem(pXmlReader, VsItemType.None);
						_items.Add(noneItem);
						break;
						
					case "ProjectReference":
						VsProjectItem projectReference = readItem(pXmlReader, VsItemType.ProjectReference);
						_items.Add(projectReference);
						break;
						
					case "Reference":
						VsProjectItem reference = readItem(pXmlReader, VsItemType.Reference);
						_items.Add(reference);
						break;

					default:
						pXmlReader.Skip();
						continue;
				}
			}
		}

		private static VsProjectItem readItem(XmlReader pXmlReader, VsItemType pItemType) {
			VsProjectItem item = new VsProjectItem(pItemType) {Item = pXmlReader["Include"]};
			
			if (false == pXmlReader.IsEmptyElement) {
				pXmlReader.Read();
				
				while (true) {
					if (pXmlReader.NodeType == XmlNodeType.EndElement) {
						break;
					}
					
					readItemProperty(item, pXmlReader);
				}
			}
			
			pXmlReader.Read();
			return item;
		}

		private static void readItemProperty(VsProjectItem pItem, XmlReader pXmlReader) {
			string propertyName = pXmlReader.Name;
			string propertyValue = pXmlReader.ReadElementContentAsString();
			pItem.ItemProperties.Add(propertyName, propertyValue);
		}
	}
}
