
namespace Account_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComboBox_Slot = new System.Windows.Forms.ComboBox();
            this.List_Accounts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox_AccountData = new System.Windows.Forms.GroupBox();
            this.Button_ResetAccount = new System.Windows.Forms.Button();
            this.Button_SetAccount = new System.Windows.Forms.Button();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_EmailUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox_GeneratedPassword = new System.Windows.Forms.RichTextBox();
            this.Button_CopyPassword = new System.Windows.Forms.Button();
            this.Button_GeneratePassword = new System.Windows.Forms.Button();
            this.Numeric_PasswordLength = new System.Windows.Forms.NumericUpDown();
            this.Lab_PwordLength = new System.Windows.Forms.Label();
            this.ComboBox_PasswordType = new System.Windows.Forms.ComboBox();
            this.Lab_PWordType = new System.Windows.Forms.Label();
            this.List_Log = new System.Windows.Forms.ListBox();
            this.Button_CheckForUpdates = new System.Windows.Forms.Button();
            this.Button_EditAccountList = new System.Windows.Forms.Button();
            this.GroupBox_AccountData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox_Slot
            // 
            this.ComboBox_Slot.FormattingEnabled = true;
            this.ComboBox_Slot.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.ComboBox_Slot.Location = new System.Drawing.Point(344, 13);
            this.ComboBox_Slot.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_Slot.Name = "ComboBox_Slot";
            this.ComboBox_Slot.Size = new System.Drawing.Size(72, 33);
            this.ComboBox_Slot.TabIndex = 1;
            this.ComboBox_Slot.Text = "A";
            this.ComboBox_Slot.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Slot_SelectedIndexChanged);
            // 
            // List_Accounts
            // 
            this.List_Accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.List_Accounts.FormattingEnabled = true;
            this.List_Accounts.ItemHeight = 29;
            this.List_Accounts.Items.AddRange(new object[] {
            "Place_Holder (001)",
            "Place_Holder (002)",
            "Place_Holder (003)",
            "Place_Holder (004)",
            "Place_Holder (005)",
            "Place_Holder (006)",
            "Place_Holder (007)",
            "Place_Holder (008)",
            "Place_Holder (009)",
            "Place_Holder (010)"});
            this.List_Accounts.Location = new System.Drawing.Point(16, 56);
            this.List_Accounts.Margin = new System.Windows.Forms.Padding(4);
            this.List_Accounts.Name = "List_Accounts";
            this.List_Accounts.Size = new System.Drawing.Size(400, 671);
            this.List_Accounts.TabIndex = 2;
            this.List_Accounts.SelectedIndexChanged += new System.EventHandler(this.List_Accounts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Accounts:       |       Account Slot:\r\n";
            // 
            // GroupBox_AccountData
            // 
            this.GroupBox_AccountData.Controls.Add(this.Button_ResetAccount);
            this.GroupBox_AccountData.Controls.Add(this.Button_SetAccount);
            this.GroupBox_AccountData.Controls.Add(this.TextBox_Password);
            this.GroupBox_AccountData.Controls.Add(this.label3);
            this.GroupBox_AccountData.Controls.Add(this.TextBox_EmailUser);
            this.GroupBox_AccountData.Controls.Add(this.label2);
            this.GroupBox_AccountData.Location = new System.Drawing.Point(423, 13);
            this.GroupBox_AccountData.Name = "GroupBox_AccountData";
            this.GroupBox_AccountData.Size = new System.Drawing.Size(730, 183);
            this.GroupBox_AccountData.TabIndex = 4;
            this.GroupBox_AccountData.TabStop = false;
            this.GroupBox_AccountData.Text = "Account Data: None selected";
            // 
            // Button_ResetAccount
            // 
            this.Button_ResetAccount.Location = new System.Drawing.Point(11, 101);
            this.Button_ResetAccount.Name = "Button_ResetAccount";
            this.Button_ResetAccount.Size = new System.Drawing.Size(246, 68);
            this.Button_ResetAccount.TabIndex = 5;
            this.Button_ResetAccount.Text = "Reset Account";
            this.Button_ResetAccount.UseVisualStyleBackColor = true;
            this.Button_ResetAccount.Click += new System.EventHandler(this.Button_ResetAccount_Click);
            // 
            // Button_SetAccount
            // 
            this.Button_SetAccount.Location = new System.Drawing.Point(263, 101);
            this.Button_SetAccount.Name = "Button_SetAccount";
            this.Button_SetAccount.Size = new System.Drawing.Size(461, 68);
            this.Button_SetAccount.TabIndex = 4;
            this.Button_SetAccount.Text = "Set Account";
            this.Button_SetAccount.UseVisualStyleBackColor = true;
            this.Button_SetAccount.Click += new System.EventHandler(this.Button_SetAccount_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(184, 65);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(540, 30);
            this.TextBox_Password.TabIndex = 3;
            this.TextBox_Password.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // TextBox_EmailUser
            // 
            this.TextBox_EmailUser.Location = new System.Drawing.Point(184, 29);
            this.TextBox_EmailUser.Name = "TextBox_EmailUser";
            this.TextBox_EmailUser.Size = new System.Drawing.Size(540, 30);
            this.TextBox_EmailUser.TabIndex = 1;
            this.TextBox_EmailUser.Text = "Email_UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email / Username:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox_GeneratedPassword);
            this.groupBox2.Controls.Add(this.Button_CopyPassword);
            this.groupBox2.Controls.Add(this.Button_GeneratePassword);
            this.groupBox2.Controls.Add(this.Numeric_PasswordLength);
            this.groupBox2.Controls.Add(this.Lab_PwordLength);
            this.groupBox2.Controls.Add(this.ComboBox_PasswordType);
            this.groupBox2.Controls.Add(this.Lab_PWordType);
            this.groupBox2.Location = new System.Drawing.Point(423, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 237);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password Generator";
            // 
            // TextBox_GeneratedPassword
            // 
            this.TextBox_GeneratedPassword.Location = new System.Drawing.Point(6, 68);
            this.TextBox_GeneratedPassword.Name = "TextBox_GeneratedPassword";
            this.TextBox_GeneratedPassword.ReadOnly = true;
            this.TextBox_GeneratedPassword.Size = new System.Drawing.Size(718, 163);
            this.TextBox_GeneratedPassword.TabIndex = 7;
            this.TextBox_GeneratedPassword.Text = "";
            // 
            // Button_CopyPassword
            // 
            this.Button_CopyPassword.Location = new System.Drawing.Point(592, 29);
            this.Button_CopyPassword.Name = "Button_CopyPassword";
            this.Button_CopyPassword.Size = new System.Drawing.Size(132, 31);
            this.Button_CopyPassword.TabIndex = 6;
            this.Button_CopyPassword.Text = "Copy";
            this.Button_CopyPassword.UseVisualStyleBackColor = true;
            this.Button_CopyPassword.Click += new System.EventHandler(this.Button_CopyPassword_Click);
            // 
            // Button_GeneratePassword
            // 
            this.Button_GeneratePassword.Location = new System.Drawing.Point(411, 29);
            this.Button_GeneratePassword.Name = "Button_GeneratePassword";
            this.Button_GeneratePassword.Size = new System.Drawing.Size(175, 31);
            this.Button_GeneratePassword.TabIndex = 5;
            this.Button_GeneratePassword.Text = "Generate";
            this.Button_GeneratePassword.UseVisualStyleBackColor = true;
            this.Button_GeneratePassword.Click += new System.EventHandler(this.Button_GeneratePassword_Click);
            // 
            // Numeric_PasswordLength
            // 
            this.Numeric_PasswordLength.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Numeric_PasswordLength.Location = new System.Drawing.Point(285, 30);
            this.Numeric_PasswordLength.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Numeric_PasswordLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Numeric_PasswordLength.Name = "Numeric_PasswordLength";
            this.Numeric_PasswordLength.Size = new System.Drawing.Size(120, 30);
            this.Numeric_PasswordLength.TabIndex = 4;
            this.Numeric_PasswordLength.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // Lab_PwordLength
            // 
            this.Lab_PwordLength.AutoSize = true;
            this.Lab_PwordLength.Location = new System.Drawing.Point(201, 32);
            this.Lab_PwordLength.Name = "Lab_PwordLength";
            this.Lab_PwordLength.Size = new System.Drawing.Size(78, 25);
            this.Lab_PwordLength.TabIndex = 2;
            this.Lab_PwordLength.Text = "Length:";
            // 
            // ComboBox_PasswordType
            // 
            this.ComboBox_PasswordType.FormattingEnabled = true;
            this.ComboBox_PasswordType.Items.AddRange(new object[] {
            "1",
            "a",
            "A",
            "A1",
            "Ab",
            "Ab1",
            "b1"});
            this.ComboBox_PasswordType.Location = new System.Drawing.Point(74, 29);
            this.ComboBox_PasswordType.Name = "ComboBox_PasswordType";
            this.ComboBox_PasswordType.Size = new System.Drawing.Size(121, 33);
            this.ComboBox_PasswordType.Sorted = true;
            this.ComboBox_PasswordType.TabIndex = 1;
            this.ComboBox_PasswordType.Text = "Ab1";
            // 
            // Lab_PWordType
            // 
            this.Lab_PWordType.AutoSize = true;
            this.Lab_PWordType.Location = new System.Drawing.Point(5, 32);
            this.Lab_PWordType.Name = "Lab_PWordType";
            this.Lab_PWordType.Size = new System.Drawing.Size(63, 25);
            this.Lab_PWordType.TabIndex = 0;
            this.Lab_PWordType.Text = "Type:";
            // 
            // List_Log
            // 
            this.List_Log.FormattingEnabled = true;
            this.List_Log.ItemHeight = 25;
            this.List_Log.Items.AddRange(new object[] {
            "Created by: Alex weis",
            "===== STARTED ========================="});
            this.List_Log.Location = new System.Drawing.Point(423, 448);
            this.List_Log.Name = "List_Log";
            this.List_Log.Size = new System.Drawing.Size(730, 229);
            this.List_Log.TabIndex = 6;
            // 
            // Button_CheckForUpdates
            // 
            this.Button_CheckForUpdates.Location = new System.Drawing.Point(423, 683);
            this.Button_CheckForUpdates.Name = "Button_CheckForUpdates";
            this.Button_CheckForUpdates.Size = new System.Drawing.Size(456, 44);
            this.Button_CheckForUpdates.TabIndex = 7;
            this.Button_CheckForUpdates.Text = "Check for updates";
            this.Button_CheckForUpdates.UseVisualStyleBackColor = true;
            this.Button_CheckForUpdates.Click += new System.EventHandler(this.Button_CheckForUpdates_Click);
            // 
            // Button_EditAccountList
            // 
            this.Button_EditAccountList.Location = new System.Drawing.Point(885, 683);
            this.Button_EditAccountList.Name = "Button_EditAccountList";
            this.Button_EditAccountList.Size = new System.Drawing.Size(268, 44);
            this.Button_EditAccountList.TabIndex = 8;
            this.Button_EditAccountList.Text = "Edit Account List";
            this.Button_EditAccountList.UseVisualStyleBackColor = true;
            this.Button_EditAccountList.Click += new System.EventHandler(this.Button_EditAccountList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 744);
            this.Controls.Add(this.Button_EditAccountList);
            this.Controls.Add(this.Button_CheckForUpdates);
            this.Controls.Add(this.List_Log);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox_AccountData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_Accounts);
            this.Controls.Add(this.ComboBox_Slot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Account Manager | v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_AccountData.ResumeLayout(false);
            this.GroupBox_AccountData.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_PasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBox_Slot;
        private System.Windows.Forms.ListBox List_Accounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBox_AccountData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_EmailUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_ResetAccount;
        private System.Windows.Forms.Button Button_SetAccount;
        private System.Windows.Forms.ListBox List_Log;
        private System.Windows.Forms.ComboBox ComboBox_PasswordType;
        private System.Windows.Forms.Label Lab_PWordType;
        private System.Windows.Forms.NumericUpDown Numeric_PasswordLength;
        private System.Windows.Forms.Label Lab_PwordLength;
        private System.Windows.Forms.Button Button_GeneratePassword;
        private System.Windows.Forms.Button Button_CopyPassword;
        private System.Windows.Forms.RichTextBox TextBox_GeneratedPassword;
        private System.Windows.Forms.Button Button_CheckForUpdates;
        private System.Windows.Forms.Button Button_EditAccountList;
    }
}

