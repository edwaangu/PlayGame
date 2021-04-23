
namespace PlayGame
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.OutputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.PlayButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayButton.Location = new System.Drawing.Point(110, 140);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(160, 70);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play the game";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // OutputText
            // 
            this.OutputText.BackColor = System.Drawing.Color.Transparent;
            this.OutputText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputText.Location = new System.Drawing.Point(110, 150);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(160, 70);
            this.OutputText.TabIndex = 1;
            this.OutputText.Text = "Starting in 3...";
            this.OutputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.PlayButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Great Playable Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label OutputText;
    }
}

