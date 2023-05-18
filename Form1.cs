using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Account_Manager
{

    public partial class Form1 : Form
    {

        /// <summary>
        /// The current instance of Form1.
        /// </summary>
        public static Form1 instance;

        #region Arrays
        /// <summary>
        /// An array of lower-case letters, ranging from 'a' to 'z'.
        /// </summary>
        private char[] Array_LCLetters
        {
            get
            {
                // Return a new character array.
                return new char[]
                {
                    'a', 'b', 'c', 'd', 'e',
                    'f', 'g', 'h', 'i', 'j',
                    'k', 'l', 'm', 'n', 'o',
                    'p', 'q', 'r', 's', 't',
                    'u', 'v', 'w', 'x', 'y',
                    'z'
                };
            }
        }

        /// <summary>
        /// An array of upper-case letters, ranging from 'A' to 'Z'.
        /// </summary>
        private char[] Array_UCLetters
        {
            get
            {
                // Return a new character array.
                return new char[]
                {
                    'A', 'B', 'C', 'D', 'E',
                    'F', 'G', 'H', 'I', 'J',
                    'K', 'L', 'M', 'N', 'O',
                    'P', 'Q', 'R', 'S', 'T',
                    'U', 'V', 'W', 'X', 'Y',
                    'Z'
                };
            }
        }
        #endregion

        #region Buttons
        /// <summary>
        /// Called when the CheckForUpdates button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_CheckForUpdates_Click(object sender, EventArgs e)
        {
            // Opens a website with the users default web-browser.
            //System.Diagnostics.Process.Start("https://github.com/Alexweis12/AccountManager");
            MessageBox.Show("This option has been deprecated.", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Called when the CopyPassword button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_CopyPassword_Click(object sender, EventArgs e)
        {
            /* Create a local variable to store the text contained within'
                the GeneratedPassword TextBox. */
            string _ = TextBox_GeneratedPassword.Text;
            // If _ is empty or null, set _ to "NULL".
            if (_ == string.Empty || _ == null) { _ = "NULL"; }

            // Set the text our ClipBoard contains to _.
            Clipboard.SetText(_);
            // Print a message to the Log ListBox.
            List_Log.Items.Add("< Copied password from password generator to clipboard >");
        }

        /// <summary>
        /// Called when the EditAccountList button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_EditAccountList_Click(object sender, EventArgs e)
        {
            /* Create a MessageBox to tell the user that changes 
                won't be made until the program is restarted */
            MessageBox.Show(
                "Any changes to this list won't be seen until the program is restarted.\n" +
                "Please don't use spaces or any special characters as errors may occur.",
                "AccountManager");
            // Opens the account list file with the users default application to edit .txt files.
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "/Accounts.txt");
        }

        /// <summary>
        /// Called when the GeneratePassword button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_GeneratePassword_Click(object sender, EventArgs e)
        {
            /* Create a local variable to store the result of 
                ComboBox_PasswordType.Text.Contains("A"). */
            bool _UseCapital = ComboBox_PasswordType.Text.Contains("A");
            /* Create a local variable to store the result of 
                ComboBox_PasswordType.Text.Contains("b"). */
            bool _UseLower = ComboBox_PasswordType.Text.Contains("b");
            /* Create a local variable to store the result of 
                ComboBox_PasswordType.Text.Contains("1"). */
            bool _UseNumbers = ComboBox_PasswordType.Text.Contains("1");

            // Create a local variable to store the generated password.
            string _Password = string.Empty;
            // Interate from 0 to the value of Numeric_PasswordLength.Value.
            for (int i = 0; i < Numeric_PasswordLength.Value; i++)
            {
                /* Create a local variable to hold a new Random. 
                    The seed being i * DateTime.Now.Millisecond. */
                Random r = new Random(i * DateTime.Now.Millisecond);
                // Create a local variable to store a random number between 0 - 2.
                int choice = r.Next(3);
                /* A switch statement to decide what type of character to
                    insert into the generated password. */
                switch (choice)
                {
                    // If choice is 0 (Upper case character).
                    case 0:
                        /* If _UseCapital is true, insert a random character from the
                            UCLetters array into the generated password. */
                        if (_UseCapital) { _Password += Array_UCLetters[r.Next(Array_UCLetters.Length)]; }
                        /* If _UseCapital is false but _UseLower is true, 
                            insert a random character from the LCLetters array
                            into the generated password. */
                        else if (_UseLower) { _Password += Array_LCLetters[r.Next(Array_LCLetters.Length)]; }
                        /* If _UseLower is false but _UseNumbers is true,
                            insert a random character ranging from 0 - 9
                            into the generated password. */
                        else if (_UseNumbers) { _Password += r.Next(10).ToString(); }
                        /* If _UseCapital, _UseLower, and _UseNumber are false.
                            insert a 0 into the generated password. */
                        else { _Password += '0'; }
                        // Break out of switch statement.
                        break;

                    // If choice is 1 (Lower case character).
                    case 1:
                        /* If _UseLower is true,  insert a random character from the 
                            LCLetters array into the generated password. */
                        if (_UseLower) { _Password += Array_LCLetters[r.Next(Array_LCLetters.Length)]; }
                        /* If _UseLower is false but _UseNumbers is true,
                            insert a random character ranging from 0 - 9
                            into the generated password. */
                        else if (_UseNumbers) { _Password += r.Next(10).ToString(); }
                        /* If _UseNumbers is false but _UseCapital is true, 
                            insert a random character from the UCLetters array 
                            into the generated password. */
                        else if (_UseCapital) { _Password += Array_UCLetters[r.Next(Array_UCLetters.Length)]; }
                        /* If _UseLower, _UseNumber, and _UseCapital are false.
                            insert a 1 into the generated password. */
                        else { _Password += '1'; }
                        // Break out of switch statement.
                        break;

                    // If choice is 2 (Number).
                    case 2:
                        /* If _UseNumbers is true, insert a random character ranging 
                            from 0 - 9 into the generated password. */
                        if (_UseNumbers) { _Password += r.Next(10).ToString(); }
                        /* If _UseNumbers is false but _UseCapital is true, 
                            insert a random character from the UCLetters array 
                            into the generated password. */
                        else if (_UseCapital) { _Password += Array_UCLetters[r.Next(Array_UCLetters.Length)]; }
                        /* If _UseCapital is false but _UseLower is true, 
                            insert a random character from the LCLetters array
                            into the generated password. */
                        else if (_UseLower) { _Password += Array_LCLetters[r.Next(Array_LCLetters.Length)]; }
                        /* If _UseNumber, _UseCapital, and _UseLower are false.
                            insert a 2 into the generated password. */
                        else { _Password += '2'; }
                        // Break out of switch statement.
                        break;
                }
            }

            // Set the contents of TextBox_GeneratedPassword to the generated password.
            TextBox_GeneratedPassword.Text = _Password;
            // Print a message to the Log ListBox.
            List_Log.Items.Add(
                $"< Generated password type [{ComboBox_PasswordType.Text}] " +
                $"with a length of [{Numeric_PasswordLength.Value}] characters >");
        }

        /// <summary>
        /// Called when the ResetAccount button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ResetAccount_Click(object sender, EventArgs e)
        {
            /* Create a local variable to store the result of 
                a MessageBox asking the user if they're sure
                they want to reset this account. */
            DialogResult dr = MessageBox.Show(
                "Are you sure you want to reset this account?",
                "AccountManager",
                MessageBoxButtons.YesNo);

            // If the user clicked yes on the MessageBox.
            if (dr == DialogResult.Yes)
            {
                // If none of List_Accounts items are selected, return.
                if(List_Accounts.SelectedItem == null) { return; }
                // If the content of ComboBox_Slot is null, return.
                if (ComboBox_Slot.Text == null) { return; }

                /* Create a local variable to store an empty AccountData
                    using the selected account, and slot. */
                AccountData data = new AccountData(
                string.Empty,
                List_Accounts.SelectedItem.ToString(),
                string.Empty,
                ComboBox_Slot.Text);

                // Set the AccountData for the current account to data.
                Xml.SetAccount(data);

                // Call RefreshAccountData to refresh the account data shown.
                RefreshAccountData();
            }
        }

        /// <summary>
        /// Called when the SetAccount button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SetAccount_Click(object sender, EventArgs e)
        {
            // If none of List_Accounts items are selected, return.
            if (List_Accounts.SelectedItem == null) { return; }
            // If the content of ComboBox_Slot is null, return.
            if(ComboBox_Slot.Text == null) { return; }

            /* Create a local variable to store new AccountData
            that contains the contents of TextBox_EmailUser,
            the selected account,
            the contents of TextBox_Password,
            and the currently selected slot. */
            AccountData data = new AccountData(
                TextBox_EmailUser.Text,
                List_Accounts.SelectedItem.ToString(),
                TextBox_Password.Text,
                ComboBox_Slot.Text);

            // Set the AccountData for the current account to data.
            Xml.SetAccount(data);
        }
        #endregion

        #region ComboBox
        /// <summary>
        /// Called when the index of ComboBox_Slot is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_Slot_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call RefreshAccountData to refresh the account data shown.
            RefreshAccountData();
        }
        #endregion

        #region Form
        /// <summary>
        /// Initialization.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // Set instance to this instance.
            instance = this;
        }

        /// <summary>
        /// Called when the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            /* Initalize the Xml class, and pass List_Log
                as an argument. */
            Xml.Initialize(List_Log);

            // Clear the items in List_Accounts.
            List_Accounts.Items.Clear();
            // Clear the contents of TextBox_EmailUser.
            TextBox_EmailUser.Clear();
            // Clear the contents of TextBox_Password.
            TextBox_Password.Clear();

            // Create a local variable to store the full filepath to Accounts.txt.
            string accountList = AppDomain.CurrentDomain.BaseDirectory + "/Accounts.txt";
            // If Accounts.txt does not exist.
            if (!File.Exists(accountList))
            {
                // Write a template account list to Accounts.txt.
                File.WriteAllLines(accountList, new string[]
                {
                    "Amazon",
                    "Github",
                    "Google",
                    "Microsoft"
                });

                // Print a message to the Log ListBox.
                List_Log.Items.Add("< Added default account list >");
            }
            // If Accounts.txt does exist.
            else
            {
                // Create a local variable to hold a list of account names.
                List<string> accountNames = new List<string>();
                // Add every line found in Accounts.txt to accountNames.
                accountNames.AddRange(File.ReadAllLines(accountList));
                // Sort the accounts in accountNames.
                accountNames.Sort();

                // Write the sorted account names back to Accounts.txt.
                File.WriteAllLines(accountList, accountNames.ToArray());
                // Interate through each accountName.
                for (int i = 0; i < accountNames.Count; i++)
                {
                    // Add the current account name to the List_Accounts ListBox.
                    List_Accounts.Items.Add(accountNames[i]);
                }
            }
        }
        #endregion

        #region List
        /// <summary>
        /// Called when the index of the List_Accounts ListBox has changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Set the title of GroupBox_AccountData to
                AccountData: [CURRENTLY SELECTED ACCOUNT NAME HERE]*/
            GroupBox_AccountData.Text = $"Account Data: {List_Accounts.SelectedItem.ToString()}";

            // Call RefreshAccountData to refresh the account data shown.
            RefreshAccountData();
        }
        #endregion

        /// <summary>
        /// Refreshes the currently displayed account data.
        /// </summary>
        private void RefreshAccountData()
        {
            // Create a local variable to store the result of Xml.GetAccount.
            AccountData data = Xml.GetAccount(
                List_Accounts.SelectedItem.ToString(),
                ComboBox_Slot.Text);

            // If data is empty.
            if (data.IsEmpty)
            {
                // Set the contents of TextBox_EmailUser to string.Empty.
                TextBox_EmailUser.Text = string.Empty;
                // Set the contents of TextBox_Password to string.Empty.
                TextBox_Password.Text = string.Empty;
                // Return.
                return;
            }

            // Set the contents of TextBox_EmailUser to the Email/User found.
            TextBox_EmailUser.Text = data.EmailUser;
            // Set the contents of TextBox_Password to the password found.
            TextBox_Password.Text = data.Password;
        }
    }
}
