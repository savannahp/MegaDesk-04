namespace MegaDesk_03_SavannahPyle
{
    partial class DisplayQuote
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
            this.exitDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitDisplay
            // 
            this.exitDisplay.AutoSize = true;
            this.exitDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitDisplay.Location = new System.Drawing.Point(34, 49);
            this.exitDisplay.Name = "exitDisplay";
            this.exitDisplay.Size = new System.Drawing.Size(63, 32);
            this.exitDisplay.TabIndex = 0;
            this.exitDisplay.Text = "Exit";
            this.exitDisplay.Click += new System.EventHandler(this.exitDisplay_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 714);
            this.Controls.Add(this.exitDisplay);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitDisplay;
    }
}