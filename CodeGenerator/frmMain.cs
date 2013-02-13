///CodeGenerator
///Created by Jacob Douglas
///Created on 11/17/2011
///(c) Copyright 2011, Drop 3 Productions

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();//close form
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            cmbIcon.SelectedItem = "None";//set default
            cmbButtons.SelectedItem = "OK";//set default
            cmbSwitchType.SelectedItem = "Char";//set default
            cmbDefaultButton.SelectedItem = "Button1";//set default
            #region ToolTips
            ttTool.SetToolTip(this.txtFormName, "Name of the form object.");
            ttTool.SetToolTip(this.txtCallFormVariable, "Name of the variable to call the form.");
            ttTool.SetToolTip(this.txtFormCancel, "The cancel button for the form (optional).");
            ttTool.SetToolTip(this.txtFormAccept, "The accept button for the form (optional).");
            ttTool.SetToolTip(this.chkShowDialog, "If the form should be shown using ShowDialog().");
            ttTool.SetToolTip(this.txtCharMenuNumber, "Number of options the menu will show.");
            ttTool.SetToolTip(this.chkCharMenuMethod, "If a method should be generated to create code to check if input is valid.");
            ttTool.SetToolTip(this.txtStringMenuNumber, "Number of options the menu will show.");
            ttTool.SetToolTip(this.chkStringMenuMethod, "If a method should be generated to create code to check if input is valid.");
            ttTool.SetToolTip(this.txtTitle, "The title of the message box.");
            ttTool.SetToolTip(this.txtMessageBoxMessage, "What the message box will tell the user when shown.");
            ttTool.SetToolTip(this.btnMessageBoxPreview, "Preview what the message box will look like.");
            ttTool.SetToolTip(this.cmbButtons, "What buttons should be on the messagebox.");
            ttTool.SetToolTip(this.cmbDefaultButton, "What button is the default. When shown, hitting enter will trigger this button.");
            ttTool.SetToolTip(this.cmbIcon, "What icon is on the message box.");
            ttTool.SetToolTip(this.txtDialogVar, "What variable will be used to get the result from the message box.");
            ttTool.SetToolTip(this.cmbSwitchType, "The variable type the switch will contain.");
            ttTool.SetToolTip(this.txtSwitchVar, "The variable that will be switched.");
            ttTool.SetToolTip(this.txtCaseNumber, "The amount of cases that will be in the switch.");
            ttTool.SetToolTip(this.chkDefault, "If there should be a default case.");
            ttTool.SetToolTip(this.chkPatternCase, "If the cases should go from 1 letter or number to another. Ex. 1-10 or A-Z");
            ttTool.SetToolTip(this.chkSkip, "If the cases should skip every so often. Ex. 1-10 every even number. A-Z every other letter");
            ttTool.SetToolTip(this.chkCaseSensitive, "If the letters typed should be depended if lower case or upper case.");
            ttTool.SetToolTip(this.txtProjectName, "The name of the application.");
            ttTool.SetToolTip(this.txtName, "The person that made the application.");
            ttTool.SetToolTip(this.txtCompany, "The company the application was made by.");
            ttTool.SetToolTip(this.txtApplication, "Form layout for creating and linking forms together. Click \"Help\" for more information.");
            #endregion
        }

        private void bntShowFormCode_Click(object sender, EventArgs e)
        {
            clsCode.bShowDialog = chkShowDialog.Checked;//set if show dialog
            if (txtCallFormVariable.Text.Trim().Length > 0)
            {
                clsCode.sCallFormName = txtCallFormVariable.Text;//set call form variable
            }//if (txtCallFormVariable.Text.Trim().Length > 0)
            else
            {
                clsCode.sCallFormName = "frmCall";//default call name
            }//else
            if (txtFormName.Text.Trim().Length > 0)
            {
                if (txtFormName.Text != txtCallFormVariable.Text)
                {
                    clsCode.sFormName = txtFormName.Text;//set form name
                }//if (txtFormName.Text != txtCallFormVariable.Text)
                else
                {
                    MessageBox.Show("Form name must be different than Call Form Variable!","Error");//show error
                    txtFormName.Clear();//clear text
                    txtFormName.Focus();//focus box
                    return;//stop code
                }//else
            }//if (txtFormName.Text.Trim().Length > 0)
            else
            {
                MessageBox.Show("You must have a form name!","Error");//show error
                txtFormName.Clear();//clear text
                txtFormName.Focus();//focus box
                return;//stop code
            }//else
            clsCode.GenerateShowForm(txtFormCode,txtFormAccept,txtFormCancel);//generate code
        }

        private void bntCharMenuGenerate_Click(object sender, EventArgs e)
        {
            clsCode.bUseMethods = chkCharMenuMethod.Checked;//set if user wants to use methods
            clsCode.GenerateCharMenu(this.txtMenuCode, this.txtCharMenuNumber);//generate code
        }

        private void bntStringMenuGenerate_Click(object sender, EventArgs e)
        {
            clsCode.bUseMethods = chkStringMenuMethod.Checked;//set if user wants to use methods
            clsCode.GenerateStringMenu(this.txtMenuCode, this.txtStringMenuNumber);//generate cdoe
        }

        private void chkPatternCase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPatternCase.Checked)
            {
                txtCaseNumber.Enabled = false;//no number of cases needed if it is numerated

                if (cmbSwitchType.SelectedItem.ToString() == "Integer")
                {
                    chkSkip.Enabled = true;//they can skip steps
                }//if (cmbSwitchType.SelectedItem.ToString() == "Integer")

            }//if (chkPatternCase.Checked)
            else
            {
                txtCaseNumber.Enabled = true;//enabled because not numberated
                chkSkip.Enabled = false;//they can't skip steps
                if (cmbSwitchType.SelectedItem.ToString() == "Char")
                {
                    chkCaseSensitive.Enabled = true;
                }//if (cmbSwitchType.SelectedItem.ToString() == "Char")
            }//else
        }

        private void bntSwitchGenerate_Click(object sender, EventArgs e)
        {
            clsCode.bDefaultCase = chkDefault.Checked;//set var
            clsCode.bNumerated = chkPatternCase.Checked;//set var
            clsCode.bCaseSensitive = chkCaseSensitive.Checked;//set var
            clsCode.bSkip = chkSkip.Checked;//set var
            switch (cmbSwitchType.SelectedItem.ToString())
            {
                case "Char":
                    clsCode.GenerateCharSwitch(this.txtSwitchCode, this.txtCaseNumber, txtSwitchVar);//generate code
                    break;//case Char
                case "Integer":
                    clsCode.GenerateIntSwitch(this.txtSwitchCode, this.txtCaseNumber, txtSwitchVar);//generate code
                    break;//case Int/Long
                case "String":
                    clsCode.GenerateStringSwitch(this.txtSwitchCode, this.txtCaseNumber, this.txtSwitchVar);//generate code
                    break;//string
                case "Bool":
                    clsCode.GenerateBoolSwitch(this.txtSwitchCode, txtSwitchVar);//generate code
                    break;//bool
                case "Decimal":
                    clsCode.GenerateDecimalSwitch(this.txtSwitchCode, this.txtCaseNumber, this.txtSwitchVar);//generate code
                    break;//decimal
                case "Double":
                    clsCode.GenerateDoubleSwitch(this.txtSwitchCode, this.txtCaseNumber, this.txtSwitchVar);//generate code
                    break;//double
            }//switch
        }

        private void cmbSwitchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSwitchType.SelectedItem.ToString())
            {
                case "Char":
                    chkCaseSensitive.Enabled = true;//chars can be case sensitive
                    chkPatternCase.Enabled = true;//can be numerated
                    chkSkip.Enabled = false;//can't be skipped
                    break;//case Char
                case "Integer":
                    chkCaseSensitive.Enabled = false;//ints can't be case sensitive
                    chkPatternCase.Enabled = true;//can be numerated
                    chkSkip.Enabled = true;//can be skipped
                    break;//case Int/Long
                case "String":
                    chkCaseSensitive.Enabled = true;//strings can be case sensitive
                    chkPatternCase.Enabled = true;//can be numerated
                    chkSkip.Enabled = false;//can't be skipped
                    break;//case String
                case "Bool":
                    chkCaseSensitive.Enabled = false;//bools can't be case sensitive
                    chkPatternCase.Enabled = false;//can't be numerated
                    chkSkip.Enabled = false;//can't be skipped
                    break;//case Bool
                case "Decimal":
                    chkCaseSensitive.Enabled = false;//can't be case sensitive
                    chkPatternCase.Enabled = true;//can be numerated
                    chkSkip.Enabled = true;//can skip
                    break;//case Decimal
                case "Double":
                    chkCaseSensitive.Enabled = false;//can't be case sensitive
                    chkPatternCase.Enabled = true;//can be numerated
                    chkSkip.Enabled = true;//can skip
                    break;//case Double
            }//switch
        }

        private void tbcCodeTabs_OnTabIndexChanged(object sender, EventArgs e)
        {
            if (tbcCodeTabs.SelectedTab.Text == "Switch")
            {
                this.AcceptButton = this.bntSwitchGenerate;
            }//if (tbcCodeTabs.SelectedTab.Text == "Switch")
            else if (tbcCodeTabs.SelectedTab.Text == "Message Box")
            {
                this.AcceptButton = this.bntMessageBoxGenerate;
            }//else if (tbcCodeTabs.SelectedTab.Text == "Message Box")
            else if (tbcCodeTabs.SelectedTab.Text == "Menus")
            {
                this.AcceptButton = this.bntCharMenuGenerate;
            }//else if (tbcCodeTabs.SelectedTab.Text == "Menus")
            else if (tbcCodeTabs.SelectedTab.Text == "Form")
            {
                this.AcceptButton = this.bntShowFormCode;
            }//else if (tbcCodeTabs.SelectedTab.Text == "Forms")
        }

        private void bntMessageBoxGenerate_Click(object sender, EventArgs e)
        {
            switch (cmbButtons.SelectedItem.ToString())
            {
                case "AboutRetryIgnore":
                    clsCode.mbButton = MessageBoxButtons.AbortRetryIgnore;//Set Button
                    break;//"AcoutRetryIgnore"
                case "OK":
                    clsCode.mbButton = MessageBoxButtons.OK;//Set Button
                    break;//"OK"
                case "OKCancel":
                    clsCode.mbButton = MessageBoxButtons.OKCancel;//Set Button
                    break;//"OKCancel"
                case "RetryCancel":
                    clsCode.mbButton = MessageBoxButtons.RetryCancel;//Set Button
                    break;//"RetryCancel"
                case "YesNo":
                    clsCode.mbButton = MessageBoxButtons.YesNo;//Set Button
                    break;//YesNo"
                case "YesNoCancel":
                    clsCode.mbButton = MessageBoxButtons.YesNoCancel;//Set Button
                    break;//"YesNoCancel"
                default:
                    clsCode.mbButton = MessageBoxButtons.OK;//default
                    break;//default
            }//switch cmbButtons.SelectedText
            switch (cmbDefaultButton.SelectedItem.ToString())
            {
                case "Button1":
                    clsCode.mbDefaultButton = MessageBoxDefaultButton.Button1;//set button
                    break;//case button1
                case "Button2":
                    clsCode.mbDefaultButton = MessageBoxDefaultButton.Button2;//set button
                    break;//case button2
                case "Button3":
                    clsCode.mbDefaultButton = MessageBoxDefaultButton.Button3;//set button
                    break;//case button3
                default:
                    clsCode.mbDefaultButton = MessageBoxDefaultButton.Button1;//default
                    break;//default
            }//switch (cmbDefaultButton.SelectedText)
            switch (cmbIcon.SelectedItem.ToString())
            {
                case "Asterisk":
                    clsCode.mbIcon = MessageBoxIcon.Asterisk;//set icon
                    break;//case "Asterisk"
                case "Error":
                    clsCode.mbIcon = MessageBoxIcon.Error;//set icon
                    break;//case error
                case "Exclamation":
                    clsCode.mbIcon = MessageBoxIcon.Exclamation;//set icon
                    break;//case exclamation
                case "Hand":
                    clsCode.mbIcon = MessageBoxIcon.Hand;//set icon
                    break;//case hand
                case "Information":
                    clsCode.mbIcon = MessageBoxIcon.Information;//set icon
                    break;//case information
                case "None":
                    clsCode.mbIcon = MessageBoxIcon.None;//set icon
                    break;//case none
                case "Question":
                    clsCode.mbIcon = MessageBoxIcon.Question;//set icon
                    break;//case question
                case "Stop":
                    clsCode.mbIcon = MessageBoxIcon.Stop;//set icon
                    break;//case stop
                case "Warning":
                    clsCode.mbIcon = MessageBoxIcon.Warning;//set icon
                    break;//case warning
                default:
                    clsCode.mbIcon = MessageBoxIcon.None;//set icon
                    break;//default
            }//switch cmbIcon.SelectedText
            clsCode.GenerateMessageBox(this.txtMessageBoxCode, this.txtDialogVar, this.txtTitle, this.txtMessageBoxMessage);//generate code
        }

        private void btnMessageBoxPreview_Click(object sender, EventArgs e)
        {
            switch (cmbButtons.SelectedItem.ToString())
            {
                case "AboutRetryIgnore":
                    clsCode.mbButton = MessageBoxButtons.AbortRetryIgnore;//Set Button
                    break;//"AcoutRetryIgnore"
                case "OK":
                    clsCode.mbButton = MessageBoxButtons.OK;//Set Button
                    break;//"OK"
                case "OKCancel":
                    clsCode.mbButton = MessageBoxButtons.OKCancel;//Set Button
                    break;//"OKCancel"
                case "RetryCancel":
                    clsCode.mbButton = MessageBoxButtons.RetryCancel;//Set Button
                    break;//"RetryCancel"
                case "YesNo":
                    clsCode.mbButton = MessageBoxButtons.YesNo;//Set Button
                    break;//YesNo"
                case "YesNoCancel":
                    clsCode.mbButton = MessageBoxButtons.YesNoCancel;//Set Button
                    break;//"YesNoCancel"
                default:
                    clsCode.mbButton = MessageBoxButtons.OK;//default
                    break;//default
            }//switch cmbButtons.SelectedText
            switch (cmbDefaultButton.SelectedItem.ToString())
            {
                case "Button1":
                    clsCode.mbDefaultButton = MessageBoxDefaultButton.Button1;//set button
                    break;//case button1
                case "Button2":
                    clsCode.mbDefaultButton = MessageBoxDefaultButton.Button2;//set button
                    break;//case button2
                case "Button3":
                    clsCode.mbDefaultButton = MessageBoxDefaultButton.Button3;//set button
                    break;//case button3
                default:
                    clsCode.mbDefaultButton = MessageBoxDefaultButton.Button1;//default
                    break;//default
            }//switch (cmbDefaultButton.SelectedText)
            switch (cmbIcon.SelectedItem.ToString())
            {
                case "Asterisk":
                    clsCode.mbIcon = MessageBoxIcon.Asterisk;//set icon
                    break;//case "Asterisk"
                case "Error":
                    clsCode.mbIcon = MessageBoxIcon.Error;//set icon
                    break;//case error
                case "Exclamation":
                    clsCode.mbIcon = MessageBoxIcon.Exclamation;//set icon
                    break;//case exclamation
                case "Hand":
                    clsCode.mbIcon = MessageBoxIcon.Hand;//set icon
                    break;//case hand
                case "Information":
                    clsCode.mbIcon = MessageBoxIcon.Information;//set icon
                    break;//case information
                case "None":
                    clsCode.mbIcon = MessageBoxIcon.None;//set icon
                    break;//case none
                case "Question":
                    clsCode.mbIcon = MessageBoxIcon.Question;//set icon
                    break;//case question
                case "Stop":
                    clsCode.mbIcon = MessageBoxIcon.Stop;//set icon
                    break;//case stop
                case "Warning":
                    clsCode.mbIcon = MessageBoxIcon.Warning;//set icon
                    break;//case warning
                default:
                    clsCode.mbIcon = MessageBoxIcon.None;//set icon
                    break;//default
            }//switch cmbIcon.SelectedText
            clsCode.ShowSampleMessageBox(this.txtMessageBoxCode, this.txtDialogVar, this.txtTitle, this.txtMessageBoxMessage);//Show Sample
        }

        private void bntTopLineComment_Click(object sender, EventArgs e)
        {
            clsCode.GenerateTopComment(this.txtCommentCode, this.txtCompany, this.txtName, this.txtProjectName);//generate code
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            clsCode.GenerateApplication(this.txtApplication, this.txtFilePath);//generate the application
        }

        private void bntSavePath_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = sfdSave.SelectedPath;//set file path
            }//if (sfdSave.ShowDialog() == DialogResult.OK)
        }

        private void bntHelp_Click(object sender, EventArgs e)
        {
            frmCodeHelp frmCall = new frmCodeHelp();//new form variable
            frmCall.ShowDialog();//show form
        }
    }//class
}//namespace
