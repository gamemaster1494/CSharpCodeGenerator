namespace CodeGenerator
{
    partial class frmCodeHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeHelp));
            this.bntClose = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(12, 142);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(75, 23);
            this.bntClose.TabIndex = 0;
            this.bntClose.Text = "&Close";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(12, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(261, 130);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = resources.GetString("lblInformation.Text");
            // 
            // frmCodeHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 169);
            this.ControlBox = false;
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.bntClose);
            this.Name = "frmCodeHelp";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Label lblInformation;
    }
}