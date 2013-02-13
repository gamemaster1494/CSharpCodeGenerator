///clsCode
///Created by Jacob Douglas
///Created on 11/4/2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace CodeGenerator
{

    public static class clsCode
    {
        #region Form Variables
        public static string sFormName;//form name for form code
        public static string sCallFormName;//variable for form call code
        public static bool bShowDialog;//if form should show dialog or not
        public static string sAcceptButton;//accept button on the form
        public static string sCancelButton;//cancel button on the form
        #endregion
        #region MessageBox Variables
        public static string sMessage;//message for message box
        public static string sTitle;//title for messagebox
        public static string sDialogVar;//variable for dialogresult variable
        public static MessageBoxButtons mbButton = MessageBoxButtons.OK;//messageboxbutton 
        public static MessageBoxIcon mbIcon;//icon
        public static MessageBoxDefaultButton mbDefaultButton;//default button
        #endregion
        #region CharMenu Variables
        public static int iMenuAmount;
        public static string[] sNames;
        public static char[] cChars;
        public static string sChoiceString;
        public static bool bUseMethods;
        public static string sMethodName;
        #endregion
        #region Switch Variables
        public static bool bDefaultCase;//if there is a default case
        public static decimal[] deCases;//decimal cases
        public static bool bNumerated;//numerated (pattern like 1-10 does 1,2,3,4,5,6,7,8,9,10)
        public static int iAmount;//amount of cases
        public static bool bCanceled;//canceled on int switches
        public static double[] dCases;//double cases
        public static bool bCaseSensitive;//case sensitive
        public static bool bSkip;//if they are skipping numbers
        public static char[] cCases;//char cases
        public static int[] iCases;//int cases
        public static string[] sCases;//string cases
        public static string sSwitchVar;//variable that will be switched
        public static char[] cAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };//alphabent for numeric things =)
        public static int iSkip;//number they skip
        #endregion
        #region Comment Variables
        public static string sUserName;
        public static string sCompanyName;
        public static string sProjectName;
        #endregion
        /// Method: GenerateShowForm()
        /// Params: TextBox txtCode
        /// Returns: none
        /// Purpose: used to generate the code and show the code to show a form.
        public static void GenerateShowForm(TextBox txtCode, TextBox txtAccept, TextBox txtCancel)
        {
            string sLine = "";//stores code
            sLine = "" + sFormName + " " + sCallFormName + " = new " + sFormName + "();//form variable" + Environment.NewLine;//set new variable for form
            sAcceptButton = txtAccept.Text;//set text
            sCancelButton = txtCancel.Text;//set text
            if (sAcceptButton.Length >= 1)
            {
                sLine += "" + sCallFormName + ".AcceptButton = " + sCallFormName + "." + sAcceptButton + ";//set accept button" + Environment.NewLine;//generate line for accept button
            }//if (sAcceptButton.Length > 1)
            if (sCancelButton.Length >= 1)
            {
                sLine += "" + sCallFormName + ".CancelButton = " + sCallFormName + "." + sCancelButton + ";//set cancel button" + Environment.NewLine;//generate line for accept button
            }//if (sCancelButton.Length >= 1)
            if (bShowDialog)
            {
                sLine += sCallFormName + ".ShowDialog();//Show the form";//show the form variable
                txtCode.Text = sLine;//how generated code
            }//if (bShowDialog)
            else
            {
                sLine += sCallFormName + ".Show();//Show the form";//show the form
                txtCode.Text = sLine;//show generated codde
            }//else
            System.Windows.Forms.Clipboard.SetText(sLine);//set the clipboard text as generated code
        }//GenerateShowForm(TextBox txtCode)

        public static void GenerateTopComment(TextBox txtCode, TextBox txtCompanyNameIn, TextBox txtUserNameIn, TextBox txtProjectNameIn)
        {
            try
            {
                if (txtCompanyNameIn.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Invalid Company Name!", "Error");//show error
                    txtCompanyNameIn.Focus();//focus text box
                    return;//stop code
                }//if (txtCompanyNameIn.Text.Trim().Length < 1)
                if (txtProjectNameIn.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Invalid Project Name!", "Error");//show error
                    txtProjectNameIn.Focus();//focus text box
                    return;//stop code
                }//if (txtProjectNameIn.Text.Trim().Length < 1)
                if (txtUserNameIn.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Invalid Creator Name!", "Error");//show error
                    txtUserNameIn.Focus();//focus text box
                    return;//stop code
                }//if (txtUserNameIn.Text.Trim().Length < 1)

                string sLine = "";//storage variable]                                      
                sLine += "///" + txtProjectNameIn.Text + Environment.NewLine;//project line
                sLine += "///Created By: " + txtUserNameIn.Text + Environment.NewLine;//created by line
                sLine += "///Created On: " + System.DateTime.Today.Month + "/" + System.DateTime.Today.Day + "/" + System.DateTime.Today.Year + Environment.NewLine;//date line
                sLine += "///(c) Copyright " + System.DateTime.Today.Year.ToString() + ", " + txtCompanyNameIn.Text + Environment.NewLine;//date created
                txtCode.Text = sLine;//generate code
                System.Windows.Forms.Clipboard.SetText(sLine);//set clipboard text
            }//try
            catch (Exception ex)
            {

            }//catch
        }//GenerateTopComment()

        public static void GenerateCharMenu(TextBox txtCode, TextBox txtNumber)
        {
            if (ValidateCharMenuNumber(txtNumber.Text))
            {
                iMenuAmount = Convert.ToInt32(txtNumber.Text);
            }// if (ValidateCharMenuNumber(txtNumber.Text))
            else
            {
                MessageBox.Show("Invalid Menu Options! (Options must be a number)", "Error");//show error
                txtNumber.Clear();//clear text box
                txtNumber.Focus();//focus text
                return;//stop code                
            }//else
            string sLine = "";//code storage
            cChars = new char[iMenuAmount];//redefine array
            sNames = new string[iMenuAmount];//redefine array
            for (int i = 0; i < iMenuAmount; i++)
            {
                string sInput = "";//storage
                //char cInput = ' ';//storage
                sInput = GetMenuName(i);//get input
                if (sInput == null)
                {
                    return;//stop code because they canceled
                }//if sInput == null
                else
                {
                    sNames[i] = sInput;//set variable
                }//else
            }//for int i = 0; i < imenuamount - 1; i++
            if (bUseMethods)
            {
                if (InputBox("Method Name", "Method Name:", ref sMethodName) == DialogResult.OK)
                {

                }//if (InputBox("Method Name", "Method Name:", ref sMethodName) == DialogResult.OK)
                else
                {
                    return;//user clicked cancel
                }//else
            }//if busemethods
            if (InputBox("Asking String", "Text to ask user:", ref sChoiceString) == DialogResult.OK)
            {

            }//if (InputBox("Asking String", "Text to ask user:", ref sChoiceString) == DialogResult.OK)
            else
            {
                return;//they canceled
            }//else
            if (!bUseMethods)
            {
                foreach (string sName in sNames)
                {
                    sLine += "Console.WriteLine(\"" + sName + "\");////Show option" + Environment.NewLine;//add writeline
                }//foreach (string sName in sNames)
                sLine += "Console.Write(\"" + sChoiceString + "\");//Ask user for input";
            }//if !busemethods
            else
            {
                sLine += "public char " + sMethodName + "()" + Environment.NewLine;//method name
                sLine += "{" + Environment.NewLine;//method opencurlybrace
                sLine += "\ttry" + Environment.NewLine;//try
                sLine += "\t{" + Environment.NewLine;//try open curlybrace
                sLine += "\t\tchar cInput = ' ';//input the user gives" + Environment.NewLine;//input variable
                foreach (string sName in sNames)
                {
                    sLine += "\t\tConsole.WriteLine(\"" + sName + "\");//Show Option" + Environment.NewLine;//add writeline
                }//writelines
                sLine += "\t\tConsole.Write(\"" + sChoiceString + "\");//Ask user for input" + Environment.NewLine;//add write
                sLine += "\t\tcInput = Convert.ToChar(Console.ReadLine().ToUpper());//Get the input" + Environment.NewLine;//conver and get the variable                    
                sLine += "\t\treturn cInput;//Return user's choice" + Environment.NewLine;//return result
                sLine += "\t}//try" + Environment.NewLine;//try close curlybrace
                sLine += "\tcatch (Exception ex)" + Environment.NewLine;//catch exception ex
                sLine += "\t{" + Environment.NewLine;//catch open curly brace
                sLine += "\t\tConsole.Clear();//Clear the screen" + Environment.NewLine;//Console.Clear()
                sLine += "\t\tConsole.WriteLine(\"Invalid Choice\");//Show error" + Environment.NewLine;//console.writeline(invalidchoice)
                sLine += "\t\treturn " + sMethodName + "();//Loop until it is right" + Environment.NewLine;//return methodname()
                sLine += "\t}//catch" + Environment.NewLine;//catch end curly brace
                sLine += "}//" + sMethodName + "()";//method close curlybrace
            }//else
            txtCode.Text = sLine;//show code
            System.Windows.Forms.Clipboard.SetText(sLine);//copy code to clipboard
        }//GenerateCharMenu(TextBox txtCode, TextBox txtNumber,TextBox txtChoiceString)

        public static bool ValidateCharMenuNumber(string sText)
        {
            try
            {
                Convert.ToInt32(sText);//try conversion
                return true;//valid number because we didn't error out
            }//try
            catch (Exception ex)
            {
                return false;//not a valid number
            }//catch
        }//ValidateCharMenuNumber(string sText)

        public static bool ValidateStringMenuNumber(string sText)
        {
            try
            {
                Convert.ToInt32(sText);//try conversion
                return true;//valid number because we didn't error out
            }//try
            catch (Exception ex)
            {
                return false;//not a valid number
            }//catch
        }//ValidateCharMenuNumber(string sText)

        public static bool ValidateSwitchNumber(string sText)
        {
            try
            {
                if (bNumerated)
                {
                    return true;
                }
                Convert.ToInt32(sText);//try conversion
                return true;//valid number because we didn't error out
            }//try
            catch (Exception ex)
            {
                return false;//we errored out
            }//catch
        }//ValidateSwitchNumber()

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();//new form
            Label label = new Label();//new label
            TextBox textBox = new TextBox();//new textbox
            Button buttonOk = new Button();//new button
            Button buttonCancel = new Button();//new button

            form.Text = title;//set title
            label.Text = promptText;//set label text
            textBox.Text = value;//set textbox value

            buttonOk.Text = "&OK";//set button text
            buttonCancel.Text = "&Cancel";//set cancel text
            buttonOk.DialogResult = DialogResult.OK;//set value
            buttonCancel.DialogResult = DialogResult.Cancel;//set value

            label.SetBounds(9, 20, 372, 13);//set label size
            textBox.SetBounds(12, 36, 372, 20);//set text box size
            buttonOk.SetBounds(228, 72, 75, 23);//set okay size
            buttonCancel.SetBounds(309, 72, 75, 23);//set button size

            label.AutoSize = true;//set label property
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right; //set anchorstyle
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;//set anchorstyle
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;//set anchorstyle

            form.ClientSize = new Size(396, 107);//set size
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });//add range
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);//set client size
            form.FormBorderStyle = FormBorderStyle.FixedDialog;//set formborderstyle
            form.StartPosition = FormStartPosition.CenterScreen;//set start position
            form.MinimizeBox = false;//no minimize
            form.MaximizeBox = false;//no maximize
            form.AcceptButton = buttonOk;//add accept button
            form.CancelButton = buttonCancel;//add cancel button

            DialogResult dialogResult = form.ShowDialog();//show input box
            value = textBox.Text;//get value
            return dialogResult;//return value
        }//InputBox()

        public static char GetMenuTrigger(int iNumber)
        {
            try
            {
                string sInput = "";//storage
                if (InputBox("User Input", "User Input for \"" + sNames[iNumber] + "\":", ref sInput) == DialogResult.OK)
                {
                    if (sInput.Trim().Length == 1 && sInput.Trim() != null && sInput.Trim() != "\\")
                    {
                        for (int i = 0; i <= iNumber - 1; i++)
                        {
                            if (Convert.ToChar(sInput.ToUpper()) == cChars[i])
                            {
                                MessageBox.Show("User Input already used!", "Error");//show error
                                return GetMenuTrigger(iNumber);
                            }//if (Convert.ToChar(sInput) == cChars[i])
                        }//for (int i = 0; i < iNumber - 1; i++)
                        return Convert.ToChar(sInput.ToUpper());//return it
                    }//if (sInput.Trim().Length == 1 && sInput.Trim() != null)
                    else
                    {
                        MessageBox.Show("Invalid User Input!", "Error");//show error
                        return GetMenuTrigger(iNumber);//try again
                    }//else
                }//if (InputBox("User Input","User Input for Menu " + iNumber + ":",ref sInput) == DialogResult.OK)
                else
                {
                    return '\\';//\ is not allowed
                }
            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Invalid User Input!", "Error");//show error
                return GetMenuTrigger(iNumber);//try again
            }//catch
        }//GetMenuTrigger()

        public static string GetMenuName(int iNumber)
        {
            try
            {
                string sInput = "";//storage
                if (InputBox("Menu " + (iNumber + 1), "Menu display for Menu " + (iNumber + 1), ref sInput) == DialogResult.OK)
                {
                    if (sInput.Trim() != null && sInput.Trim().Length > 0)
                    {
                        return sInput;//return their input
                    }//if (sInput.Trim() != null && sInput.Trim().Length > 0)
                    else
                    {
                        MessageBox.Show("Not a valid display name!", "Error");//show error
                        return GetMenuName(iNumber);//try again
                    }//else
                }//if (InputBox("Menu " + iNumber, "Menu display for Menu " + iNumber, ref sInput) == DialogResult.OK)
                else
                {
                    return null;//clicked cancel so return nothing
                }//else
            }//try
            catch (Exception ex)
            {
                return null;//an error happened
            }//catch
        }//GetMenuName()

        public static decimal GetDecimalSwitchCase(int iNumber)
        {
            try
            {
                bCanceled = false;//reset variable
                string sInput = "";//storage
                if (!bNumerated)
                {
                    if (InputBox("Case " + (iNumber + 1), "Case for case " + (iNumber + 1) + ":", ref sInput) == DialogResult.OK)
                    {
                        if (sInput.Trim().Length <= 0)
                        {
                            MessageBox.Show("Invalid case choice!", "Error");//show error
                            return GetDecimalSwitchCase(iNumber);//try again
                        }//if (sInput.Trim().Length <= 0)
                        return Convert.ToDecimal(sInput);//return input
                    }//if (InputBox("Case " + (iNumber + 1), "Case for case " + (iNumber + 1) + ":", ref sInput) == DialogResult.OK)
                    else
                    {
                        bCanceled = true;//they canceled
                        return 0.00M;//return 0
                    }//else
                }//if (!bNumerated)
                else
                {
                    switch (iNumber)
                    {
                        case 1:
                            if (InputBox("First case", "First case:", ref sInput) == DialogResult.OK)
                            {
                                if (sInput.Trim().Length <= 0)
                                {
                                    MessageBox.Show("Invalid case choice!", "Error");//show error
                                    return GetDecimalSwitchCase(iNumber);//try again
                                }//if (sInput.Trim().Length <= 0)
                                return Convert.ToDecimal(sInput);//return input
                            }//if (InputBox("First case", "First case:", ref sInput) == DialogResult.OK)
                            else
                            {
                                bCanceled = true;//they canceled
                                return 0.00M;//return 0
                            }//else
                            break;//case 1
                        case 2:
                            if (InputBox("Last case", "Last case:", ref sInput) == DialogResult.OK)
                            {
                                if (sInput.Trim().Length <= 0)
                                {
                                    MessageBox.Show("Invalid case choice!", "Error");//show error
                                    return GetDecimalSwitchCase(iNumber);//try again
                                }//if (sInput.Trim().Length <= 0)
                                return Convert.ToDecimal(sInput);//return input
                            }//if (InputBox("Last case", "Last case:", ref sInput) == DialogResult.OK)
                            else
                            {
                                bCanceled = true;//they canceled
                                return 0.00M;//return 0
                            }//else
                            break;//case 2
                        case 3:
                            if (InputBox("Skip Factor", "Skip number:", ref sInput) == DialogResult.OK)
                            {
                                if (sInput.Trim().Length <= 0)
                                {
                                    MessageBox.Show("Invalid skip number!", "Error");//show error
                                    return GetDecimalSwitchCase(iNumber);//try again
                                }//if (sInput.Trim().Length <= 0)
                                return Convert.ToDecimal(sInput);//return input
                            }//if (InputBox("Last case", "Last case:", ref sInput) == DialogResult.OK)
                            else
                            {
                                bCanceled = true;//they canceled
                                return 0.00M;//return 0
                            }//else
                            break;//case 3
                    }//switch (iNumber)
                    return 0.00M;//return 0
                }//else
            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Invalid case!", "Error");//show error
                return GetDecimalSwitchCase(iNumber);//try again
            }//catch
        }//GetDecimalSwitchCase()

        public static double GetDoubleSwitchCase(int iNumber)
        {
            try
            {
                bCanceled = false;//reset variable
                string sInput = "";//storage
                if (!bNumerated)
                {
                    if (InputBox("Case " + (iNumber + 1), "Case for case " + (iNumber + 1) + ":", ref sInput) == DialogResult.OK)
                    {
                        if (sInput.Trim().Length <= 0)
                        {
                            MessageBox.Show("Invalid case choice!", "Error");//show error
                            return GetDoubleSwitchCase(iNumber);//try again
                        }//if (sInput.Trim().Length <= 0)
                        return Convert.ToDouble(sInput);//return input
                    }//if (InputBox("Case " + (iNumber + 1), "Case for case " + (iNumber + 1) + ":", ref sInput) == DialogResult.OK)
                    else
                    {
                        bCanceled = true;//they canceled
                        return 0.00;//return 0
                    }//else
                }//if (!bNumerated)
                else
                {
                    switch (iNumber)
                    {
                        case 1:
                            if (InputBox("First case", "First case:", ref sInput) == DialogResult.OK)
                            {
                                if (sInput.Trim().Length <= 0)
                                {
                                    MessageBox.Show("Invalid case choice!", "Error");//show error
                                    return GetDoubleSwitchCase(iNumber);//try again
                                }//if (sInput.Trim().Length <= 0)
                                return Convert.ToDouble(sInput);//return input
                            }//if (InputBox("First case", "First case:", ref sInput) == DialogResult.OK)
                            else
                            {
                                bCanceled = true;//they canceled
                                return 0.00;//return 0
                            }//else
                            break;//case 1
                        case 2:
                            if (InputBox("Last case", "Last case:", ref sInput) == DialogResult.OK)
                            {
                                if (sInput.Trim().Length <= 0)
                                {
                                    MessageBox.Show("Invalid case choice!", "Error");//show error
                                    return GetDoubleSwitchCase(iNumber);//try again
                                }//if (sInput.Trim().Length <= 0)
                                return Convert.ToDouble(sInput);//return input
                            }//if (InputBox("Last case", "Last case:", ref sInput) == DialogResult.OK)
                            else
                            {
                                bCanceled = true;//they canceled
                                return 0.00;//return 0
                            }//else
                            break;//case 2
                        case 3:
                            if (InputBox("Skip Factor", "Skip number:", ref sInput) == DialogResult.OK)
                            {
                                if (sInput.Trim().Length <= 0)
                                {
                                    MessageBox.Show("Invalid skip number!", "Error");//show error
                                    return GetDoubleSwitchCase(iNumber);//try again
                                }//if (sInput.Trim().Length <= 0)
                                return Convert.ToDouble(sInput);//return input
                            }//if (InputBox("Last case", "Last case:", ref sInput) == DialogResult.OK)
                            else
                            {
                                bCanceled = true;//they canceled
                                return 0.00;//return 0
                            }//else
                            break;//case 3
                    }//switch (iNumber)
                    return 0.00;//return 0
                }//else
            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Invalid case!", "Error");//show error
                return GetDoubleSwitchCase(iNumber);//try again
            }//catch
        }//GetDecimalSwitchCase()

        public static int GetIntSwitchCase(int iNumber)
        {
            try
            {
                bCanceled = false;//reset variable
                string sInput = "";//storage
                if (!bNumerated)
                {
                    if (InputBox("Case " + (iNumber + 1), "Case for case " + (iNumber + 1) + ":", ref sInput) == DialogResult.OK)
                    {
                        if (sInput.Trim().Length <= 0)
                        {
                            MessageBox.Show("Invalid case choice!", "Error");//show error
                            return GetIntSwitchCase(iNumber);//try again
                        }//if (sInput.Trim().Length <= 0)
                        return Convert.ToInt32(sInput);//return the choice
                    }//if (InputBox("Case " + (iNumber + 1), "Case for case " + (iNumber + 1) + ":", ref sInput) == DialogResult.OK)
                    else
                    {
                        bCanceled = true;//they canceled
                        return 0;//return a random number (0)
                    }//else
                }//if (!bNumerated)
                else
                {
                    switch (iNumber)
                    {
                        case 1:
                            if (InputBox("First Case", "First Case:", ref sInput) == DialogResult.OK)
                            {
                                if (sInput.Trim().Length <= 0)
                                {
                                    MessageBox.Show("Invalid case chioce!", "Error");//show error
                                    return GetIntSwitchCase(iNumber);//try again
                                }//if (sInput.Trim().Length <= 0)
                                return Convert.ToInt32(sInput);//return the choice
                            }//if (InputBox("First Case", "First Case:", ref sInput) == DialogResult.OK)
                            else
                            {
                                bCanceled = true;//they canceled
                                return 0;//return a random number
                            }//else
                            break;//case 1
                        case 2:
                            if (InputBox("Last Case", "Last Case:", ref sInput) == DialogResult.OK)
                            {
                                if (sInput.Trim().Length <= 0)
                                {
                                    MessageBox.Show("Invalid case chioce!", "Error");//show error
                                    return GetIntSwitchCase(iNumber);//try again
                                }//if (sInput.Trim().Length <= 0)
                                return Convert.ToInt32(sInput);//return the choice
                            }//if (InputBox("First Case", "First Case:", ref sInput) == DialogResult.OK)
                            else
                            {
                                bCanceled = true;//they canceled
                                return 0;//return a random number
                            }//else
                            break;//case 2
                        case 3:
                            if (InputBox("Skip count", "Skip count:", ref sInput) == DialogResult.OK)
                            {
                                if (sInput.Trim().Length <= 0)
                                {
                                    MessageBox.Show("Invalid case choice!", "Error");//show error
                                    return GetIntSwitchCase(iNumber);//try again
                                }//
                                return Convert.ToInt32(sInput);//return the choice
                            }//if (InputBox("Skip count", "Skip count:", ref sInput) == DialogResult.OK)
                            else
                            {
                                bCanceled = true;//they canceledor exited out
                                return 0;//return a random number
                            }//else
                            break;//case 3
                    }//switch iNumber
                    return 0;//basicly a default return
                }//else
            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Invalid case choice!", "Error");//show error
                return GetIntSwitchCase(iNumber);//try again
            }//catch
        }//GetIntSwitchCase()

        public static string GetStringSwitchCase(int iNumber)
        {
            try
            {
                string sInput = "";//storage
                if (InputBox("Case " + (iNumber + 1), " Case for case " + (iNumber + 1) + ":", ref sInput) == DialogResult.OK)
                {
                    if (sInput.Trim().Length <= 0)
                    {
                        MessageBox.Show("Invalid case choice!", "Error");//show error
                        return GetStringSwitchCase(iNumber);//try again
                    }//if (sInput.Trim().Length <= 0)
                    return Convert.ToString(sInput);//return the input
                }//if (InputBox("Case " + (iNumber + 1), " Case for case " + (iNumber + 1) + ":", ref sInput) == DialogResult.OK)
                else
                {
                    return null;//value to show they closed it
                }//else
            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Invalid case choice!", "Error");//show error
                return GetStringSwitchCase(iNumber);//try again
            }//catch
        }//GetStringSwitchCase()

        public static char GetCharSwitchCase(int iNumber)
        {
            try
            {
                string sInput = "";//storage
                if (!bNumerated)
                {
                    if (InputBox("Case " + (iNumber + 1), "Case for case " + (iNumber + 1) + ":", ref sInput) == DialogResult.OK)
                    {
                        if (sInput.Trim().Length > 1 || sInput.Trim().Length <= 0 || sInput.Trim() == "/")
                        {
                            MessageBox.Show("Invalid case choice!", "Error");//show error
                            return GetCharSwitchCase(iNumber);//try until user isn't stupid
                        }//if (sInput.Trim().Length > 1 || sInput.Trim().Length <= 0 || sInput.Trim() == "/")
                        if (bCaseSensitive)
                        {
                            return Convert.ToChar(sInput);//return the input
                        }//if bCaseSensitive
                        return Convert.ToChar(sInput.ToUpper());//return the input
                    }//if (InputBox("Case " + iNumber, "Case for case " + iNumber + ":", ref sInput) == DialogResult.OK)
                    else
                    {
                        return '/';//value for saying char is null
                    }//else
                }
                else
                {
                    switch (iNumber)
                    {
                        case 0:
                            if (InputBox("Starting Case", "Starting Case:", ref sInput) == DialogResult.OK)
                            {
                                foreach (char cCase in cAlphabet)
                                {
                                    if (Convert.ToChar(sInput.ToUpper()) == cCase)
                                    {
                                        return Convert.ToChar(sInput.ToUpper());//return their input because it is a letter
                                    }//if (Convert.ToChar(sInput) == cCase)
                                }//foreach (char cCase in cAlphabet)
                                MessageBox.Show("Invalid Case! Case must be a letter for numerated!", "Error");//show error
                                return GetCharSwitchCase(0);//try again                                
                            }//if (InputBox("Starting Case", "Starting Case:", ref sInput) == DialogResult.OK)
                            else
                            {
                                return '\0';//return null
                            }//else
                            break;//case 0
                        case 1:
                            if (InputBox("Last Case", "Last Case:", ref sInput) == DialogResult.OK)
                            {
                                foreach (char cCase in cAlphabet)
                                {
                                    return Convert.ToChar(sInput);//return the input
                                }//
                            }//if (InputBox("Last Case", "Last Case:", ref sInput) == DialogResult.OK)
                            else
                            {
                                return '\0';//return null
                            }//else
                            break;//case 1
                    }//switch iNumber
                    return '0';//if coded wrong fail
                }
            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Invalid case choice!", "Error");//show error
                return GetCharSwitchCase(iNumber);//try until user isn't stupid
            }//catch
        }//GetCharSwitchCase()

        public static void GenerateMessageBox(TextBox txtCode, TextBox txtDialogVar, TextBox txtTitle, TextBox txtMessage)
        {
            try
            {
                string sLine = "";//storage
                string sButtons = "MessageBoxButtons." + mbButton.ToString();//get messagebox button
                string sIcon = "MessageBoxIcon." + mbIcon.ToString();//get message box icon
                string sDefaultButton = "MessageBoxDefaultButton." + mbDefaultButton.ToString();//get default button
                if (mbButton.ToString() != "OK")
                {
                    if (txtDialogVar.Text.Trim().Length <= 0)
                    {
                        MessageBox.Show("You must have a Dialog Variable!", "Error");//show error
                        txtDialogVar.Focus();//focus text box
                        return;//stop code
                    }//if (txtDialogVar.Text.Trim().Length <=0)
                    sDialogVar = txtDialogVar.Text;//set dialog 
                    sLine += "DialogResult " + sDialogVar + " = ";
                }//if (sButtons != "OK")
                sLine += "MessageBox.Show(";
                if (txtMessage.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("You must have a message!", "Error");//show error
                    txtMessage.Focus();//focus text box
                    return;//stop code
                }//if (txtMessage.Text.Trim().Length <= 0)               
                sLine += "\"" + txtMessage.Text + "\"";
                if (txtTitle.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("You must have a title!", "Error");//show error
                    txtMessage.Focus();//focus textbox
                    return;//stop code
                }//if (txtTitle.Text.Trim().Length <= 0)
                sLine += ", \"" + txtTitle.Text + "\"";
                if (mbButton.ToString() == null)
                {
                    sButtons = "MessageBoxButtons.OK";//set default
                }// if (mbButton.ToString() == null)
                if (mbIcon.ToString() == null)
                {
                    sIcon = "MessageBoxIcon.None";//set default
                }//if (mbIcon.ToString() == null)
                if (mbDefaultButton.ToString() == null)
                {
                    sDefaultButton = "MessageBoxDefaultButton.Button1";//set default
                }//if (mbDefaultButton.ToString() == null)
                sLine += ", " + sButtons + ", " + sIcon + ", " + sDefaultButton + ");//show messagebox";//generate code
                if (mbButton.ToString() != "OK")
                {
                    switch (mbButton.ToString())
                    {
                        case "AboutRetryIgnore":
                            sLine += Environment.NewLine;//skip a line
                            sLine += "if (" + sDialogVar + " == DialogResult.About)" + Environment.NewLine;//if statement
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//if (" + sDialogVar + " == DialogResult.About)" + Environment.NewLine;//close curly brace and comment
                            sLine += "else if ( " + sDialogVar + " == DialogResult.Retry)" + Environment.NewLine;//else if statement 
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//else if (" + sDialogVar + " == DialogResult.Retry)" + Environment.NewLine;//close curly brace and comment
                            break;//case "AboutRetryIgnore":                       
                        case "OKCancel":
                            sLine += Environment.NewLine;//skip a line
                            sLine += "if (" + sDialogVar + " == DialogResult.OK)" + Environment.NewLine;//if statement
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//if (" + sDialogVar + " == DialogResult.OK)" + Environment.NewLine;//close curly brace and comment
                            sLine += "else if (" + sDialogVar + " == DialogResult.Cancel)" + Environment.NewLine;//else if statement
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//else if (" + sDialogVar + " == DialogResult.Cancel)" + Environment.NewLine;//close curly brace and comment
                            break;//case "OKCancel":
                        case "RetryCancel":
                            sLine += Environment.NewLine;//skip a line
                            sLine += "if (" + sDialogVar + " == DialogResult.Retry)" + Environment.NewLine;//if statement
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//if (" + sDialogVar + " == DialogResult.Retry)" + Environment.NewLine;//close curly brace and comment
                            sLine += "else if (" + sDialogVar + " == DialogResult.Cancel)" + Environment.NewLine;//else if statement
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//else if (" + sDialogVar + " == DialogResult.Cancel)" + Environment.NewLine;//close curly brace and comment
                            break;//case "RetryCancel":
                        case "YesNo":
                            sLine += Environment.NewLine;//skip a line
                            sLine += "if (" + sDialogVar + " == DialogResult.Yes)" + Environment.NewLine;//if statement
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//if (" + sDialogVar + " == DialogResult.Yes)" + Environment.NewLine;//close curly brace and comment
                            sLine += "else if (" + sDialogVar + " == DialogResult.No)" + Environment.NewLine;//else if statement
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//else if (" + sDialogVar + " == DialogResult.No)" + Environment.NewLine;//close curly brace and comment
                            break;//case "YesNo":
                        case "YesNoCancel":
                            sLine += Environment.NewLine;//skip a line
                            sLine += "if (" + sDialogVar + " == DialogResult.Yes)" + Environment.NewLine;//if statement
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//if (" + sDialogVar + " == DialogResult.Yes)" + Environment.NewLine;//close curly brace and comment
                            sLine += "else if (" + sDialogVar + " == DialogResult.No)" + Environment.NewLine;//else if statement
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//else if (" + sDialogVar + " == DialogResult.No)" + Environment.NewLine;//close curly brace and comment
                            sLine += "else if (" + sDialogVar + " == DialogResult.Cancel)" + Environment.NewLine;//else if statement
                            sLine += "{" + Environment.NewLine + Environment.NewLine;//open curly brace
                            sLine += "}//else if (" + sDialogVar + " == DialogResult.Cancel)" + Environment.NewLine;//close curly brace and comment
                            break;//case "YesNoCancel"
                    }//switch
                }//if (mbButton.ToString() != "OK")
                txtCode.Text = sLine;//show text
                System.Windows.Forms.Clipboard.SetText(sLine);//set clipboard
            }//try
            catch (Exception ex)
            {
                MessageBox.Show("Error when generating code. " + ex.Message, "Error");//show what went wrong
            }//catch
        }//GenerateMessageBox()

        public static void ShowSampleMessageBox(TextBox txtCode, TextBox txtDialogVar, TextBox txtTitle, TextBox txtMessage)
        {
            if (mbButton.ToString() != "OK")
            {
                if (txtDialogVar.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("You must have a Dialog Variable!", "Error");//show error
                    txtDialogVar.Focus();//focus text box
                    return;//stop code
                }//if (txtDialogVar.Text.Trim().Length <=0)
            }//if (sButtons != "OK")
            if (txtMessage.Text.Trim().Length <= 0)
            {
                MessageBox.Show("You must have a message!", "Error");//show error
                txtMessage.Focus();//focus text box
                return;//stop code
            }//if (txtMessage.Text.Trim().Length <= 0)        
            if (txtTitle.Text.Trim().Length <= 0)
            {
                MessageBox.Show("You must have a title!", "Error");//show error
                txtMessage.Focus();//focus textbox
                return;//stop code
            }//if (txtTitle.Text.Trim().Length <= 0)
            MessageBox.Show(txtMessage.Text.ToString(), txtTitle.Text.ToString(), mbButton, mbIcon, mbDefaultButton);//show sample
        }//ShowSampleMessageBox()

        public static void GenerateStringMenu(TextBox txtCode, TextBox txtNumber)
        {
            if (ValidateStringMenuNumber(txtNumber.Text))
            {
                iMenuAmount = Convert.ToInt32(txtNumber.Text);
            }// if (ValidateCharMenuNumber(txtNumber.Text))
            else
            {
                MessageBox.Show("Invalid Menu Options! (Options must be a number)", "Error");//show error
                txtNumber.Clear();//clear text box
                txtNumber.Focus();//focus text
                return;//stop code                
            }//else
            string sLine = "";//code storage
            cChars = new char[iMenuAmount];//redefine array
            sNames = new string[iMenuAmount];//redefine array
            for (int i = 0; i < iMenuAmount; i++)
            {
                string sInput = "";//storage
                //char cInput = ' ';//storage
                sInput = GetMenuName(i);//get input
                if (sInput == null)
                {
                    return;//stop code because they canceled
                }//if sInput == null
                else
                {
                    sNames[i] = sInput;//set variable
                }//else
            }//for int i = 0; i < imenuamount - 1; i++
            if (bUseMethods)
            {
                if (InputBox("Method Name", "Method Name:", ref sMethodName) == DialogResult.OK)
                {

                }//if (InputBox("Method Name", "Method Name:", ref sMethodName) == DialogResult.OK)
                else
                {
                    return;//user clicked cancel
                }//else
            }//if busemethods
            if (InputBox("Asking String", "Text to ask user:", ref sChoiceString) == DialogResult.OK)
            {

            }//if (InputBox("Asking String", "Text to ask user:", ref sChoiceString) == DialogResult.OK)
            else
            {
                return;//they canceled
            }//else
            if (!bUseMethods)
            {
                foreach (string sName in sNames)
                {
                    sLine += "Console.WriteLine(\"" + sName + "\");////Show option" + Environment.NewLine;//add writeline
                }//foreach (string sName in sNames)
                sLine += "Console.Write(\"" + sChoiceString + "\");//Ask user for input";
            }//if !busemethods
            else
            {
                sLine += "public string " + sMethodName + "()" + Environment.NewLine;//method name
                sLine += "{" + Environment.NewLine;//method opencurlybrace
                sLine += "\ttry" + Environment.NewLine;//try
                sLine += "\t{" + Environment.NewLine;//try open curlybrace
                sLine += "\t\tstring sInput = \" \";//input the user gives" + Environment.NewLine;//input variable
                foreach (string sName in sNames)
                {
                    sLine += "\t\tConsole.WriteLine(\"" + sName + "\");//Show Option" + Environment.NewLine;//add writeline
                }//writelines
                sLine += "\t\tConsole.Write(\"" + sChoiceString + "\");//Ask user for input" + Environment.NewLine;//add write
                sLine += "\t\tcInput = Convert.ToChar(Console.ReadLine().ToUpper());//Get the input" + Environment.NewLine;//conver and get the variable                    
                sLine += "\t\treturn sInput;//Return user's choice" + Environment.NewLine;//return result
                sLine += "\t}//try" + Environment.NewLine;//try close curlybrace
                sLine += "\tcatch (Exception ex)" + Environment.NewLine;//catch exception ex
                sLine += "\t{" + Environment.NewLine;//catch open curly brace
                sLine += "\t\tConsole.Clear();//Clear the screen" + Environment.NewLine;//Console.Clear()
                sLine += "\t\tConsole.WriteLine(\"Invalid Choice\");//Show error" + Environment.NewLine;//console.writeline(invalidchoice)
                sLine += "\t\treturn " + sMethodName + "();//Loop until it is right" + Environment.NewLine;//return methodname()
                sLine += "\t}//catch" + Environment.NewLine;//catch end curly brace
                sLine += "}//" + sMethodName + "()";//method close curlybrace
            }//else
            txtCode.Text = sLine;//show code
            System.Windows.Forms.Clipboard.SetText(sLine);//copy code to clipboard
        }//GenerateCharMenu(TextBox txtCode, TextBox txtNumber,TextBox txtChoiceString)

        public static void GenerateIntSwitch(TextBox txtCode, TextBox txtNumber, TextBox txtSwitchVar)
        {
            if (txtSwitchVar.Text.Length == 0)
            {
                MessageBox.Show("You must have a Variable to Switch!", "Error");//show error
                txtSwitchVar.Focus();//focus
                return;//stop code
            }//if (txtSwitchVar.Text.Length == 0)
            clsCode.sSwitchVar = txtSwitchVar.Text;//set varable
            if (ValidateSwitchNumber(txtNumber.Text))
            {
                string sLine = "";//code generated storage
                sLine += "switch (" + sSwitchVar + ")" + Environment.NewLine;//switch (sSwitchVar)
                sLine += "{" + Environment.NewLine;//{
                int iCase1 = 0;//user's choice 1
                int iCase2 = 0;//user's choice 2
                if (!bNumerated)
                {
                    iAmount = Convert.ToInt32(txtNumber.Text);//set variable
                    iCases = new int[iAmount];//the amount of cases for the switches
                    for (int i = 0; i < iAmount; i++)
                    {
                        iCases[i] = GetIntSwitchCase(i);//get the char case
                        if (bCanceled)
                        {
                            return;//stop code because they hit cancel
                        }//if (bCanceled)
                    }//for int i = 1; i < iamount; i++
                    foreach (int iCase in iCases)
                    {
                        if (iCase != ' ')
                        {
                            sLine += "\tcase " + iCase + ":" + Environment.NewLine + Environment.NewLine;//case 'cCase':
                            sLine += "\t\tbreak;//case " + iCase + Environment.NewLine;//break;//case 'cCase'
                        }//if cCase != ' '
                    }//foreach (char cCase in cCases)
                }//if (!bNumerated)
                else
                {
                    iCase1 = GetIntSwitchCase(1);//get the first int
                    if (bCanceled)
                    {
                        return;//stop code because they canceled
                    }//if (bCanceled)
                    iCase2 = GetIntSwitchCase(2);//get the last int
                    if (bCanceled)
                    {
                        return;//stop code because they canceled
                    }//if (bCanceled)
                    while (iCase1 == iCase2)
                    {
                        MessageBox.Show("First and last case cannot be the same!", "Error");//show error
                        iCase1 = GetIntSwitchCase(1);//get the first int
                        if (bCanceled)
                        {
                            return;//stop code because they canceled
                        }//if (bCanceled)
                        iCase2 = GetIntSwitchCase(2);//get the last int
                        if (bCanceled)
                        {
                            return;//stop code because they canceled
                        }//if (bCanceled)
                    }//while (iCase1 == iCase2)
                    iSkip = 1;//set the default skip count
                    if (bSkip)
                    {
                        iSkip = GetIntSwitchCase(3);//get the skip int
                        while (iSkip <= 0)
                        {
                            MessageBox.Show("Invalid skip count!", "Error");//show error
                            iSkip = GetIntSwitchCase(3);//get the skip int
                        }//while (iSkip <= 0)
                    }//if (bSkip)
                    if (iCase1 > iCase2)
                    {
                        for (int i = iCase1; i >= iCase2; i -= iSkip)
                        {
                            sLine += "\tcase " + i + ":" + Environment.NewLine + Environment.NewLine;//case 'cCase':
                            sLine += "\t\tbreak;//case " + i + Environment.NewLine;//break;//case 'cCase'
                        }//for (int i = iCase1; i >= iCase2; i--)
                    }//if (iCase1 > iCase2)
                    if (iCase2 > iCase1)
                    {
                        for (int i = iCase1; i <= iCase2; i += iSkip)
                        {
                            sLine += "\tcase " + i + ":" + Environment.NewLine + Environment.NewLine;//case 'cCase':
                            sLine += "\t\tbreak;//case " + i + Environment.NewLine;//break;//case 'cCase'
                        }//for (int i = iCase1; i <= iCase2; i++)
                    }//if (iCase2 > iCase1)
                }//else
                if (bDefaultCase)
                {
                    sLine += "\tdefault:" + Environment.NewLine + Environment.NewLine;//default:
                    sLine += "\t\tbreak;//default" + Environment.NewLine;//break;
                }//if bDefaultCase
                sLine += "}//switch (" + sSwitchVar + ")";//}//switch(sSwitchVar)
                txtCode.Text = sLine;//show code
                System.Windows.Forms.Clipboard.SetText(sLine);//step clipboard  
            }//if (ValidateSwitchNumber(txtNumber.Text))
            else
            {
                MessageBox.Show("Invalid case amount!", "Error");//show error
                txtNumber.Clear();//clear box
                txtNumber.Focus();//focus text box
                return;//stop code because there was a user error!
            }//else
        }//GenerateIntSwitch()

        public static void GenerateStringSwitch(TextBox txtCode, TextBox txtNumber, TextBox txtSwitchVar)
        {
            if (txtSwitchVar.Text.Length == 0)
            {
                MessageBox.Show("You must have a Variable to Switch!", "Error");//show error
                txtSwitchVar.Focus();//focus
                return;
            }//if (txtSwitchVar.Text.Length == 0)
            clsCode.sSwitchVar = txtSwitchVar.Text;//set variable
            if (!bNumerated)
            {
                if (ValidateSwitchNumber(txtNumber.Text))
                {
                    string sLine = "";//code generatd storage
                    if (!bNumerated)
                    {
                        iAmount = Convert.ToInt32(txtNumber.Text);//set variable
                        sCases = new string[iAmount];//the amount of cases for the switches
                        for (int i = 0; i < iAmount; i++)
                        {
                            sCases[i] = GetStringSwitchCase(i);//get the char case
                            if (sCases[i] == null)
                            {
                                return;//stop code because they hit cancel
                            }//if ccasesi == /
                        }//for int i = 1; i < iamount; i++
                    }//if bNumerated
                    sLine += "switch (" + sSwitchVar + ")" + Environment.NewLine;//switch (sSwitchVar)
                    sLine += "{" + Environment.NewLine;//{
                    foreach (string sCase in sCases)
                    {
                        if (sCase != " ")
                        {
                            sLine += "\tcase \"" + sCase + "\":" + Environment.NewLine + Environment.NewLine;//case "sCase":
                            sLine += "\t\tbreak;//case \"" + sCase + "\"" + Environment.NewLine;//break;//case "sCase"
                        }//if cCase != ' '
                    }//foreach (char cCase in cCases)
                    if (bDefaultCase)
                    {
                        sLine += "\tdefault:" + Environment.NewLine + Environment.NewLine;//default:
                        sLine += "\t\tbreak;//default" + Environment.NewLine;//break;
                    }//if bDefaultCase
                    sLine += "}//switch (" + sSwitchVar + ")";//}//switch(sSwitchVar)
                    txtCode.Text = sLine;//show code
                    System.Windows.Forms.Clipboard.SetText(sLine);//step clipboard
                }//if (ValidateSwitchNumber(txtNumber.Text))
                else
                {
                    MessageBox.Show("Invalid case amount!", "Error");//show error
                    txtNumber.Clear();//clear box
                    txtNumber.Focus();//focus text box
                    return;//stop code because there was a user error!
                }//else
            }//if !bNumerated
        }//GenerateStringSwitch()

        public static void GenerateCharSwitch(TextBox txtCode, TextBox txtNumber, TextBox txtSwitchVar)
        {
            if (txtSwitchVar.Text.Length == 0)
            {
                MessageBox.Show("You must have a Variable to Switch!", "Error");//show error
                txtSwitchVar.Focus();//focus
                return;//stop code
            }//if (txtSwitchVar.Text.Length == 0)
            clsCode.sSwitchVar = txtSwitchVar.Text;//set variable
            char cCase1 = ' ';
            char cCase2 = ' ';
            int iCase1 = 0;
            int iCase2 = 0;
            if (ValidateSwitchNumber(txtNumber.Text))
            {
                string sLine = "";//code generated storage
                sLine += "switch (" + sSwitchVar + ")" + Environment.NewLine;//switch (sSwitchVar)
                sLine += "{" + Environment.NewLine;//{
                if (!bNumerated)
                {
                    iAmount = Convert.ToInt32(txtNumber.Text);//set variable
                    cCases = new char[iAmount];//the amount of cases for the switches
                    for (int i = 0; i < iAmount; i++)
                    {
                        cCases[i] = GetCharSwitchCase(i);//get the char case
                        if (cCases[i] == '/')
                        {
                            return;//stop code because they hit cancel
                        }//if ccasesi == /
                    }//for int i = 1; i < iamount; i++
                }//if bNumerated
                else
                {
                    cCase1 = GetCharSwitchCase(0);//first case
                    if (cCase1 == '/')
                    {
                        return;//stop code because they hit cancel
                    }//if (cCase1 == '/'
                    cCase2 = GetCharSwitchCase(1);//second case
                    if (cCase2 == '/')
                    {
                        return;//stop code because they hit cancel
                    }//if (cCase2 == '/')
                    while (cCase2.ToString().ToUpper() == cCase1.ToString().ToUpper())
                    {
                        MessageBox.Show("Cases cannot be the same!", "Error");//show error
                        cCase1 = GetCharSwitchCase(0);//first case
                        if (cCase1 == '/')
                        {
                            return;//stop code because they hit cancel
                        }//if (cCase1 == '/'
                        cCase2 = GetCharSwitchCase(1);//second case
                        if (cCase2 == '/')
                        {
                            return;//stop code because they hit cancel
                        }//if (cCase2 == '/')
                    }//while (cCase2.ToString().ToUpper() == cCase1.ToString().ToUpper())
                    iCase1 = GetLetterNumber(cCase1);//get what letter number it is for looping
                    iCase2 = GetLetterNumber(cCase2);//get what letter number it is for looping
                    cCases = new char[cAlphabet.Count()];//set the array index
                    if (iCase1 > iCase2)
                    {
                        for (int i = iCase1; i >= iCase2; i--)
                        {
                            cCases[i] = cAlphabet[i];//set the letter
                        }//for (int i = iCase1; i >= iCase2; i--)
                        for (int i = iCase1; i >= iCase2; i--)
                        {
                            if (cCases[i] != ' ' && cCases[i] != '\0')
                            {
                                sLine += "\tcase \'" + cCases[i] + "\':" + Environment.NewLine + Environment.NewLine;//case 'cCase':
                                sLine += "\t\tbreak;//case \'" + cCases[i] + "\'" + Environment.NewLine;//break;//case 'cCase'
                            }//if (cCases[i] != ' ' && cCases[i] != '\0')
                        }//for (int i = cCase1; i >= cCase2; i += iIncrement)
                    }//if (iCase1 > iCase2)
                    else if (iCase2 > iCase1)
                    {
                        for (int i = iCase1; i <= iCase2; i++)
                        {
                            cCases[i] = cAlphabet[i];//set the leter
                        }//for (int i = iCase1; i < iCase2; i++)
                        for (int i = iCase1; i <= iCase2; i++)
                        {
                            if (cCases[i] != ' ' && cCases[i] != '\0')
                            {
                                sLine += "\tcase \'" + cCases[i] + "\':" + Environment.NewLine + Environment.NewLine;//case 'cCase':
                                sLine += "\t\tbreak;//case \'" + cCases[i] + "\'" + Environment.NewLine;//break;//case 'cCase'
                            }//if (cCases[i] != ' ' && cCases[i] != '\0')
                        }//for (int i = cCase1; i >= cCase2; i += iIncrement)
                    }//else if (iCase2 > iCase1)
                }//else
                if (!bNumerated)
                {
                    foreach (char cCase in cCases)
                    {
                        if (cCase != ' ' && cCase != '\0')
                        {
                            sLine += "\tcase \'" + cCase + "\':" + Environment.NewLine + Environment.NewLine;//case 'cCase':
                            sLine += "\t\tbreak;//case \'" + cCase + "\'" + Environment.NewLine;//break;//case 'cCase'
                        }//if cCase != ' '
                    }//foreach (char cCase in cCases)
                }//if (!bNumerated)
                if (bDefaultCase)
                {
                    sLine += "\tdefault:" + Environment.NewLine + Environment.NewLine;//default:
                    sLine += "\t\tbreak;//default" + Environment.NewLine;//break;
                }//if bDefaultCase
                sLine += "}//switch (" + sSwitchVar + ")";//}//switch(sSwitchVar)
                txtCode.Text = sLine;//show code
                System.Windows.Forms.Clipboard.SetText(sLine);//step clipboard
            }//if (ValidateSwitchNumber(txtNumber.Text))
            else
            {
                MessageBox.Show("Invalid case amount!", "Error");//show error
                txtNumber.Clear();//clear box
                txtNumber.Focus();//focus text box
                return;//stop code because there was a user error!
            }//else
        }//GenerateCharSwitch()

        public static void GenerateBoolSwitch(TextBox txtCode, TextBox txtSwitchVar)
        {
            if (txtSwitchVar.Text.Length == 0)
            {
                MessageBox.Show("You must have a Variable to Switch!", "Error");//show error
                txtSwitchVar.Focus();//focus
                return;//stop code
            }//if (txtSwitchVar.Text.Length == 0)
            clsCode.sSwitchVar = txtSwitchVar.Text;//set variable
            string sLine = "";//storage
            sLine = "switch (" + sSwitchVar + ")" + Environment.NewLine;//switch (svar)
            sLine += "{" + Environment.NewLine;//{
            sLine += "\tcase true:" + Environment.NewLine + Environment.NewLine;//case true
            sLine += "\t\tbreak;//case true" + Environment.NewLine;//break;//case true
            sLine += "\tcase false:" + Environment.NewLine + Environment.NewLine;//case false
            sLine += "\t\tbreak;//case false" + Environment.NewLine;//break;//case false
            if (bDefaultCase)
            {
                sLine += "\tdefault:" + Environment.NewLine + Environment.NewLine;//default:
                sLine += "\t\tbreak;//default" + Environment.NewLine;//break;
            }//if bDefaultCase
            sLine += "}//switch (" + sSwitchVar + ")";//}switch (svar)
            txtCode.Text = sLine;//show code
            System.Windows.Forms.Clipboard.SetText(sLine);//set clipboard
        }//GenerateBooLSwitch

        public static void GenerateDecimalSwitch(TextBox txtCode, TextBox txtNumber, TextBox txtSwitchVar)
        {
            if (txtSwitchVar.Text.Length == 0)
            {
                MessageBox.Show("You must have a Variable to Switch!", "Error");//show error
                txtSwitchVar.Focus();//focus
                return;//stop code
            }//if (txtSwitchVar.Text.Length == 0)
            clsCode.sSwitchVar = txtSwitchVar.Text;//set variable
            string sLine = "";//storage
            decimal deStarting = 0.00M;//starting variable for numerated
            decimal deEnding = 0.00M;//ending value
            decimal deStep = 0.00M;//skip value
            sLine = "switch (" + sSwitchVar + ")" + Environment.NewLine;//switch (svar)
            sLine += "{" + Environment.NewLine;//{
            if (ValidateSwitchNumber(txtNumber.Text))
            {
                if (!bNumerated)
                {
                    deCases = new decimal[iAmount + 2];//set amount of cases
                    for (int i = 0; i < iAmount; i++)
                    {
                        deCases[i] = GetDecimalSwitchCase(i);//get the case
                        if (bCanceled)
                        {
                            return;//stop code because they canceled
                        }//if (bCanceled)
                    }//for (int i = 0; i < iAmount; i++)
                    foreach (decimal deCase in deCases)
                    {
                        sLine += "\tcase " + deCase + "M:" + Environment.NewLine + Environment.NewLine;//case ..M:
                        sLine += "\t\tbreak;//case " + deCase + "M" + Environment.NewLine;//break;//case ..M
                    }//foreach (decimal deCase in deCases)
                }//if (bNumerated)
                else
                {
                    deStarting = GetDecimalSwitchCase(1);//get first case
                    if (bCanceled)
                    {
                        return;//stop code becuase they canceled
                    }//if (bCanceled)
                    deEnding = GetDecimalSwitchCase(2);//get last case
                    if (bCanceled)
                    {
                        return;//stop code because they canceled
                    }//if (bCanceled)
                    while (deStarting == deEnding)
                    {
                        MessageBox.Show("Starting and ending values cannot be the same!", "Error");//show error
                        deStarting = GetDecimalSwitchCase(1);//get first case
                        if (bCanceled)
                        {
                            return;//stop code becuase they canceled
                        }//if (bCanceled)
                        deEnding = GetDecimalSwitchCase(2);//get last case
                        if (bCanceled)
                        {
                            return;//stop code because they canceled
                        }//if (bCanceled)
                    }//while (deStarting == deEnding)
                    deStep = 1.00M;//set default value
                    if (bSkip)
                    {
                        deStep = GetDecimalSwitchCase(3);//get skipping factor
                        if (bCanceled)
                        {
                            return;//stop code because they canceled
                        }//if (bCanceled)
                        while (deStep <= 0.00M)
                        {
                            MessageBox.Show("Invalid skip case!", "Error");//show error
                            deStep = GetDecimalSwitchCase(3);//get skipping factor
                            if (bCanceled)
                            {
                                return;//stop code because they canceled
                            }//if (bCanceled)
                        }//while (deStep <= 0.00M)
                    }//if (bSkip)
                    if (deStarting < deEnding)
                    {
                        for (decimal i = deStarting; i <= deEnding; i += deStep)
                        {
                            sLine += "\tcase " + i + "M:" + Environment.NewLine + Environment.NewLine;//case ..M:
                            sLine += "\t\tbreak;//case " + i + "M" + Environment.NewLine;//break;//case ..M
                        }//for (decimal i = deStarting; i < deEnding; i += deStep)
                    }//if (deStarting < deEnding)
                    if (deEnding < deStarting)
                    {
                        for (decimal i = deStarting; i >= deEnding; i -= deStep)
                        {
                            sLine += "\tcase " + i + "M:" + Environment.NewLine + Environment.NewLine;//case ..M:
                            sLine += "\t\tbreak;//case " + i + "M" + Environment.NewLine;//break;//case ..M
                        }//for (decimal i = deEnding; i < deStarting; i += deStep)
                    }//if (deEnding < deStarting)
                }//else
                if (bDefaultCase)
                {
                    sLine += "\tdefault:" + Environment.NewLine + Environment.NewLine;//case ..M:
                    sLine += "\t\tbreak;//default" + Environment.NewLine;//break;//case ..M
                }//if (bDefaultCase)
                sLine += "}//switch (" + sSwitchVar + ")";//}switch (svar)
                txtCode.Text = sLine;//show code
                System.Windows.Forms.Clipboard.SetText(sLine);//set clipboard
            }//if (ValidateSwitchNumber(txtNumber.Text))
        }//GenerateDecimalSwitch()

        public static void GenerateDoubleSwitch(TextBox txtCode, TextBox txtNumber, TextBox txtSwitchVar)
        {
            if (txtSwitchVar.Text.Length == 0)
            {
                MessageBox.Show("You must have a Variable to Switch!", "Error");//show error
                txtSwitchVar.Focus();//focus
                return;//stop code
            }//if (txtSwitchVar.Text.Length == 0)
            clsCode.sSwitchVar = txtSwitchVar.Text;//set variable
            string sLine = "";//storage
            double dStarting = 0.00;//starting variable for numerated
            double dEnding = 0.00;//ending value
            double dStep = 0.00;//skip value
            sLine = "switch (" + sSwitchVar + ")" + Environment.NewLine;//switch (svar)
            sLine += "{" + Environment.NewLine;//{
            if (ValidateSwitchNumber(txtNumber.Text))
            {
                if (!bNumerated)
                {
                    dCases = new double[iAmount + 2];//set amount of cases
                    for (int i = 0; i < iAmount; i++)
                    {
                        dCases[i] = GetDoubleSwitchCase(i);//get the case
                        if (bCanceled)
                        {
                            return;//stop code because they canceled
                        }//if (bCanceled)
                    }//for (int i = 0; i < iAmount; i++)
                    foreach (double dCase in dCases)
                    {
                        sLine += "\tcase " + dCase + ":" + Environment.NewLine + Environment.NewLine;//case ..M:
                        sLine += "\t\tbreak;//case " + dCase + Environment.NewLine;//break;//case ..M
                    }//foreach (decimal deCase in deCases)
                }//if (bNumerated)
                else
                {
                    dStarting = GetDoubleSwitchCase(1);//get first case
                    if (bCanceled)
                    {
                        return;//stop code becuase they canceled
                    }//if (bCanceled)
                    dEnding = GetDoubleSwitchCase(2);//get last case
                    if (bCanceled)
                    {
                        return;//stop code because they canceled
                    }//if (bCanceled)
                    while (dStarting == dEnding)
                    {
                        MessageBox.Show("Starting and ending values cannot be the same!", "Error");//show error
                        dStarting = GetDoubleSwitchCase(1);//get first case
                        if (bCanceled)
                        {
                            return;//stop code becuase they canceled
                        }//if (bCanceled)
                        dEnding = GetDoubleSwitchCase(2);//get last case
                        if (bCanceled)
                        {
                            return;//stop code because they canceled
                        }//if (bCanceled)
                    }//while (deStarting == deEnding)
                    dStep = 1.00;//set default value
                    if (bSkip)
                    {
                        dStep = GetDoubleSwitchCase(3);//get skipping factor
                        if (bCanceled)
                        {
                            return;//stop code because they canceled
                        }//if (bCanceled)
                        while (dStep <= 0.00)
                        {
                            MessageBox.Show("Invalid skip case!", "Error");//show error
                            dStep = GetDoubleSwitchCase(3);//get skipping factor
                            if (bCanceled)
                            {
                                return;//stop code because they canceled
                            }//if (bCanceled)
                        }//while (deStep <= 0.00M)
                    }//if (bSkip)
                    if (dStarting < dEnding)
                    {
                        for (double i = dStarting; i <= dEnding; i += dStep)
                        {
                            sLine += "\tcase " + i + ":" + Environment.NewLine + Environment.NewLine;//case ..M:
                            sLine += "\t\tbreak;//case " + i + Environment.NewLine;//break;//case ..M
                        }//for (decimal i = deStarting; i < deEnding; i += deStep)
                    }//if (deStarting < deEnding)
                    if (dEnding < dStarting)
                    {
                        for (double i = dStarting; i >= dEnding; i -= dStep)
                        {
                            sLine += "\tcase " + i + ":" + Environment.NewLine + Environment.NewLine;//case ..M:
                            sLine += "\t\tbreak;//case " + i + Environment.NewLine;//break;//case ..M
                        }//for (decimal i = deEnding; i < deStarting; i += deStep)
                    }//if (deEnding < deStarting)
                }//else
                if (bDefaultCase)
                {
                    sLine += "\tdefault:" + Environment.NewLine + Environment.NewLine;//case ..M:
                    sLine += "\t\tbreak;//default" + Environment.NewLine;//break;//case ..M
                }//if (bDefaultCase)
                sLine += "}//switch (" + sSwitchVar + ")";//}switch (svar)
                txtCode.Text = sLine;//show code
                System.Windows.Forms.Clipboard.SetText(sLine);//set clipboard
            }//if (ValidateSwitchNumber(txtNumber.Text))
        }//GenerateDecimalSwitch()

        public static int GetLetterNumber(char cLetter)
        {
            int iNum = 0;
            for (int i = 0; i < cAlphabet.Count(); i++)
            {
                if (cLetter.ToString().ToUpper() == cAlphabet[i].ToString())
                {
                    iNum = i;
                }//if cletter == calphabet
            }//for int i = 0 i < cAlphabet.count i++
            return iNum;//return number
        }//GetLetterNumber()

        public static int GetFormsCount(TextBox txtForms)
        {
            try
            {
                string sForms = txtForms.Text;//get forms text
                int iNum = sForms.Split('\n').Count();
                if (iNum < 4)
                {
                    return 0;//defautl value sayig BAD PERSON NO BISCIT
                }//if (iNum < 4)
                return iNum - 3;//return number of forms =D
            }//try
            catch (Exception ex)
            {
                return 0;//default value saying something is wrong
            }
        }

        public static void GenerateApplication(TextBox txtApplication, TextBox txtFilePath)
        {
            //string sTest = "0123456789";
            //MessageBox.Show(sTest.Remove(1, 5));
            //return;
            //Output: 06789
            ///CodeGenerator
            ///Creator Name
            ///Company name
            ///    FormName, FormTitle, FormWidth, FormHeight
            ///        FormName, FormTitle, FormWidth, FormHeight
            int iFormAmount = GetFormsCount(txtApplication);//get forms count
            if (iFormAmount == 0)
            {
                MessageBox.Show("Invalid Syntax. Please check Help for information on correct Syntax.", "Error");//show error
                return;//stop code ERROR =D
            }// if (iFormAmount == 0 )
            string sProjectName = "";//project name
            string sCreatorName = "";//creator ame
            string sCompanyname = "";//company name
            string[] sFormName = new string[iFormAmount];//formame
            string[] sFormTitle = new string[iFormAmount];//form title
            int[] iFormID = new int[iFormAmount]; //form to determine links
            int?[] iFormLinkID = new int?[iFormAmount];//what form it can be called by
            int[] iFormWidth = new int[iFormAmount];//width of form
            int[] iFormHeight = new int[iFormAmount];//height of form
            string sFilePath = txtFilePath.Text;//filepath
            string sDesigner = "";//storage for code of Form.Designer.cs
            string sForm = "";//code for Form.cs
            if (sFilePath.Length < 1)
            {
                MessageBox.Show("Invalid File Path!", "Error");//show error
                txtFilePath.Focus();//focus text box
                return;//stop code
            }//if (sFilePath.Length < 1)

            string[] sLines = txtApplication.Text.Split('\n');//split each thing by enter
            for (int i = 0; i < sLines.Count(); i++)
            {
                string sLineTest = "";
                if (i > 2)
                {
                    sLineTest = "/";//Used to tell where the tabs are. 
                    ///Using /, i can successfuly detect if there is still a \t (tab) character and remove it, and count the spaces
                    ///to determine how to link it together
                }//if (i > 2)
                sLines[i] = sLineTest + sLines[i];//the / char will be used for spacing purposes
            }//for (int i = 0; i < sLines.Count(); i++)
            string sSpaces = "";//spaces for things. \t is a tab.
            sProjectName = sLines[0].TrimStart('/', '\t').TrimEnd('\n');//project name
            sProjectName = sProjectName.Remove(sProjectName.Length - 1);//set projectname
            sCreatorName = sLines[1];//creator name
            sCompanyName = sLines[2];//company name


            for (int i = 3; i - 2 < iFormAmount + 1; i++)
            {
                string[] sForms = sLines[i].Split(',');
                if (sForms.Count() < 4 && i > 3)
                {
                    MessageBox.Show("Invalid Syntax. Please check Help for information on correct Syntax.", "Error");//show error
                    return;//stop code ERROR =D
                }//if (sForm.Count() < 4)
                iFormID[i - 3] = i - 3;//set form id
                sFormName[i - 3] = sForms[0];//set name
                sFormTitle[i - 3] = sForms[1];//set title
                iFormWidth[i - 3] = Convert.ToInt32(sForms[2]);//set width
                iFormHeight[i - 3] = Convert.ToInt32(sForms[3]);//set height
                string sFormName2 = sForms[0];
                sSpaces = "";//reset spaces
                while (sFormName2.Remove(0, 1).StartsWith("\t"))
                {
                    sSpaces += "\t";
                    sFormName2 = sFormName2.Remove(1, 1);
                }//while (sFormName2.Remove(0, 1).StartsWith("\t"))
                for (int x = i - 3; x >= 0 && iFormLinkID[i - 3] == null; x--)
                {
                    if (sSpaces == "")
                    {
                        iFormLinkID[i - 3] = null;//not linked to anything becuase it is the main form
                    }//if (sSpaces == "")
                    else if (sFormName[x] == (("/" + sSpaces.Remove(0, 1) + sFormName[x].TrimStart('/', '\t'))))
                    {                       
                        iFormLinkID[i - 3] = iFormID[x];//set liniked id
                    }//else if (sFormName[x] == (("/" + sSpaces.Remove(0, 1) + sFormName[x].TrimStart('/', '\t'))))
                }//for (int x = i - 3; x >= 0 && iFormLinkID[i - 3] == null; x--)
            }//for (int i = 1; i < iFormAmount + 1; i++)
            for (int i = 0; i < iFormAmount - 1; i++)
            {
                Directory.CreateDirectory(sFilePath + "\\" + sProjectName);//createproject name
                #region Form.cs

                #region TopLineComments
                sForm = "///" + sProjectName.TrimStart('/', '\t');//  ///ProjectName
                sForm += "///Created By: " + sCreatorName.TrimStart('/', '\t');// //Created By Name
                sForm += "///Created on: " + DateTime.Today + Environment.NewLine;//Created on Date
                sForm += "///(c) Copyright " + DateTime.Today.Year + ", " + sCompanyName.TrimStart('/', '\t');// (c) Copyright YEAR, COMPANY
                #endregion
                #region Useings
                sForm += "using System;" + Environment.NewLine;//using System;
                sForm += "using System.Collections.Generic;" + Environment.NewLine;//using System.Collecions.Generic;
                sForm += "using System.ComponentModel;" + Environment.NewLine;//using System.CompoentModel;
                sForm += "using System.Data;" + Environment.NewLine;//using System.Data;
                sForm += "using System.Drawing;" + Environment.NewLine;//using System.Drawing;
                sForm += "using System.Linq;" + Environment.NewLine;//using System.Linq;
                sForm += "using System.Text;" + Environment.NewLine;//using System.Text;
                sForm += "using System.Windows.Forms;" + Environment.NewLine + Environment.NewLine;//using System.Windows.Forms
                #endregion
                sForm += "namespace " + sProjectName.TrimStart('/', '\t');//namespace PROJECT
                sForm += "{" + Environment.NewLine;//                     {
                sForm += "\tpublic partial class " + sFormName[i].TrimStart('/', '\t') + " : Form" + Environment.NewLine;//public partial class FORM1NAME : Form
                sForm += "\t{" + Environment.NewLine;//{
                #region FormConstructor
                sForm += "\t\tpublic " + sFormName[i].TrimStart('/', '\t') + "()" + Environment.NewLine;//public FORMNAME()
                sForm += "\t\t{" + Environment.NewLine;//{
                sForm += "\t\t\tInitializeComponent();" + Environment.NewLine;//InitilizeComponent();
                sForm += "\t\t}//" + sFormName[i].TrimStart('/', '\t') + " Constructor" + Environment.NewLine + Environment.NewLine;//}//FORMNAME Constructor
                
                string[] sButtonsToMake = GetButtonNames(i, iFormLinkID, sFormName);

                foreach (string sButton in sButtonsToMake)
                {
                    if (sButton != "")
                    {
                        sForm += "\t\tprivate void Show" + sButton.TrimStart('/', '\t') + "_Click(object sender, EventArgs e)" + Environment.NewLine;
                        sForm += "\t\t{" + Environment.NewLine;
                        sForm += "\t\t\t" + sButton.TrimStart('/', '\t') + " frmCall = new " + sButton.TrimStart('/', '\t') + "();//new form object" + Environment.NewLine;
                        sForm += "\t\t\tfrmCall.Show();//show form" + Environment.NewLine;
                        sForm += "\t\t}//Show" + sButton.TrimStart('/', '\t') + "()" + Environment.NewLine + Environment.NewLine;
                    }
                }//foreach (string sButton in sButtonsToMake)
                sForm += "\t}//class" + Environment.NewLine;//}class
                sForm += "}//namespace";//}//namespace


                FileStream fsStream = new FileStream(sFilePath + "\\" + sProjectName.TrimEnd('\r') + "\\" + sFormName[i].TrimStart('/', '\t') + ".cs", FileMode.Create, FileAccess.Write);//file stream
                StreamWriter swWrite = new StreamWriter(fsStream);//stream writer

                swWrite.Write(sForm);//write the form
                swWrite.Close();
                fsStream.Close();
                #endregion
                #endregion

                #region Form Designer.cs

                sDesigner = "namespace " + sProjectName.TrimStart('/', '\t');//namespace PROJECTNAME
                sDesigner += "{" + Environment.NewLine;//{
                sDesigner += "\tpartial class " + sFormName[i].TrimStart('/', '\t') + Environment.NewLine;//partial class FORMNAME
                sDesigner += "\t{\n";//{
                sDesigner += "\t\t/// <summary>" + Environment.NewLine;//summarry
                sDesigner += "\t\t/// Required designer variable." + Environment.NewLine;//description
                sDesigner += "\t\t/// </summary> " + Environment.NewLine;//end summary
                sDesigner += "\t\tprivate System.ComponentModel.IContainer components = null;" + Environment.NewLine;//required designer variable
                sDesigner += "\t\t/// <summary>" + Environment.NewLine;//start summary
                sDesigner += "\t\t/// Clean up any resources beig used. " + Environment.NewLine;//discription
                sDesigner += "\t\t/// </summary>" + Environment.NewLine;//end summary
                sDesigner += "\t\t/// <param name=\"disposing\">true if managed resources should be disposed; otherwise, false.</param>" + Environment.NewLine;//description
                sDesigner += "\t\tprotected override void Dispose(bool disposing)" + Environment.NewLine;//method
                sDesigner += "\t\t{" + Environment.NewLine;//{
                sDesigner += "\t\t\tif (disposing && (componets != null))" + Environment.NewLine;//if statement
                sDesigner += "\t\t\t{" + Environment.NewLine;//{
                sDesigner += "\t\t\t\tcomponents.Dispose();" + Environment.NewLine;//dispose
                sDesigner += "\t\t\t}//if (disposing && (componets != null))" + Environment.NewLine;//}
                sDesigner += "\t\t\tbase.Dispose(disposig);" + Environment.NewLine;//dispose
                sDesigner += "\t\t}" + Environment.NewLine + Environment.NewLine;//}

                //region window form designer generated code

                sDesigner += "\t\t#region Windows Form Desiger generated code" + Environment.NewLine + Environment.NewLine;//region
                sDesigner += "\t\t/// <summary>" + Environment.NewLine;
                sDesigner += "\t\t/// Required method for Designer support - do not modify" + Environment.NewLine;
                sDesigner += "\t\t/// the contents of this method with the code editor." + Environment.NewLine;
                sDesigner += "\t\t/// </summary>" + Environment.NewLine;

                sDesigner += "\t\tprivate void InitilalizeComponent()" + Environment.NewLine;
                sDesigner += "\t\t{" + Environment.NewLine;

                foreach (string sButton in sButtonsToMake)
                {
                    if (sButton != "")
                    {
                        sDesigner += "\t\t\tthis.Show" + sButton.TrimStart('/', '\t') + " = new System.Windows.Forms.Button();\n";
                    }
                }
                int iPoint = 0;
                int iIndex = 0;
                foreach (string sButton in sButtonsToMake)
                {

                    if (sButton != "")
                    {

                        sDesigner += "\t\t\t//\n";
                        sDesigner += "\t\t\t//Show" + sButton.TrimStart('/', '\t') + "\n";
                        sDesigner += "\t\t\t//\n";
                        sDesigner += "\t\t\tthis.Show" + sButton.TrimStart('/', '\t') + ".Location = new System.Drawing.Point(0," + iPoint.ToString() + ");\n";
                        sDesigner += "\t\t\tthis.Show" + sButton.TrimStart('/', '\t') + ".Name = \"" + sButton + "\";\n";
                        sDesigner += "\t\t\tthis.Show" + sButton.TrimStart('/', '\t') + ".Size = new System.Drawing.Size(75, 23);\n";
                        sDesigner += "\t\t\tthis.Show" + sButton.TrimStart('/', '\t') + ".TabIndex = " + iIndex.ToString() + ";\n";
                        sDesigner += "\t\t\tthis.Show" + sButton.TrimStart('/', '\t') + ".Text = \"&" + sButton + "\";\n";
                        sDesigner += "\t\t\tthis.Show" + sButton.TrimStart('/', '\t') + ".UseVisualStyleBackColor = true;\n";
                        sDesigner += "\t\t\tthis.Show" + sButton.TrimStart('/', '\t') + ".Click += new System.EventHandler(this." + sButton + "_Click);\n";
                        iPoint += 23;
                    }
                    iIndex++;
                }
                sDesigner += "\t\t\t//\n";
                sDesigner += "\t\t\t//" + sFormName[i].TrimStart('/', '\t') + "\n";
                sDesigner += "\t\t\t//\n";
                sDesigner += "\t\t\tthis.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);\n";
                sDesigner += "\t\t\tthis.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;\n";
                sDesigner += "\t\t\tthis.ClientSize = new System.Drawing.Size(" + iFormWidth[i] + ", " + iFormHeight[i] + ");\n";
                sDesigner += "\t\t\tthis.Text = \"" + sFormName[i] + "\";\n";
                sDesigner += "\t\t\tthis.ControlBox = false;\n";
                foreach (string sButton in sButtonsToMake)
                {
                    if (sButton != "")
                    {
                        sDesigner += "\t\t\tthis.Controls.Add(this." + sButton + ");\n";
                    }
                }//foreach (string sButton in sButtonsToMake)

                sDesigner += "\t\t\tthis.Name = \"" + sFormName[i].TrimStart('/', '\t') + "\";\n";
                sDesigner += "\t\t\tthis.Text = \"" + sFormName[i].TrimStart('/', '\t') + "\";\n";
                sDesigner += "\t\t\tthis.Load += new System.EventHandler(this." + sFormName[i].TrimStart('/', '\t') + "_Load);\n";
                sDesigner += "\t\t\tthis.ResumeLayout(false);\n";
                sDesigner += "\t\t}" + Environment.NewLine + Environment.NewLine;
                sDesigner += "\t\t#endregion" + Environment.NewLine + Environment.NewLine;
                foreach (string sButton in sButtonsToMake)
                {
                    if (sButton != "")
                    {
                        sDesigner += "\t\tprivate System.Windows.Forms.Button Show" + sButton.TrimStart('/', '\t') + ";\n";
                    }
                }//foreach (string sButton in sButtonsToMake)
                sDesigner += "\t}\n";
                sDesigner += "}";

                fsStream = new FileStream(sFilePath + "\\" + sProjectName.TrimEnd('\r') + "\\" + sFormName[i].TrimStart('/', '\t') + " Designer.cs", FileMode.Create, FileAccess.Write);//file stream
                swWrite = new StreamWriter(fsStream);//stream writer

                swWrite.Write(sDesigner);//write the form
                swWrite.Close();
                fsStream.Close();
                #endregion

                #region Form.resx

                #endregion

                if (i == 0)
                {
                    Guid gProjectGUID = Guid.NewGuid();//guid
                    Guid gProjectIDGUID = Guid.NewGuid();//guid
                    #region AssemblyInfo.cs

                    string sAssemblyInfo = "";

                    sAssemblyInfo += "using System.Reflection;\n";
                    sAssemblyInfo += "using System.Runtime.CompilerServices;\n";
                    sAssemblyInfo += "using System.Runtime.InteropServices;\n\n";

                    sAssemblyInfo += "// General Information about an assembly is controlled through the following\n";
                    sAssemblyInfo += "// set of attributes. Change these attribute values to modify the information\n";
                    sAssemblyInfo += "// associated with an assembly.\n";
                    sAssemblyInfo += "[assembly: AssemblyTitle(\"" + sProjectName + "\")]\n";
                    sAssemblyInfo += "[assembly: AssemblyDescription(\"\")]\n";
                    sAssemblyInfo += "[assembly: AssemblyConfiguration(\"\")]\n";
                    sAssemblyInfo += "[assembly: AssemblyCompany(\"" + sCompanyname + "\")]\n";
                    sAssemblyInfo += "[assembly: AssemblyProduct(\"" + sProjectName + "\")]\n";
                    sAssemblyInfo += "[assembly: AssemblyCopyright(\"Copyright ©  " + System.DateTime.Today.Year + "\")]\n";
                    sAssemblyInfo += "[assembly: AssemblyTrademark(\"\")]\n";
                    sAssemblyInfo += "[assembly: AssemblyCulture(\"\")]\n\n";

                    sAssemblyInfo += "// Setting ComVisible to false makes the types in this assembly not visible \n";
                    sAssemblyInfo += "// to COM components.  If you need to access a type in this assembly from \n";
                    sAssemblyInfo += "// COM, set the ComVisible attribute to true on that type.\n";
                    sAssemblyInfo += "[assembly: ComVisible(false)]\n\n";
                    Guid g = Guid.NewGuid(); 
                    sAssemblyInfo += "// The following GUID is for the ID of the typelib if this project is exposed to COM\n";
                    sAssemblyInfo += "[assembly: Guid(\"" + g.ToString() + "\")]\n\n";

                    sAssemblyInfo += "// Version information for an assembly consists of the following four values:\n";
                    sAssemblyInfo += "//\n";
                    sAssemblyInfo += "//      Major Version\n";
                    sAssemblyInfo += "//      Minor Version \n";
                    sAssemblyInfo += "//      Build Number\n";
                    sAssemblyInfo += "//      Revision\n";
                    sAssemblyInfo += "//\n";
                    sAssemblyInfo += "// You can specify all the values or you can default the Build and Revision Numbers \n";
                    sAssemblyInfo += "// by using the '*' as shown below:\n";
                    sAssemblyInfo += "// [assembly: AssemblyVersion(\"1.0.*\")]\n";
                    sAssemblyInfo += "[assembly: AssemblyVersion(\"1.0.0.0\")]\n";
                    sAssemblyInfo += "[assembly: AssemblyFileVersion(\"1.0.0.0\")]\n";

                    if (!Directory.Exists(sFilePath + "\\" + sProjectName.TrimEnd('\r')))
                    {
                        Directory.CreateDirectory(sFilePath + "\\" + sProjectName.TrimEnd('\r'));//createfolder
                    }//if (!Directory.Exists(sFilePath + "\\" + "Properties"))
                    if (!Directory.Exists(sFilePath + "\\" + sProjectName.TrimEnd('\r') + "\\Properties"))
                    {
                        Directory.CreateDirectory(sFilePath + "\\" + sProjectName.TrimEnd('\r') + "\\Properties");//createfolder
                    }//if (!Directory.Exists(sFilePath + "\\" + "Properties"))

                    fsStream = new FileStream(sFilePath + "\\" +  sProjectName.TrimEnd('\r')+ "\\Properties\\AssemblyInfo.cs", FileMode.Create, FileAccess.Write);//createfilestream
                    swWrite = new StreamWriter(fsStream);//open stream

                    swWrite.Write(sAssemblyInfo);//writefile

                    swWrite.Close();//close streamwriter
                    fsStream.Close();//close filestream
                    #endregion

                    #region Resources Designer.cs
                    string sResDesign = "";

                    sResDesign += "//------------------------------------------------------------------------------\n";
                    sResDesign += "// <auto-generated>\n";
                    sResDesign += "//     This code was generated by a tool.\n";
                    sResDesign += "//     Runtime Version:4.0.30319.239\n";
                    sResDesign += "//\n";
                    sResDesign += "//     Changes to this file may cause incorrect behavior and will be lost if\n";
                    sResDesign += "//     the code is regenerated.\n";
                    sResDesign += "// </auto-generated>\n";
                    sResDesign += "//------------------------------------------------------------------------------\n\n";

                    sResDesign += "namespace " + sProjectName + ".Properties\n";
                    sResDesign += "{\n\n\n";
                    sResDesign += "\t/// <summary>\n";
                    sResDesign += "\t///   A strongly-typed resource class, for looking up localized strings, etc.\n";
                    sResDesign += "\t/// </summary>\n";
                    sResDesign += "\t// This class was auto-generated by the StronglyTypedResourceBuilder\n";
                    sResDesign += "\t// class via a tool like ResGen or Visual Studio.\n";
                    sResDesign += "\t// To add or remove a member, edit your .ResX file then rerun ResGen\n";
                    sResDesign += "\t// with the /str option, or rebuild your VS project.\n";
                    sResDesign += "\t[global::System.CodeDom.Compiler.GeneratedCodeAttribute(\"System.Resources.Tools.StronglyTypedResourceBuilder\", \"4.0.0.0\")]\n";
                    sResDesign += "\t[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]\n";
                    sResDesign += "\t[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]\n";
                    sResDesign += "\tinternal class Resources\n";
                    sResDesign += "\t{\n";
                    sResDesign += "\n\t\tprivate static global::System.Resources.ResourceManager resourceMan;\n\n";
                    sResDesign += "\t\tprivate static global::System.Globalization.CultureInfo resourceCulture;\n\n";
                    sResDesign += "\t\t[global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute(\"Microsoft.Performance\", \"CA1811:AvoidUncalledPrivateCode\")]\n";
                    sResDesign += "\t\tinternal Resources()\n";
                    sResDesign += "\t\t{\n";
                    sResDesign += "\t\t}\n\n";
                    sResDesign += "\t\t/// <summary>\n";
                    sResDesign += "\t\t///   Returns the cached ResourceManager instance used by this class.\n";
                    sResDesign += "\t\t/// </summary>\n";
                    sResDesign += "\t\t[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]\n";
                    sResDesign += "\t\tinternal static global::System.Resources.ResourceManager ResourceManager\n";
                    sResDesign += "\t\t{\n";
                    sResDesign += "\t\t\tget\n";
                    sResDesign += "\t\t\t{\n";
                    sResDesign += "\t\t\t\tif ((resourceMan == null))\n";
                    sResDesign += "\t\t\t\t{\n";
                    sResDesign += "\t\t\t\t\tglobal::System.Resources.ResourceManager tesmp = new global::System.Resources.ResourceManager(\"" + sProjectName + ".Properties.Resources\", typeof(Resources).Assembly);\n";
                    sResDesign += "\t\t\t\t\tresourceMan = temp;\n";
                    sResDesign += "\t\t\t\t}\n";
                    sResDesign += "\t\t\t\treturn resourceMan;\n";
                    sResDesign += "\t\t\t}\n";
                    sResDesign += "\t\t}\n\n";
                    sResDesign += "\t\t/// <summary>\n";
                    sResDesign += "\t\t///   Overrides the current thread's CurrentUICulture property for all\n";
                    sResDesign += "\t\t///   resource lookups using this strongly typed resource class.\n";
                    sResDesign += "\t\t/// </summary>\n";
                    sResDesign += "\t\t[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]\n";
                    sResDesign += "\t\tinternal static global::System.Globalization.CultureInfo Culture\n";
                    sResDesign += "\t\t{\n";
                    sResDesign += "\t\t\tget\n";
                    sResDesign += "\t\t\t{\n";
                    sResDesign += "\t\t\t\treturn resourceCulture;\n";
                    sResDesign += "\t\t\t}\n";
                    sResDesign += "\t\t\tset\n";
                    sResDesign += "\t\t\t{\n";
                    sResDesign += "\t\t\t\tresourceCulture = value;\n";
                    sResDesign += "\t\t\t}\n";
                    sResDesign += "\t\t}\n";
                    sResDesign += "\t}\n";
                    sResDesign += "}";

                    fsStream = new FileStream(sFilePath + "\\" + sProjectName.TrimEnd('\r') + "\\Properties\\Resources.Designer.cs", FileMode.Create, FileAccess.Write);//createfilestream
                    swWrite = new StreamWriter(fsStream);//open stream

                    swWrite.Write(sResDesign);//writefile

                    swWrite.Close();//close streamwriter
                    fsStream.Close();//close filestream
                    #endregion
                  
                    #region Project.csproj
                    string sCSProj = "";
                    sCSProj += "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n";
                    sCSProj += "<Project ToolsVersion=\"4.0\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">\n";
                    sCSProj += "  <PropertyGroup>\n";
                    sCSProj += "    <Configuration Condition=\" \'$(Configuration)\' == \'\' \">Debug</Configuration>\n";
                    sCSProj += "    <Platform Condition=\" \'$(Platform)\' == \'\' \">x86</Platform>\n";
                    sCSProj += "    <ProductVersion>8.0.30703</ProductVersion>\n";
                    sCSProj += "    <SchemaVersion>2.0</SchemaVersion>\n";
                    sCSProj += "    <ProjectGuid>{" + gProjectGUID.ToString().ToUpper() + "}</ProjectGuid>\n";
                    sCSProj += "    <OutputType>WinExe</OutputType>\n";
                    sCSProj += "    <AppDesignerFolder>Properties</AppDesignerFolder>\n";
                    sCSProj += "    <RootNamespace>" + sProjectName + "</RootNamespace>\n";
                    sCSProj += "    <AssemblyName>" + sProjectName + "</AssemblyName>\n";
                    sCSProj += "    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>\n";
                    sCSProj += "    <TargetFrameworkProfile>Client</TargetFrameworkProfile>\n";
                    sCSProj += "    <FileAlignment>512</FileAlignment>\n";
                    sCSProj += "  </PropertyGroup>\n";
                    sCSProj += "  <PropertyGroup Condition=\" \'$(Configuration)|$(Platform)\' == \'Debug|x86\' \">\n";
                    sCSProj += "    <PlatformTarget>x86</PlatformTarget>\n";
                    sCSProj += "    <DebugSymbols>true</DebugSymbols>\n";
                    sCSProj += "    <DebugType>full</DebugType>\n";
                    sCSProj += "    <Optimize>false</Optimize>\n";
                    sCSProj += "    <OutputPath>bin\\Debug\\</OutputPath>\n";
                    sCSProj += "    <DefineConstants>DEBUG;TRACE</DefineConstants>\n";
                    sCSProj += "    <ErrorReport>prompt</ErrorReport>\n";
                    sCSProj += "    <WarningLevel>4</WarningLevel>\n";
                    sCSProj += "  </PropertyGroup>\n";
                    sCSProj += "  <PropertyGroup Condition=\" \'$(Configuration)|$(Platform)\' == \'Release|x86\' \">\n";
                    sCSProj += "    <PlatformTarget>x86</PlatformTarget>\n";
                    sCSProj += "    <DebugType>pdbonly</DebugType>\n";
                    sCSProj += "    <Optimize>true</Optimize>\n";
                    sCSProj += "    <OutputPath>bin\\Release\\</OutputPath>\n";
                    sCSProj += "    <DefineConstants>TRACE</DefineConstants>\n";
                    sCSProj += "    <ErrorReport>prompt</ErrorReport>\n";
                    sCSProj += "    <WarningLevel>4</WarningLevel>\n";
                    sCSProj += "  </PropertyGroup>\n";
                    sCSProj += "  <ItemGroup>\n";
                    sCSProj += "    <Reference Include=\"Microsoft.VisualBasic\" />\n";
                    sCSProj += "    <Reference Include=\"System\" />\n";
                    sCSProj += "    <Reference Include=\"System.Core\" />\n";
                    sCSProj += "    <Reference Include=\"System.Xml.Linq\" />\n";
                    sCSProj += "    <Reference Include=\"System.Data.DataSetExtensions\" />\n";
                    sCSProj += "    <Reference Include=\"Microsoft.CSharp\" />\n";
                    sCSProj += "    <Reference Include=\"System.Data\" />\n";
                    sCSProj += "    <Reference Include=\"System.Deployment\" />\n";
                    sCSProj += "    <Reference Include=\"System.Drawing\" />\n";
                    sCSProj += "    <Reference Include=\"System.Windows.Forms\" />\n";
                    sCSProj += "    <Reference Include=\"System.Xml\" />\n";
                    sCSProj += "  </ItemGroup>\n";
                    sCSProj += "  <ItemGroup>\n";
                    foreach (string sFormNamed in sFormName)
                    {
                        string sFormToUse = sFormNamed.TrimStart('/', '\t');
                        sCSProj += "    <Compile Include=\"" + sFormToUse + ".cs\">\n";
                        sCSProj += "      <SubType>Form</SubType>\n";
                        sCSProj += "    </Compile>\n";
                        sCSProj += "    <Compile Include=\"" + sFormToUse + ".Designer.cs\">\n";
                        sCSProj += "      <DependentUpon>" + sFormToUse + ".cs</DependentUpon>\n";
                        sCSProj += "    </Compile>\n";
                        sCSProj += "    <EmbeddedResource Include=\"" + sFormToUse + ".resx\">\n";
                        sCSProj += "      <DependentUpon>" + sFormToUse + ".cs</DependentUpon>\n";
                        sCSProj += "    </EmbeddedResource>\n";
                    }//foreach (string sFormNamed in sFormName)
                    sCSProj += "    <Compile Include=\"Program.cs\" />\n";
                    sCSProj += "    <Compile Include=\"Properties\\AssemblyInfo.cs\" />\n";
                    sCSProj += "    <EmbeddedResource Include=\"Properties\\Resources.resx\">\n";
                    sCSProj += "      <Generator>ResXFileCodeGenerator</Generator>\n";
                    sCSProj += "      <LastGenOutput>Resources.Designer.cs</LastGenOutput>\n";
                    sCSProj += "      <SubType>Designer</SubType>\n";
                    sCSProj += "    </EmbeddedResource>\n";
                    sCSProj += "    <Compile Include=\"Properties\\Resources.Designer.cs\">\n";
                    sCSProj += "      <AutoGen>True</AutoGen>\n";
                    sCSProj += "      <DependentUpon>Resources.resx</DependentUpon>\n";
                    sCSProj += "    </Compile>\n";
                    sCSProj += "    <None Include=\"Properties\\Settings.settings\">\n";
                    sCSProj += "      <Generator>SettingsSingleFileGenerator</Generator>\n";
                    sCSProj += "      <LastGenOutput>Settings.Designer.cs</LastGenOutput>\n";
                    sCSProj += "    </None>\n";
                    sCSProj += "    <Compile Include=\"Properties\\Settings.Designer.cs\">\n";
                    sCSProj += "      <AutoGen>True</AutoGen>\n";
                    sCSProj += "      <DependentUpon>Settings.settings</DependentUpon>\n";
                    sCSProj += "      <DesignTimeSharedInput>True</DesignTimeSharedInput>\n";
                    sCSProj += "    </Compile>\n";
                    sCSProj += "  </ItemGroup>\n";
                    sCSProj += "  <Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />\n";
                    sCSProj += "  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. \n";
                    sCSProj += "       Other similar extension points exist, see Microsoft.Common.targets.\n";
                    sCSProj += "  <Target Name=\"BeforeBuild\">\n";
                    sCSProj += "  </Target>\n";
                    sCSProj += "  <Target Name=\"AfterBuild\">\n";
                    sCSProj += "  </Target>\n";
                    sCSProj += "  -->\n";
                    sCSProj += "</Project>\n";

                    fsStream = new FileStream(sFilePath + "\\" + sProjectName.TrimEnd('\r') + "\\" + sProjectName + ".csproj", FileMode.Create, FileAccess.Write);//createfilestream
                    swWrite = new StreamWriter(fsStream);//open stream

                    swWrite.Write(sCSProj);//writefile

                    swWrite.Close();//close streamwriter
                    fsStream.Close();//close filestream
                    #endregion

                    #region Program.cs
                    string sProgram = "";

                    sProgram += "using System;\n";
                    sProgram += "using System.Collections.Generic;\n";
                    sProgram += "using System.Linq;\n";
                    sProgram += "using System.Windows.Forms;\n\n";
                    sProgram += "namespace " + sProjectName + "\n";
                    sProgram += "{\n";
                    sProgram += "\tstatic class Program\n";
                    sProgram += "\t{\n";
                    sProgram += "\t\t/// <summary>\n";
                    sProgram += "\t\t/// The main entry point for the application.\n";
                    sProgram += "\t\t/// </summary>\n";
                    sProgram += "\t\t[STAThread]\n";
                    sProgram += "\t\tstatic void Main()\n";
                    sProgram += "\t\t{\n";
                    sProgram += "\t\t\tApplication.EnableVisualStyles();\n";
                    sProgram += "\t\t\tApplication.SetCompatibleTextRenderingDefault(false);\n";
                    sProgram += "\t\t\tApplication.Run(new " + sFormName[0].ToString() + "());\n";
                    sProgram += "\t\t}\n";
                    sProgram += "\t}\n";
                    sProgram += "}";

                    fsStream = new FileStream(sFilePath + "\\" + sProjectName.TrimEnd('\r') + "\\Program.cs", FileMode.Create, FileAccess.Write);//createfilestream
                    swWrite = new StreamWriter(fsStream);//open stream

                    swWrite.Write(sProgram);//writefile

                    swWrite.Close();//close streamwriter
                    fsStream.Close();//close filestream
                    #endregion

                    #region Resources.Design.cs

                    #endregion

                    #region Settings.Designer.cs

                    string sSettingDesign = "";
                    sSettingDesign += "//------------------------------------------------------------------------------\n";
                    sSettingDesign += "// <auto-generated>\n";
                    sSettingDesign += "//     This code was generated by a tool.\n";
                    sSettingDesign += "//     Runtime Version:4.0.30319.239\n";
                    sSettingDesign += "//\n";
                    sSettingDesign += "//     Changes to this file may cause incorrect behavior and will be lost if\n";
                    sSettingDesign += "//     the code is regenerated.\n";
                    sSettingDesign += "// </auto-generated>\n";
                    sSettingDesign += "//------------------------------------------------------------------------------\n\n";

                    sSettingDesign += "namespace " + sProjectName + ".Properties\n";
                    sSettingDesign += "{\n\n\n";
                    sSettingDesign += "\t[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]\n";
                    sSettingDesign += "\t[global::System.CodeDom.Compiler.GeneratedCodeAttribute(\"Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator\", \"10.0.0.0\")]\n";
                    sSettingDesign+= "\tinternal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase\n";
                    sSettingDesign += "\t{\n\n";
                    sSettingDesign += "\t\tprivate static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));\n\n";
                    sSettingDesign += "\t\tpublic static Settings Default\n";
                    sSettingDesign += "\t\t{\n";
                    sSettingDesign += "\t\t\tget\n";
                    sSettingDesign += "\t\t\t{\n";
                    sSettingDesign += "\t\t\t\treturn defaultInstance;\n";
                    sSettingDesign += "\t\t\t}\n";
                    sSettingDesign += "\t\t}\n";
                    sSettingDesign += "\t}\n";
                    sSettingDesign += "}";

                    fsStream = new FileStream(sFilePath + "\\" + sProjectName.TrimEnd('\r') + "\\Properties\\Settings.Designer.cs", FileMode.Create, FileAccess.Write);//createfilestream
                    swWrite = new StreamWriter(fsStream);//open stream

                    swWrite.Write(sSettingDesign);//writefile

                    swWrite.Close();//close streamwriter
                    fsStream.Close();//close filestream
                    #endregion

                    #region Settings.settings


                    string sSettings = "";
                    sSettings += "<?xml version=\'1.0\' encoding=\'utf-8\'?>\n";
                    sSettings += "<SettingsFile xmlns=\"http://schemas.microsoft.com/VisualStudio/2004/01/settings\" CurrentProfile=\"(Default)\">\n";
                    sSettings += "  <Profiles>\n";
                    sSettings += "    <Profile Name=\"(Default)\" />\n";
                    sSettings += "  </Profiles>\n";
                    sSettings += "  <Settings />\n";
                    sSettings += "</SettingsFile>";

                    fsStream = new FileStream(sFilePath + "\\" + sProjectName.TrimEnd('\r') + "\\Properties\\Settings.settings", FileMode.Create, FileAccess.Write);//createfilestream
                    swWrite = new StreamWriter(fsStream);//open stream

                    swWrite.Write(sSettings);//writefile

                    swWrite.Close();//close streamwriter
                    fsStream.Close();//close filestream
                    #endregion

                    #region Project.sln
                    string sProjectSln = "";
                    sProjectSln += "\nMicrosoft Visual Studio Solution File, Format Version 11.00\n";
                    sProjectSln += "# Visual Studio 2010\n";
                    sProjectSln += "Project(\"{" + gProjectIDGUID.ToString() + "}\") = \"" + sProjectName + "\", \"" + sProjectName + "\\" + sProjectName +".csproj\", \"{" + gProjectGUID + "}\"\n";
                    sProjectSln += "EndProject\n";
                    sProjectSln += "Global\n";
                    sProjectSln += "\tGlobalSection(SolutionConfigurationPlatforms) = preSolution\n";
                    sProjectSln += "\t\tDebug|x86 = Debug|x86\n";
                    sProjectSln += "\t\tRelease|x86 = Release|x86\n";
                    sProjectSln += "\tEndGlobalSection\n";
                    sProjectSln += "\tGlobalSection(ProjectConfigurationPlatforms) = postSolution\n";
                    sProjectSln += "\t\t{" + gProjectGUID.ToString() + "}.Debug|x86.ActiveCfg = Debug|x86\n";
                    sProjectSln += "\t\t{" + gProjectGUID.ToString() + "}.Debug|x86.Build.0 = Debug|x86\n";
                    sProjectSln += "\t\t{" + gProjectGUID.ToString() + "}.Release|x86.ActiveCfg = Release|x86\n";
                    sProjectSln += "\t\t{" + gProjectGUID.ToString() + "}.Release|x86.Build.0 = Release|x86\n";
                    sProjectSln += "\tEndGlobalSection\n";
                    sProjectSln += "\tGlobalSection(SolutionProperties) = preSolution\n";
                    sProjectSln += "\t\tHideSolutionNode = FALSE\n";
                    sProjectSln += "\tEndGlobalSection\n";
                    sProjectSln += "EndGlobal";

                    fsStream = new FileStream(sFilePath + "\\" + sProjectName + ".sln", FileMode.Create, FileAccess.Write);//createfilestream
                    swWrite = new StreamWriter(fsStream);//open stream

                    swWrite.Write(sProjectSln);//writefile

                    swWrite.Close();//close streamwriter
                    fsStream.Close();//close filestream
                    #endregion
                }//if (i == 0)
            }//for (int i = 1; i < iFormAmount; i++)
        }//GeerateApplication()

        public static string[] GetButtonNames(int iFormID, int?[] iFormsLinkedID, string[] sFormNames)
        {
            string sForms = "";//ames of forms

            for (int i = 0; i < iFormsLinkedID.Count(); i++)
            {
                if (iFormsLinkedID[i] == iFormID && iFormsLinkedID[i] != null)
                {
                    sForms += " " + sFormNames[i].TrimStart('/', '\t');//add form nameto this
                }// if (iFormsLinkedID[i] == iFormID && iFormsLinkedID[i] != null)
            }//for (int i = 0; i < iFormsLinkedID.Count(); i++)
            return sForms.Split(' ');//split forms
        }//GetButtonNames()
    }//class
}//namespace
