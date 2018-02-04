namespace MegaDesk_03_SavannahPyle
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddNewQuote = new System.Windows.Forms.Button();
            this.ViewQuotes = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewQuote
            // 
            this.AddNewQuote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddNewQuote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddNewQuote.FlatAppearance.BorderSize = 9;
            this.AddNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuote.Location = new System.Drawing.Point(74, 59);
            this.AddNewQuote.Name = "AddNewQuote";
            this.AddNewQuote.Padding = new System.Windows.Forms.Padding(5);
            this.AddNewQuote.Size = new System.Drawing.Size(313, 106);
            this.AddNewQuote.TabIndex = 0;
            this.AddNewQuote.Text = "Add New Quote";
            this.AddNewQuote.UseVisualStyleBackColor = false;
            this.AddNewQuote.Click += new System.EventHandler(this.AddNewQuote_Click);
            // 
            // ViewQuotes
            // 
            this.ViewQuotes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotes.Location = new System.Drawing.Point(74, 211);
            this.ViewQuotes.Name = "ViewQuotes";
            this.ViewQuotes.Size = new System.Drawing.Size(313, 106);
            this.ViewQuotes.TabIndex = 1;
            this.ViewQuotes.Text = "View Quotes";
            this.ViewQuotes.UseVisualStyleBackColor = false;
            this.ViewQuotes.Click += new System.EventHandler(this.ViewQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotes.Location = new System.Drawing.Point(74, 348);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(313, 106);
            this.SearchQuotes.TabIndex = 2;
            this.SearchQuotes.Text = "Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = false;
            this.SearchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(74, 493);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(313, 105);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 512);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1035, 714);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.ViewQuotes);
            this.Controls.Add(this.AddNewQuote);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuote;
        private System.Windows.Forms.Button ViewQuotes;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

