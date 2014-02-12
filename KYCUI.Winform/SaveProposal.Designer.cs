namespace KYCUI.Winform
{
    partial class SaveProposal
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
            this.btnSaveProposal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveProposal
            // 
            this.btnSaveProposal.Location = new System.Drawing.Point(335, 31);
            this.btnSaveProposal.Name = "btnSaveProposal";
            this.btnSaveProposal.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProposal.TabIndex = 0;
            this.btnSaveProposal.Text = "Save Proposal";
            this.btnSaveProposal.UseVisualStyleBackColor = true;
            this.btnSaveProposal.Click += new System.EventHandler(this.btnSaveProposal_Click);
            // 
            // SaveProposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 181);
            this.Controls.Add(this.btnSaveProposal);
            this.Name = "SaveProposal";
            this.Text = "SaveProposal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveProposal;
    }
}