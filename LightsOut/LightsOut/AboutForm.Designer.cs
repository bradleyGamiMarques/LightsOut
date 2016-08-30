namespace LightsOut
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lightsOut = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.okayButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lightsOut
            // 
            this.lightsOut.AutoSize = true;
            this.lightsOut.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightsOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lightsOut.Location = new System.Drawing.Point(85, 89);
            this.lightsOut.Name = "lightsOut";
            this.lightsOut.Size = new System.Drawing.Size(118, 29);
            this.lightsOut.TabIndex = 0;
            this.lightsOut.Text = "Lights Out!";
            this.lightsOut.Click += new System.EventHandler(this.label1_Click);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(87, 130);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(101, 13);
            this.author.TabIndex = 1;
            this.author.Text = "By Bradley Marques";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(36, 157);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(221, 13);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Turn all the lights out (black) to win the game!";
            // 
            // okayButton
            // 
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.Location = new System.Drawing.Point(103, 199);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.author);
            this.Controls.Add(this.lightsOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lightsOut;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}