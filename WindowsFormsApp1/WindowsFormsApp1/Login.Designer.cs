namespace WindowsFormsApp1
{
    partial class FormLogin
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelMDP = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.buttonCO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(35, 71);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(69, 17);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Identifiant";
            // 
            // labelMDP
            // 
            this.labelMDP.AutoSize = true;
            this.labelMDP.Location = new System.Drawing.Point(35, 155);
            this.labelMDP.Name = "labelMDP";
            this.labelMDP.Size = new System.Drawing.Size(93, 17);
            this.labelMDP.TabIndex = 1;
            this.labelMDP.Text = "Mot de passe";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(139, 66);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(139, 150);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.PasswordChar = '*';
            this.textBoxMDP.Size = new System.Drawing.Size(100, 22);
            this.textBoxMDP.TabIndex = 3;
            // 
            // buttonCO
            // 
            this.buttonCO.Location = new System.Drawing.Point(139, 212);
            this.buttonCO.Name = "buttonCO";
            this.buttonCO.Size = new System.Drawing.Size(100, 23);
            this.buttonCO.TabIndex = 4;
            this.buttonCO.Text = "Connexion";
            this.buttonCO.UseVisualStyleBackColor = true;
            this.buttonCO.Click += new System.EventHandler(this.buttonCO_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 302);
            this.Controls.Add(this.buttonCO);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelMDP);
            this.Controls.Add(this.labelID);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelMDP;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Button buttonCO;
    }
}