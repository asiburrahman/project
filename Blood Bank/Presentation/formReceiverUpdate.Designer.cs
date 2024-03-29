﻿namespace Blood_Bank.Presentation
{
    partial class formReceiverUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReceiverUpdate));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBlood = new System.Windows.Forms.ComboBox();
            this.textBoxFacebook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(220, 260);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 60);
            this.buttonExit.TabIndex = 39;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(92, 260);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 60);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(120, 202);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(175, 52);
            this.textBoxAddress.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Brown;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 40;
            this.label5.Text = "Address";
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMobile.Location = new System.Drawing.Point(120, 164);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(175, 24);
            this.textBoxMobile.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Brown;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Mobile";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxBlood
            // 
            this.comboBoxBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBlood.FormattingEnabled = true;
            this.comboBoxBlood.Items.AddRange(new object[] {
            "O-",
            "O+",
            "A-",
            "A+",
            "B-",
            "B+",
            "AB-",
            "AB+"});
            this.comboBoxBlood.Location = new System.Drawing.Point(120, 86);
            this.comboBoxBlood.Name = "comboBoxBlood";
            this.comboBoxBlood.Size = new System.Drawing.Size(175, 26);
            this.comboBoxBlood.TabIndex = 29;
            // 
            // textBoxFacebook
            // 
            this.textBoxFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFacebook.Location = new System.Drawing.Point(120, 129);
            this.textBoxFacebook.Name = "textBoxFacebook";
            this.textBoxFacebook.Size = new System.Drawing.Size(175, 24);
            this.textBoxFacebook.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Brown;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fb ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Blood Group";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(120, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 24);
            this.textBoxName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(-2, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 31);
            this.label6.TabIndex = 41;
            this.label6.Text = "Receiver update";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formReceiverUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(327, 326);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxBlood);
            this.Controls.Add(this.textBoxFacebook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "formReceiverUpdate";
            this.Text = "formReceiverUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBlood;
        private System.Windows.Forms.TextBox textBoxFacebook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}