namespace Blood_Bank
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
            this.buttonDonor = new System.Windows.Forms.Button();
            this.buttonReceiver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDonor
            // 
            this.buttonDonor.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonor.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDonor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDonor.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDonor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDonor.Location = new System.Drawing.Point(278, 283);
            this.buttonDonor.Name = "buttonDonor";
            this.buttonDonor.Size = new System.Drawing.Size(75, 43);
            this.buttonDonor.TabIndex = 0;
            this.buttonDonor.Text = "Donor";
            this.buttonDonor.UseVisualStyleBackColor = false;
            this.buttonDonor.Click += new System.EventHandler(this.buttonDonor_Click);
            // 
            // buttonReceiver
            // 
            this.buttonReceiver.BackColor = System.Drawing.Color.Maroon;
            this.buttonReceiver.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceiver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReceiver.Location = new System.Drawing.Point(254, 394);
            this.buttonReceiver.Name = "buttonReceiver";
            this.buttonReceiver.Size = new System.Drawing.Size(123, 52);
            this.buttonReceiver.TabIndex = 1;
            this.buttonReceiver.Text = "Receiver";
            this.buttonReceiver.UseVisualStyleBackColor = false;
            this.buttonReceiver.Click += new System.EventHandler(this.buttonReceiver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 186);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReceiver);
            this.Controls.Add(this.buttonDonor);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Blood Bank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDonor;
        private System.Windows.Forms.Button buttonReceiver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

