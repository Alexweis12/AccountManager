using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Account_Manager
{

    /// <summary>
    /// Completely handles XML use of this application.
    /// </summary>
    public static class Xml
    {

        /// <summary>
        /// The ListBox to use for logging.
        /// </summary>
        private static ListBox log;
        /// <summary>
        /// The XmlDocument that will manage our xml file.
        /// </summary>
        private static XmlDocument xmlDocument;


        /// <summary>
        /// Returns the full file path to AccountData.xml.
        /// </summary>
        private static string FilePath
        {
            // Return the full path to AccountData.xml.
            get { return AppDomain.CurrentDomain.BaseDirectory + "/AccountData.xml"; }
        }

        /// <summary>
        /// Initializes the Xml class.
        /// </summary>
        /// <param name="listBox">The ListBox to use for logging.</param>
        public static void Initialize(ListBox listBox)
        {
            // Set log to the given value of listBox.
            log = listBox;
            // Set xmlDocument to a new XmlDocument.
            xmlDocument = new XmlDocument();

            // If AccountData.xml does not exist, create it with a single node.
            if (!File.Exists(FilePath)) { File.WriteAllText(FilePath, "<Accounts></Accounts>"); }

            // Load AccountData.xml into xmlDocument.
            xmlDocument.Load(FilePath);
        }

        /// <summary>
        /// Tries to find AccountData with the given name and slot.
        /// </summary>
        /// <param name="name">Name of the account.</param>
        /// <param name="slot">Slot the data is located in.</param>
        /// <returns>The desired AccountData if found, empty AccountData otherwise.</returns>
        public static AccountData GetAccount(string name, string slot)
        {
            // Create a local variable to store a list of nodes.
            XmlNodeList nodes = xmlDocument.DocumentElement.ChildNodes;
            // Interate through all the nodes.
            for (int i = 0; i < nodes.Count; i++)
            {
                // If the current nodes name is equal to the value of name.
                if (nodes[i].Name == name)
                {
                    // Create a local variable to store the current node as an XmlElement.
                    XmlElement _ = (XmlElement)nodes[i];
                    /* If there is an attribute called 'Slot' and its equal to the
                        value of slot. */
                    if (_.GetAttribute("Slot") == slot.ToString())
                    {
                        // Return new AccountData containing the EmailUser, and Password.
                        return new AccountData(
                            _.GetAttribute("EmailUser"),
                            name,
                            _.GetAttribute("Password"),
                            slot);
                    }
                }
            }

            // Return empty AccountData.
            return new AccountData(string.Empty, string.Empty, string.Empty, string.Empty);
        }

        /// <summary>
        /// Creates/Updates the given account data on/from the xmlDocument.
        /// </summary>
        /// <param name="data">The AccountData you wish to add to xmlDocument.</param>
        public static void SetAccount(AccountData data)
        {
            // Create a local variable to store a potential element to replace.
            XmlElement elementToReplace = null;
            // Create a local variable to store a list of nodes.
            XmlNodeList nodes = xmlDocument.DocumentElement.ChildNodes;
            // Interate through all the nodes.
            for (int i = 0; i < nodes.Count; i++)
            {
                // If the current nodes name is equal to the name of the given data.
                if (nodes[i].Name == data.Name)
                {
                    // Create a local variable to store the current node as an XmlElement.
                    XmlElement _ = (XmlElement)nodes[i];
                    /* If there is an attribute called 'Slot' and its equal to the
                        slot of the given data. */
                    if (_.GetAttribute("Slot") == data.Slot.ToString())
                    {
                        // Set elementToReplace to _.
                        elementToReplace = _;
                        // Break out of the for loop.
                        break;
                    }
                }
            }

            // If elementToReplace isn't null.
            if (elementToReplace != null)
            {
                // Replace elementToReplace with the given data, as an XmlElement.
                xmlDocument.DocumentElement.ReplaceChild(data.ToElement(xmlDocument), elementToReplace);
                // Print a message to the Log ListBox.
                log.Items.Add($"[{data.Name}] [{data.Slot}] - Account has been updated!");
            }
            // If elementToReplace is null.
            else
            {
                // Append the given data, as an XmlElement, to xmlDocument.
                xmlDocument.DocumentElement.AppendChild(data.ToElement(xmlDocument));
                // Print a message to the Log ListBox.
                log.Items.Add($"[{data.Name}] [{data.Slot}] - Account has been added!");
            }
            
            // Save xmlDocument.
            xmlDocument.Save(FilePath);
        }
    }
}