namespace CodeGenerator
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.bntExit = new System.Windows.Forms.Button();
            this.tbcCodeTabs = new System.Windows.Forms.TabControl();
            this.tbpForm = new System.Windows.Forms.TabPage();
            this.txtFormCode = new System.Windows.Forms.TextBox();
            this.grbCallForm = new System.Windows.Forms.GroupBox();
            this.txtFormAccept = new System.Windows.Forms.TextBox();
            this.lblAcceptButton = new System.Windows.Forms.Label();
            this.txtFormCancel = new System.Windows.Forms.TextBox();
            this.lblCancelButton = new System.Windows.Forms.Label();
            this.chkShowDialog = new System.Windows.Forms.CheckBox();
            this.bntShowFormCode = new System.Windows.Forms.Button();
            this.txtCallFormVariable = new System.Windows.Forms.TextBox();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.lblCallFormName = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.tbpMenu = new System.Windows.Forms.TabPage();
            this.grbStringMenu = new System.Windows.Forms.GroupBox();
            this.chkStringMenuMethod = new System.Windows.Forms.CheckBox();
            this.bntStringMenuGenerate = new System.Windows.Forms.Button();
            this.lblStringMenuNumber = new System.Windows.Forms.Label();
            this.txtStringMenuNumber = new System.Windows.Forms.TextBox();
            this.grbCharMenu = new System.Windows.Forms.GroupBox();
            this.chkCharMenuMethod = new System.Windows.Forms.CheckBox();
            this.bntCharMenuGenerate = new System.Windows.Forms.Button();
            this.lblCharMenuNumber = new System.Windows.Forms.Label();
            this.txtCharMenuNumber = new System.Windows.Forms.TextBox();
            this.txtMenuCode = new System.Windows.Forms.TextBox();
            this.tbpMessageBox = new System.Windows.Forms.TabPage();
            this.btnMessageBoxPreview = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtDialogVar = new System.Windows.Forms.TextBox();
            this.lblVariable = new System.Windows.Forms.Label();
            this.bntMessageBoxGenerate = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMessageBoxMessage = new System.Windows.Forms.TextBox();
            this.lblDefaultButton = new System.Windows.Forms.Label();
            this.cmbDefaultButton = new System.Windows.Forms.ComboBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblButton = new System.Windows.Forms.Label();
            this.cmbIcon = new System.Windows.Forms.ComboBox();
            this.txtMessageBoxCode = new System.Windows.Forms.TextBox();
            this.cmbButtons = new System.Windows.Forms.ComboBox();
            this.tbpSwitch = new System.Windows.Forms.TabPage();
            this.grbSwitchOptions = new System.Windows.Forms.GroupBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.chkSkip = new System.Windows.Forms.CheckBox();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.chkPatternCase = new System.Windows.Forms.CheckBox();
            this.lblVarName = new System.Windows.Forms.Label();
            this.txtSwitchVar = new System.Windows.Forms.TextBox();
            this.bntSwitchGenerate = new System.Windows.Forms.Button();
            this.lblCaseAmount = new System.Windows.Forms.Label();
            this.txtCaseNumber = new System.Windows.Forms.TextBox();
            this.lblVariableType = new System.Windows.Forms.Label();
            this.cmbSwitchType = new System.Windows.Forms.ComboBox();
            this.txtSwitchCode = new System.Windows.Forms.TextBox();
            this.tbpComment = new System.Windows.Forms.TabPage();
            this.txtCommentCode = new System.Windows.Forms.TextBox();
            this.grbTitleComment = new System.Windows.Forms.GroupBox();
            this.bntTopLineComment = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpApplication = new System.Windows.Forms.TabPage();
            this.bntSave = new System.Windows.Forms.Button();
            this.bntHelp = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.bntSavePath = new System.Windows.Forms.Button();
            this.txtApplication = new System.Windows.Forms.TextBox();
            this.sfdSave = new System.Windows.Forms.FolderBrowserDialog();
            this.ttTool = new System.Windows.Forms.ToolTip(this.components);
            this.tbcCodeTabs.SuspendLayout();
            this.tbpForm.SuspendLayout();
            this.grbCallForm.SuspendLayout();
            this.tbpMenu.SuspendLayout();
            this.grbStringMenu.SuspendLayout();
            this.grbCharMenu.SuspendLayout();
            this.tbpMessageBox.SuspendLayout();
            this.tbpSwitch.SuspendLayout();
            this.grbSwitchOptions.SuspendLayout();
            this.tbpComment.SuspendLayout();
            this.grbTitleComment.SuspendLayout();
            this.tbpApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(775, 502);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 23);
            this.bntExit.TabIndex = 100;
            this.bntExit.Text = "&Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // tbcCodeTabs
            // 
            this.tbcCodeTabs.Controls.Add(this.tbpForm);
            this.tbcCodeTabs.Controls.Add(this.tbpMenu);
            this.tbcCodeTabs.Controls.Add(this.tbpMessageBox);
            this.tbcCodeTabs.Controls.Add(this.tbpSwitch);
            this.tbcCodeTabs.Controls.Add(this.tbpComment);
            this.tbcCodeTabs.Controls.Add(this.tbpApplication);
            this.tbcCodeTabs.Location = new System.Drawing.Point(13, 13);
            this.tbcCodeTabs.Name = "tbcCodeTabs";
            this.tbcCodeTabs.SelectedIndex = 0;
            this.tbcCodeTabs.Size = new System.Drawing.Size(837, 483);
            this.tbcCodeTabs.TabIndex = 1;
            this.tbcCodeTabs.SelectedIndexChanged += new System.EventHandler(this.tbcCodeTabs_OnTabIndexChanged);
            // 
            // tbpForm
            // 
            this.tbpForm.BackColor = System.Drawing.SystemColors.Control;
            this.tbpForm.Controls.Add(this.txtFormCode);
            this.tbpForm.Controls.Add(this.grbCallForm);
            this.tbpForm.Location = new System.Drawing.Point(4, 22);
            this.tbpForm.Name = "tbpForm";
            this.tbpForm.Padding = new System.Windows.Forms.Padding(3);
            this.tbpForm.Size = new System.Drawing.Size(829, 457);
            this.tbpForm.TabIndex = 0;
            this.tbpForm.Text = "Form";
            // 
            // txtFormCode
            // 
            this.txtFormCode.Location = new System.Drawing.Point(6, 177);
            this.txtFormCode.MaxLength = 0;
            this.txtFormCode.Multiline = true;
            this.txtFormCode.Name = "txtFormCode";
            this.txtFormCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFormCode.Size = new System.Drawing.Size(816, 274);
            this.txtFormCode.TabIndex = 7;
            // 
            // grbCallForm
            // 
            this.grbCallForm.Controls.Add(this.txtFormAccept);
            this.grbCallForm.Controls.Add(this.lblAcceptButton);
            this.grbCallForm.Controls.Add(this.txtFormCancel);
            this.grbCallForm.Controls.Add(this.lblCancelButton);
            this.grbCallForm.Controls.Add(this.chkShowDialog);
            this.grbCallForm.Controls.Add(this.bntShowFormCode);
            this.grbCallForm.Controls.Add(this.txtCallFormVariable);
            this.grbCallForm.Controls.Add(this.txtFormName);
            this.grbCallForm.Controls.Add(this.lblCallFormName);
            this.grbCallForm.Controls.Add(this.lblFormName);
            this.grbCallForm.Location = new System.Drawing.Point(6, 6);
            this.grbCallForm.Name = "grbCallForm";
            this.grbCallForm.Size = new System.Drawing.Size(237, 165);
            this.grbCallForm.TabIndex = 0;
            this.grbCallForm.TabStop = false;
            this.grbCallForm.Text = "&Show Form";
            // 
            // txtFormAccept
            // 
            this.txtFormAccept.Location = new System.Drawing.Point(89, 97);
            this.txtFormAccept.Name = "txtFormAccept";
            this.txtFormAccept.Size = new System.Drawing.Size(139, 20);
            this.txtFormAccept.TabIndex = 8;
            // 
            // lblAcceptButton
            // 
            this.lblAcceptButton.AutoSize = true;
            this.lblAcceptButton.Location = new System.Drawing.Point(5, 100);
            this.lblAcceptButton.Name = "lblAcceptButton";
            this.lblAcceptButton.Size = new System.Drawing.Size(78, 13);
            this.lblAcceptButton.TabIndex = 7;
            this.lblAcceptButton.Text = "&Accept Button:";
            // 
            // txtFormCancel
            // 
            this.txtFormCancel.Location = new System.Drawing.Point(89, 71);
            this.txtFormCancel.Name = "txtFormCancel";
            this.txtFormCancel.Size = new System.Drawing.Size(139, 20);
            this.txtFormCancel.TabIndex = 6;
            // 
            // lblCancelButton
            // 
            this.lblCancelButton.AutoSize = true;
            this.lblCancelButton.Location = new System.Drawing.Point(6, 74);
            this.lblCancelButton.Name = "lblCancelButton";
            this.lblCancelButton.Size = new System.Drawing.Size(77, 13);
            this.lblCancelButton.TabIndex = 5;
            this.lblCancelButton.Text = "&Cancel Button:";
            // 
            // chkShowDialog
            // 
            this.chkShowDialog.AutoSize = true;
            this.chkShowDialog.Location = new System.Drawing.Point(64, 140);
            this.chkShowDialog.Name = "chkShowDialog";
            this.chkShowDialog.Size = new System.Drawing.Size(83, 17);
            this.chkShowDialog.TabIndex = 9;
            this.chkShowDialog.Text = "&ShowDialog";
            this.chkShowDialog.UseVisualStyleBackColor = true;
            // 
            // bntShowFormCode
            // 
            this.bntShowFormCode.Location = new System.Drawing.Point(153, 136);
            this.bntShowFormCode.Name = "bntShowFormCode";
            this.bntShowFormCode.Size = new System.Drawing.Size(75, 23);
            this.bntShowFormCode.TabIndex = 10;
            this.bntShowFormCode.Text = "&Generate";
            this.bntShowFormCode.UseVisualStyleBackColor = true;
            this.bntShowFormCode.Click += new System.EventHandler(this.bntShowFormCode_Click);
            // 
            // txtCallFormVariable
            // 
            this.txtCallFormVariable.Location = new System.Drawing.Point(103, 45);
            this.txtCallFormVariable.Name = "txtCallFormVariable";
            this.txtCallFormVariable.Size = new System.Drawing.Size(125, 20);
            this.txtCallFormVariable.TabIndex = 4;
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(73, 19);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(155, 20);
            this.txtFormName.TabIndex = 2;
            // 
            // lblCallFormName
            // 
            this.lblCallFormName.AutoSize = true;
            this.lblCallFormName.Location = new System.Drawing.Point(6, 48);
            this.lblCallFormName.Name = "lblCallFormName";
            this.lblCallFormName.Size = new System.Drawing.Size(94, 13);
            this.lblCallFormName.TabIndex = 3;
            this.lblCallFormName.Text = "&Call Form Variable:";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Location = new System.Drawing.Point(6, 22);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(64, 13);
            this.lblFormName.TabIndex = 1;
            this.lblFormName.Text = "&Form Name:";
            // 
            // tbpMenu
            // 
            this.tbpMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tbpMenu.Controls.Add(this.grbStringMenu);
            this.tbpMenu.Controls.Add(this.grbCharMenu);
            this.tbpMenu.Controls.Add(this.txtMenuCode);
            this.tbpMenu.Location = new System.Drawing.Point(4, 22);
            this.tbpMenu.Name = "tbpMenu";
            this.tbpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMenu.Size = new System.Drawing.Size(829, 457);
            this.tbpMenu.TabIndex = 1;
            this.tbpMenu.Text = "Menus";
            // 
            // grbStringMenu
            // 
            this.grbStringMenu.Controls.Add(this.chkStringMenuMethod);
            this.grbStringMenu.Controls.Add(this.bntStringMenuGenerate);
            this.grbStringMenu.Controls.Add(this.lblStringMenuNumber);
            this.grbStringMenu.Controls.Add(this.txtStringMenuNumber);
            this.grbStringMenu.Location = new System.Drawing.Point(188, 6);
            this.grbStringMenu.Name = "grbStringMenu";
            this.grbStringMenu.Size = new System.Drawing.Size(176, 71);
            this.grbStringMenu.TabIndex = 13;
            this.grbStringMenu.TabStop = false;
            this.grbStringMenu.Text = "String Menu";
            // 
            // chkStringMenuMethod
            // 
            this.chkStringMenuMethod.AutoSize = true;
            this.chkStringMenuMethod.Location = new System.Drawing.Point(9, 43);
            this.chkStringMenuMethod.Name = "chkStringMenuMethod";
            this.chkStringMenuMethod.Size = new System.Drawing.Size(67, 17);
            this.chkStringMenuMethod.TabIndex = 16;
            this.chkStringMenuMethod.Text = "&Methods";
            this.chkStringMenuMethod.UseVisualStyleBackColor = true;
            // 
            // bntStringMenuGenerate
            // 
            this.bntStringMenuGenerate.Location = new System.Drawing.Point(88, 39);
            this.bntStringMenuGenerate.Name = "bntStringMenuGenerate";
            this.bntStringMenuGenerate.Size = new System.Drawing.Size(75, 23);
            this.bntStringMenuGenerate.TabIndex = 17;
            this.bntStringMenuGenerate.Text = "&Generate";
            this.bntStringMenuGenerate.UseVisualStyleBackColor = true;
            this.bntStringMenuGenerate.Click += new System.EventHandler(this.bntStringMenuGenerate_Click);
            // 
            // lblStringMenuNumber
            // 
            this.lblStringMenuNumber.AutoSize = true;
            this.lblStringMenuNumber.Location = new System.Drawing.Point(6, 16);
            this.lblStringMenuNumber.Name = "lblStringMenuNumber";
            this.lblStringMenuNumber.Size = new System.Drawing.Size(76, 13);
            this.lblStringMenuNumber.TabIndex = 14;
            this.lblStringMenuNumber.Text = "&Menu Options:";
            // 
            // txtStringMenuNumber
            // 
            this.txtStringMenuNumber.Location = new System.Drawing.Point(88, 13);
            this.txtStringMenuNumber.Name = "txtStringMenuNumber";
            this.txtStringMenuNumber.Size = new System.Drawing.Size(44, 20);
            this.txtStringMenuNumber.TabIndex = 15;
            // 
            // grbCharMenu
            // 
            this.grbCharMenu.Controls.Add(this.chkCharMenuMethod);
            this.grbCharMenu.Controls.Add(this.bntCharMenuGenerate);
            this.grbCharMenu.Controls.Add(this.lblCharMenuNumber);
            this.grbCharMenu.Controls.Add(this.txtCharMenuNumber);
            this.grbCharMenu.Location = new System.Drawing.Point(6, 6);
            this.grbCharMenu.Name = "grbCharMenu";
            this.grbCharMenu.Size = new System.Drawing.Size(176, 71);
            this.grbCharMenu.TabIndex = 8;
            this.grbCharMenu.TabStop = false;
            this.grbCharMenu.Text = "Char Menu";
            // 
            // chkCharMenuMethod
            // 
            this.chkCharMenuMethod.AutoSize = true;
            this.chkCharMenuMethod.Location = new System.Drawing.Point(9, 43);
            this.chkCharMenuMethod.Name = "chkCharMenuMethod";
            this.chkCharMenuMethod.Size = new System.Drawing.Size(67, 17);
            this.chkCharMenuMethod.TabIndex = 11;
            this.chkCharMenuMethod.Text = "&Methods";
            this.chkCharMenuMethod.UseVisualStyleBackColor = true;
            // 
            // bntCharMenuGenerate
            // 
            this.bntCharMenuGenerate.Location = new System.Drawing.Point(88, 39);
            this.bntCharMenuGenerate.Name = "bntCharMenuGenerate";
            this.bntCharMenuGenerate.Size = new System.Drawing.Size(75, 23);
            this.bntCharMenuGenerate.TabIndex = 12;
            this.bntCharMenuGenerate.Text = "&Generate";
            this.bntCharMenuGenerate.UseVisualStyleBackColor = true;
            this.bntCharMenuGenerate.Click += new System.EventHandler(this.bntCharMenuGenerate_Click);
            // 
            // lblCharMenuNumber
            // 
            this.lblCharMenuNumber.AutoSize = true;
            this.lblCharMenuNumber.Location = new System.Drawing.Point(6, 16);
            this.lblCharMenuNumber.Name = "lblCharMenuNumber";
            this.lblCharMenuNumber.Size = new System.Drawing.Size(76, 13);
            this.lblCharMenuNumber.TabIndex = 9;
            this.lblCharMenuNumber.Text = "&Menu Options:";
            // 
            // txtCharMenuNumber
            // 
            this.txtCharMenuNumber.Location = new System.Drawing.Point(88, 13);
            this.txtCharMenuNumber.Name = "txtCharMenuNumber";
            this.txtCharMenuNumber.Size = new System.Drawing.Size(44, 20);
            this.txtCharMenuNumber.TabIndex = 10;
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.Location = new System.Drawing.Point(6, 177);
            this.txtMenuCode.MaxLength = 0;
            this.txtMenuCode.Multiline = true;
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMenuCode.Size = new System.Drawing.Size(816, 274);
            this.txtMenuCode.TabIndex = 18;
            // 
            // tbpMessageBox
            // 
            this.tbpMessageBox.BackColor = System.Drawing.SystemColors.Control;
            this.tbpMessageBox.Controls.Add(this.btnMessageBoxPreview);
            this.tbpMessageBox.Controls.Add(this.lblTitle);
            this.tbpMessageBox.Controls.Add(this.lblMessage);
            this.tbpMessageBox.Controls.Add(this.txtDialogVar);
            this.tbpMessageBox.Controls.Add(this.lblVariable);
            this.tbpMessageBox.Controls.Add(this.bntMessageBoxGenerate);
            this.tbpMessageBox.Controls.Add(this.txtTitle);
            this.tbpMessageBox.Controls.Add(this.txtMessageBoxMessage);
            this.tbpMessageBox.Controls.Add(this.lblDefaultButton);
            this.tbpMessageBox.Controls.Add(this.cmbDefaultButton);
            this.tbpMessageBox.Controls.Add(this.lblIcon);
            this.tbpMessageBox.Controls.Add(this.lblButton);
            this.tbpMessageBox.Controls.Add(this.cmbIcon);
            this.tbpMessageBox.Controls.Add(this.txtMessageBoxCode);
            this.tbpMessageBox.Controls.Add(this.cmbButtons);
            this.tbpMessageBox.Location = new System.Drawing.Point(4, 22);
            this.tbpMessageBox.Name = "tbpMessageBox";
            this.tbpMessageBox.Size = new System.Drawing.Size(829, 457);
            this.tbpMessageBox.TabIndex = 2;
            this.tbpMessageBox.Text = "Message Box";
            // 
            // btnMessageBoxPreview
            // 
            this.btnMessageBoxPreview.Location = new System.Drawing.Point(700, 70);
            this.btnMessageBoxPreview.Name = "btnMessageBoxPreview";
            this.btnMessageBoxPreview.Size = new System.Drawing.Size(75, 23);
            this.btnMessageBoxPreview.TabIndex = 31;
            this.btnMessageBoxPreview.Text = "&Preview...";
            this.btnMessageBoxPreview.UseVisualStyleBackColor = true;
            this.btnMessageBoxPreview.Click += new System.EventHandler(this.btnMessageBoxPreview_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "&Title:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(3, 35);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 21;
            this.lblMessage.Text = "&Message:";
            // 
            // txtDialogVar
            // 
            this.txtDialogVar.Location = new System.Drawing.Point(678, 127);
            this.txtDialogVar.Name = "txtDialogVar";
            this.txtDialogVar.Size = new System.Drawing.Size(100, 20);
            this.txtDialogVar.TabIndex = 30;
            // 
            // lblVariable
            // 
            this.lblVariable.AutoSize = true;
            this.lblVariable.Location = new System.Drawing.Point(568, 130);
            this.lblVariable.Name = "lblVariable";
            this.lblVariable.Size = new System.Drawing.Size(111, 13);
            this.lblVariable.TabIndex = 29;
            this.lblVariable.Text = "&DialogResult Variable:";
            // 
            // bntMessageBoxGenerate
            // 
            this.bntMessageBoxGenerate.Location = new System.Drawing.Point(700, 99);
            this.bntMessageBoxGenerate.Name = "bntMessageBoxGenerate";
            this.bntMessageBoxGenerate.Size = new System.Drawing.Size(75, 23);
            this.bntMessageBoxGenerate.TabIndex = 32;
            this.bntMessageBoxGenerate.Text = "&Generate";
            this.bntMessageBoxGenerate.UseVisualStyleBackColor = true;
            this.bntMessageBoxGenerate.Click += new System.EventHandler(this.bntMessageBoxGenerate_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(62, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(628, 20);
            this.txtTitle.TabIndex = 20;
            // 
            // txtMessageBoxMessage
            // 
            this.txtMessageBoxMessage.Location = new System.Drawing.Point(62, 32);
            this.txtMessageBoxMessage.Multiline = true;
            this.txtMessageBoxMessage.Name = "txtMessageBoxMessage";
            this.txtMessageBoxMessage.Size = new System.Drawing.Size(628, 86);
            this.txtMessageBoxMessage.TabIndex = 22;
            // 
            // lblDefaultButton
            // 
            this.lblDefaultButton.AutoSize = true;
            this.lblDefaultButton.Location = new System.Drawing.Point(193, 130);
            this.lblDefaultButton.Name = "lblDefaultButton";
            this.lblDefaultButton.Size = new System.Drawing.Size(78, 13);
            this.lblDefaultButton.TabIndex = 25;
            this.lblDefaultButton.Text = "&Default Button:";
            // 
            // cmbDefaultButton
            // 
            this.cmbDefaultButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefaultButton.FormattingEnabled = true;
            this.cmbDefaultButton.Items.AddRange(new object[] {
            "Button1",
            "Button2",
            "Button3"});
            this.cmbDefaultButton.Location = new System.Drawing.Point(277, 127);
            this.cmbDefaultButton.Name = "cmbDefaultButton";
            this.cmbDefaultButton.Size = new System.Drawing.Size(121, 21);
            this.cmbDefaultButton.TabIndex = 26;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(404, 130);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(31, 13);
            this.lblIcon.TabIndex = 27;
            this.lblIcon.Text = "&Icon:";
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Location = new System.Drawing.Point(19, 130);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(43, 13);
            this.lblButton.TabIndex = 23;
            this.lblButton.Text = "&Buttons";
            // 
            // cmbIcon
            // 
            this.cmbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIcon.FormattingEnabled = true;
            this.cmbIcon.Items.AddRange(new object[] {
            "Asterisk",
            "Error",
            "Exclamation",
            "Hand",
            "Information",
            "None",
            "Question",
            "Stop",
            "Warning"});
            this.cmbIcon.Location = new System.Drawing.Point(441, 127);
            this.cmbIcon.Name = "cmbIcon";
            this.cmbIcon.Size = new System.Drawing.Size(121, 21);
            this.cmbIcon.Sorted = true;
            this.cmbIcon.TabIndex = 28;
            // 
            // txtMessageBoxCode
            // 
            this.txtMessageBoxCode.Location = new System.Drawing.Point(6, 177);
            this.txtMessageBoxCode.MaxLength = 0;
            this.txtMessageBoxCode.Multiline = true;
            this.txtMessageBoxCode.Name = "txtMessageBoxCode";
            this.txtMessageBoxCode.Size = new System.Drawing.Size(816, 274);
            this.txtMessageBoxCode.TabIndex = 33;
            // 
            // cmbButtons
            // 
            this.cmbButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbButtons.FormattingEnabled = true;
            this.cmbButtons.Items.AddRange(new object[] {
            "AboutRetryIgnore",
            "OK",
            "OKCancel",
            "RetryCancel",
            "YesNo",
            "YesNoCancel"});
            this.cmbButtons.Location = new System.Drawing.Point(66, 127);
            this.cmbButtons.Name = "cmbButtons";
            this.cmbButtons.Size = new System.Drawing.Size(121, 21);
            this.cmbButtons.TabIndex = 24;
            // 
            // tbpSwitch
            // 
            this.tbpSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.tbpSwitch.Controls.Add(this.grbSwitchOptions);
            this.tbpSwitch.Controls.Add(this.lblVarName);
            this.tbpSwitch.Controls.Add(this.txtSwitchVar);
            this.tbpSwitch.Controls.Add(this.bntSwitchGenerate);
            this.tbpSwitch.Controls.Add(this.lblCaseAmount);
            this.tbpSwitch.Controls.Add(this.txtCaseNumber);
            this.tbpSwitch.Controls.Add(this.lblVariableType);
            this.tbpSwitch.Controls.Add(this.cmbSwitchType);
            this.tbpSwitch.Controls.Add(this.txtSwitchCode);
            this.tbpSwitch.Location = new System.Drawing.Point(4, 22);
            this.tbpSwitch.Name = "tbpSwitch";
            this.tbpSwitch.Size = new System.Drawing.Size(829, 457);
            this.tbpSwitch.TabIndex = 3;
            this.tbpSwitch.Text = "Switch";
            // 
            // grbSwitchOptions
            // 
            this.grbSwitchOptions.Controls.Add(this.chkDefault);
            this.grbSwitchOptions.Controls.Add(this.chkSkip);
            this.grbSwitchOptions.Controls.Add(this.chkCaseSensitive);
            this.grbSwitchOptions.Controls.Add(this.chkPatternCase);
            this.grbSwitchOptions.Location = new System.Drawing.Point(216, 10);
            this.grbSwitchOptions.Name = "grbSwitchOptions";
            this.grbSwitchOptions.Size = new System.Drawing.Size(217, 63);
            this.grbSwitchOptions.TabIndex = 40;
            this.grbSwitchOptions.TabStop = false;
            this.grbSwitchOptions.Text = "&Options";
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Location = new System.Drawing.Point(6, 19);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(87, 17);
            this.chkDefault.TabIndex = 41;
            this.chkDefault.Text = "&Default Case";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // chkSkip
            // 
            this.chkSkip.AutoSize = true;
            this.chkSkip.Enabled = false;
            this.chkSkip.Location = new System.Drawing.Point(117, 42);
            this.chkSkip.Name = "chkSkip";
            this.chkSkip.Size = new System.Drawing.Size(92, 17);
            this.chkSkip.TabIndex = 44;
            this.chkSkip.Text = "&Skip Numbers";
            this.chkSkip.UseVisualStyleBackColor = true;
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(117, 19);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(96, 17);
            this.chkCaseSensitive.TabIndex = 42;
            this.chkCaseSensitive.Text = "&Case Sensitive";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // chkPatternCase
            // 
            this.chkPatternCase.AutoSize = true;
            this.chkPatternCase.Location = new System.Drawing.Point(6, 42);
            this.chkPatternCase.Name = "chkPatternCase";
            this.chkPatternCase.Size = new System.Drawing.Size(105, 17);
            this.chkPatternCase.TabIndex = 43;
            this.chkPatternCase.Text = "&Numerated Case";
            this.chkPatternCase.UseVisualStyleBackColor = true;
            this.chkPatternCase.CheckedChanged += new System.EventHandler(this.chkPatternCase_CheckedChanged);
            // 
            // lblVarName
            // 
            this.lblVarName.AutoSize = true;
            this.lblVarName.Location = new System.Drawing.Point(4, 40);
            this.lblVarName.Name = "lblVarName";
            this.lblVarName.Size = new System.Drawing.Size(79, 13);
            this.lblVarName.TabIndex = 36;
            this.lblVarName.Text = "&Variable Name:";
            // 
            // txtSwitchVar
            // 
            this.txtSwitchVar.Location = new System.Drawing.Point(89, 37);
            this.txtSwitchVar.Name = "txtSwitchVar";
            this.txtSwitchVar.Size = new System.Drawing.Size(121, 20);
            this.txtSwitchVar.TabIndex = 37;
            // 
            // bntSwitchGenerate
            // 
            this.bntSwitchGenerate.Location = new System.Drawing.Point(358, 75);
            this.bntSwitchGenerate.Name = "bntSwitchGenerate";
            this.bntSwitchGenerate.Size = new System.Drawing.Size(75, 23);
            this.bntSwitchGenerate.TabIndex = 45;
            this.bntSwitchGenerate.Text = "&Generate";
            this.bntSwitchGenerate.UseVisualStyleBackColor = true;
            this.bntSwitchGenerate.Click += new System.EventHandler(this.bntSwitchGenerate_Click);
            // 
            // lblCaseAmount
            // 
            this.lblCaseAmount.AutoSize = true;
            this.lblCaseAmount.Location = new System.Drawing.Point(10, 66);
            this.lblCaseAmount.Name = "lblCaseAmount";
            this.lblCaseAmount.Size = new System.Drawing.Size(73, 13);
            this.lblCaseAmount.TabIndex = 38;
            this.lblCaseAmount.Text = "&Case Amount:";
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.Location = new System.Drawing.Point(89, 63);
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.Size = new System.Drawing.Size(121, 20);
            this.txtCaseNumber.TabIndex = 39;
            // 
            // lblVariableType
            // 
            this.lblVariableType.AutoSize = true;
            this.lblVariableType.Location = new System.Drawing.Point(8, 13);
            this.lblVariableType.Name = "lblVariableType";
            this.lblVariableType.Size = new System.Drawing.Size(75, 13);
            this.lblVariableType.TabIndex = 34;
            this.lblVariableType.Text = "&Variable Type:";
            // 
            // cmbSwitchType
            // 
            this.cmbSwitchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSwitchType.FormattingEnabled = true;
            this.cmbSwitchType.Items.AddRange(new object[] {
            "String",
            "Integer",
            "Bool",
            "Char",
            "Decimal",
            "Double"});
            this.cmbSwitchType.Location = new System.Drawing.Point(89, 10);
            this.cmbSwitchType.Name = "cmbSwitchType";
            this.cmbSwitchType.Size = new System.Drawing.Size(121, 21);
            this.cmbSwitchType.TabIndex = 35;
            this.cmbSwitchType.SelectedIndexChanged += new System.EventHandler(this.cmbSwitchType_SelectedIndexChanged);
            // 
            // txtSwitchCode
            // 
            this.txtSwitchCode.Location = new System.Drawing.Point(6, 177);
            this.txtSwitchCode.Multiline = true;
            this.txtSwitchCode.Name = "txtSwitchCode";
            this.txtSwitchCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSwitchCode.Size = new System.Drawing.Size(816, 274);
            this.txtSwitchCode.TabIndex = 46;
            // 
            // tbpComment
            // 
            this.tbpComment.BackColor = System.Drawing.SystemColors.Control;
            this.tbpComment.Controls.Add(this.txtCommentCode);
            this.tbpComment.Controls.Add(this.grbTitleComment);
            this.tbpComment.Location = new System.Drawing.Point(4, 22);
            this.tbpComment.Name = "tbpComment";
            this.tbpComment.Size = new System.Drawing.Size(829, 457);
            this.tbpComment.TabIndex = 4;
            this.tbpComment.Text = "Comment";
            // 
            // txtCommentCode
            // 
            this.txtCommentCode.Location = new System.Drawing.Point(6, 177);
            this.txtCommentCode.Multiline = true;
            this.txtCommentCode.Name = "txtCommentCode";
            this.txtCommentCode.Size = new System.Drawing.Size(816, 274);
            this.txtCommentCode.TabIndex = 7;
            // 
            // grbTitleComment
            // 
            this.grbTitleComment.Controls.Add(this.bntTopLineComment);
            this.grbTitleComment.Controls.Add(this.txtProjectName);
            this.grbTitleComment.Controls.Add(this.txtCompany);
            this.grbTitleComment.Controls.Add(this.txtName);
            this.grbTitleComment.Controls.Add(this.lblCompany);
            this.grbTitleComment.Controls.Add(this.lblProjectName);
            this.grbTitleComment.Controls.Add(this.label1);
            this.grbTitleComment.Location = new System.Drawing.Point(3, 3);
            this.grbTitleComment.Name = "grbTitleComment";
            this.grbTitleComment.Size = new System.Drawing.Size(200, 125);
            this.grbTitleComment.TabIndex = 47;
            this.grbTitleComment.TabStop = false;
            this.grbTitleComment.Text = "&Title Comment";
            // 
            // bntTopLineComment
            // 
            this.bntTopLineComment.Location = new System.Drawing.Point(114, 97);
            this.bntTopLineComment.Name = "bntTopLineComment";
            this.bntTopLineComment.Size = new System.Drawing.Size(75, 23);
            this.bntTopLineComment.TabIndex = 54;
            this.bntTopLineComment.Text = "&Generate";
            this.bntTopLineComment.UseVisualStyleBackColor = true;
            this.bntTopLineComment.Click += new System.EventHandler(this.bntTopLineComment_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(89, 19);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(100, 20);
            this.txtProjectName.TabIndex = 49;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(89, 71);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(100, 20);
            this.txtCompany.TabIndex = 53;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 51;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(29, 74);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(54, 13);
            this.lblCompany.TabIndex = 52;
            this.lblCompany.Text = "&Company:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(9, 22);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(74, 13);
            this.lblProjectName.TabIndex = 48;
            this.lblProjectName.Text = "&Project Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "&Creator Name:";
            // 
            // tbpApplication
            // 
            this.tbpApplication.BackColor = System.Drawing.SystemColors.Control;
            this.tbpApplication.Controls.Add(this.bntSave);
            this.tbpApplication.Controls.Add(this.bntHelp);
            this.tbpApplication.Controls.Add(this.txtFilePath);
            this.tbpApplication.Controls.Add(this.bntSavePath);
            this.tbpApplication.Controls.Add(this.txtApplication);
            this.tbpApplication.Location = new System.Drawing.Point(4, 22);
            this.tbpApplication.Name = "tbpApplication";
            this.tbpApplication.Size = new System.Drawing.Size(829, 457);
            this.tbpApplication.TabIndex = 5;
            this.tbpApplication.Text = "Application";
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(522, 412);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(75, 23);
            this.bntSave.TabIndex = 4;
            this.bntSave.Text = "&Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // bntHelp
            // 
            this.bntHelp.Location = new System.Drawing.Point(441, 412);
            this.bntHelp.Name = "bntHelp";
            this.bntHelp.Size = new System.Drawing.Size(75, 23);
            this.bntHelp.TabIndex = 3;
            this.bntHelp.Text = "&Help";
            this.bntHelp.UseVisualStyleBackColor = true;
            this.bntHelp.Click += new System.EventHandler(this.bntHelp_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(3, 415);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(351, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // bntSavePath
            // 
            this.bntSavePath.Location = new System.Drawing.Point(360, 413);
            this.bntSavePath.Name = "bntSavePath";
            this.bntSavePath.Size = new System.Drawing.Size(75, 23);
            this.bntSavePath.TabIndex = 1;
            this.bntSavePath.Text = "&Browse...";
            this.bntSavePath.UseVisualStyleBackColor = true;
            this.bntSavePath.Click += new System.EventHandler(this.bntSavePath_Click);
            // 
            // txtApplication
            // 
            this.txtApplication.AcceptsTab = true;
            this.txtApplication.Location = new System.Drawing.Point(3, 3);
            this.txtApplication.Multiline = true;
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.Size = new System.Drawing.Size(767, 403);
            this.txtApplication.TabIndex = 0;
            // 
            // sfdSave
            // 
            this.sfdSave.Description = "Save Project To...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 537);
            this.ControlBox = false;
            this.Controls.Add(this.tbcCodeTabs);
            this.Controls.Add(this.bntExit);
            this.Name = "frmMain";
            this.Text = "Code Generation";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbcCodeTabs.ResumeLayout(false);
            this.tbpForm.ResumeLayout(false);
            this.tbpForm.PerformLayout();
            this.grbCallForm.ResumeLayout(false);
            this.grbCallForm.PerformLayout();
            this.tbpMenu.ResumeLayout(false);
            this.tbpMenu.PerformLayout();
            this.grbStringMenu.ResumeLayout(false);
            this.grbStringMenu.PerformLayout();
            this.grbCharMenu.ResumeLayout(false);
            this.grbCharMenu.PerformLayout();
            this.tbpMessageBox.ResumeLayout(false);
            this.tbpMessageBox.PerformLayout();
            this.tbpSwitch.ResumeLayout(false);
            this.tbpSwitch.PerformLayout();
            this.grbSwitchOptions.ResumeLayout(false);
            this.grbSwitchOptions.PerformLayout();
            this.tbpComment.ResumeLayout(false);
            this.tbpComment.PerformLayout();
            this.grbTitleComment.ResumeLayout(false);
            this.grbTitleComment.PerformLayout();
            this.tbpApplication.ResumeLayout(false);
            this.tbpApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.TabControl tbcCodeTabs;
        private System.Windows.Forms.TabPage tbpForm;
        private System.Windows.Forms.TabPage tbpMenu;
        private System.Windows.Forms.TabPage tbpMessageBox;
        private System.Windows.Forms.TabPage tbpSwitch;
        private System.Windows.Forms.GroupBox grbCallForm;
        private System.Windows.Forms.CheckBox chkShowDialog;
        private System.Windows.Forms.Button bntShowFormCode;
        private System.Windows.Forms.TextBox txtCallFormVariable;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.Label lblCallFormName;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.TextBox txtFormCode;
        private System.Windows.Forms.ComboBox cmbIcon;
        private System.Windows.Forms.TextBox txtMessageBoxCode;
        private System.Windows.Forms.ComboBox cmbButtons;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.Label lblDefaultButton;
        private System.Windows.Forms.ComboBox cmbDefaultButton;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMessageBoxMessage;
        private System.Windows.Forms.TextBox txtMenuCode;
        private System.Windows.Forms.GroupBox grbStringMenu;
        private System.Windows.Forms.Button bntStringMenuGenerate;
        private System.Windows.Forms.Label lblStringMenuNumber;
        private System.Windows.Forms.TextBox txtStringMenuNumber;
        private System.Windows.Forms.GroupBox grbCharMenu;
        private System.Windows.Forms.Button bntCharMenuGenerate;
        private System.Windows.Forms.Label lblCharMenuNumber;
        private System.Windows.Forms.TextBox txtCharMenuNumber;
        private System.Windows.Forms.CheckBox chkStringMenuMethod;
        private System.Windows.Forms.CheckBox chkCharMenuMethod;
        private System.Windows.Forms.ComboBox cmbSwitchType;
        private System.Windows.Forms.TextBox txtSwitchCode;
        private System.Windows.Forms.CheckBox chkPatternCase;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Label lblCaseAmount;
        private System.Windows.Forms.TextBox txtCaseNumber;
        private System.Windows.Forms.Label lblVariableType;
        private System.Windows.Forms.Button bntSwitchGenerate;
        private System.Windows.Forms.TextBox txtSwitchVar;
        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private System.Windows.Forms.Label lblVarName;
        private System.Windows.Forms.CheckBox chkSkip;
        private System.Windows.Forms.GroupBox grbSwitchOptions;
        private System.Windows.Forms.Button bntMessageBoxGenerate;
        private System.Windows.Forms.TextBox txtDialogVar;
        private System.Windows.Forms.Label lblVariable;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnMessageBoxPreview;
        private System.Windows.Forms.TabPage tbpComment;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button bntTopLineComment;
        private System.Windows.Forms.TextBox txtCommentCode;
        private System.Windows.Forms.GroupBox grbTitleComment;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFormAccept;
        private System.Windows.Forms.Label lblAcceptButton;
        private System.Windows.Forms.TextBox txtFormCancel;
        private System.Windows.Forms.Label lblCancelButton;
        private System.Windows.Forms.TabPage tbpApplication;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button bntHelp;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button bntSavePath;
        private System.Windows.Forms.TextBox txtApplication;
        private System.Windows.Forms.FolderBrowserDialog sfdSave;
        private System.Windows.Forms.ToolTip ttTool;
    }
}

