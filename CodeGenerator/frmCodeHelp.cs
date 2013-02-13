///frmCodeHelp - CodeGenerator.cs
///Created by Jacob Douglas
///Created on 2/8/2012
///(c) Copyright 2011, Drop 3 Productions
///
///Purpose: Used to aid people in how to use the application
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
    public partial class frmCodeHelp : Form
    {
        public frmCodeHelp()
        {
            InitializeComponent();//initilize components
        }//frmCodeHelp()

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();//close form
        }
    }//class
}//namespace
