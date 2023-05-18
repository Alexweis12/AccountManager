using System.Xml;

namespace Account_Manager
{

    /// <summary>
    /// A struct to manage account data.
    /// </summary>
    public struct AccountData
    {

        /// <summary>
        /// Constructor for AccountData.
        /// </summary>
        /// <param name="emailuser">Email / Username of the account.</param>
        /// <param name="name">Name of the account.</param>
        /// <param name="password">Password of the account.</param>
        /// <param name="slot">Slot the account information will be in.</param>
        public AccountData(string emailuser, string name, string password, string slot)
        {
            // Set EmailUser to the given value of emailUser.
            EmailUser = emailuser;
            // Set Name to the given value of name.
            Name = name;
            // Set Password to the given value of password.
            Password = password;
            // Set Slot to the given value of slot.
            Slot = slot;
        }

        /// <summary>
        /// Property to contain the email / username of the account.
        /// </summary>
        public string EmailUser { get; private set; }

        /// <summary>
        /// Returns true if Name is equal to string.Empty or null.
        /// </summary>
        public bool IsEmpty { get { return (Name == string.Empty || Name == null); } }

        /// <summary>
        /// Property to contain the name of the account.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Property to contain the password of the account.
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// Property to contain the slot which the account is in.
        /// </summary>
        public string Slot { get; private set; }

        /// <summary>
        /// Converts the AccountData to an XmlElement.
        /// </summary>
        /// <param name="xmlDocument">The XmlDocument to use to create the XmlElement.</param>
        /// <returns>A new XmlElement containing the name, slot, 
        /// email / user, and password of the account
        /// </returns>
        public XmlElement ToElement(XmlDocument xmlDocument)
        {
            // Create a local variable to hold a new XmlElement.
            XmlElement _ = xmlDocument.CreateElement(Name);
            // Set an attribute called 'Slot' and set its content to Slot.
            _.SetAttribute("Slot", Slot);
            // Set an attribute called 'EmailUser' and set its content to EmailUser.
            _.SetAttribute("EmailUser", EmailUser);
            // Set an attribute called 'Password' and set its content to Password.
            _.SetAttribute("Password", Password);

            // Return _.
            return _;
        }
    }
}