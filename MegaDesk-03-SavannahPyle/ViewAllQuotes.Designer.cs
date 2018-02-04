namespace MegaDesk_03_SavannahPyle
{
    partial class ViewAllQuotes
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
            this.exitView = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitView
            // 
            this.exitView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitView.Location = new System.Drawing.Point(65, 38);
            this.exitView.Name = "exitView";
            this.exitView.Size = new System.Drawing.Size(103, 48);
            this.exitView.TabIndex = 0;
            this.exitView.Text = "EXIT";
            this.exitView.UseVisualStyleBackColor = true;
            this.exitView.Click += new System.EventHandler(this.exitView_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(65, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(932, 304);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 714);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exitView);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitView;
        private System.Windows.Forms.ListBox listBox1;
    }
}