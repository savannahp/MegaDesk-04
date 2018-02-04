namespace MegaDesk_03_SavannahPyle
{
    partial class AddQuote
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericDepth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberOfDrawers = new System.Windows.Forms.Label();
            this.drawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.rushDaysUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exitAdd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rushDaysUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(456, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 39);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(362, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width:";
            // 
            // numericWidth
            // 
            this.numericWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericWidth.Location = new System.Drawing.Point(456, 131);
            this.numericWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(287, 39);
            this.numericWidth.TabIndex = 6;
            this.numericWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericWidth.ValueChanged += new System.EventHandler(this.numericWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please Enter Your First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Depth: ";
            // 
            // numericDepth
            // 
            this.numericDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDepth.Location = new System.Drawing.Point(456, 193);
            this.numericDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericDepth.Name = "numericDepth";
            this.numericDepth.Size = new System.Drawing.Size(287, 39);
            this.numericDepth.TabIndex = 9;
            this.numericDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericDepth.ValueChanged += new System.EventHandler(this.numericDepth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Surface Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rush Days:";
            // 
            // numberOfDrawers
            // 
            this.numberOfDrawers.AutoSize = true;
            this.numberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDrawers.Location = new System.Drawing.Point(53, 305);
            this.numberOfDrawers.Name = "numberOfDrawers";
            this.numberOfDrawers.Size = new System.Drawing.Size(272, 32);
            this.numberOfDrawers.TabIndex = 15;
            this.numberOfDrawers.Text = "Number of Drawers: ";
            // 
            // drawersUpDown
            // 
            this.drawersUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersUpDown.Location = new System.Drawing.Point(456, 306);
            this.drawersUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersUpDown.Name = "drawersUpDown";
            this.drawersUpDown.Size = new System.Drawing.Size(287, 39);
            this.drawersUpDown.TabIndex = 16;
            this.drawersUpDown.ValueChanged += new System.EventHandler(this.drawersUpDown_ValueChanged);
            // 
            // rushDaysUpDown
            // 
            this.rushDaysUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDaysUpDown.Location = new System.Drawing.Point(456, 249);
            this.rushDaysUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rushDaysUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rushDaysUpDown.Name = "rushDaysUpDown";
            this.rushDaysUpDown.Size = new System.Drawing.Size(287, 39);
            this.rushDaysUpDown.TabIndex = 17;
            this.rushDaysUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rushDaysUpDown.ValueChanged += new System.EventHandler(this.rushDaysUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "min 24\"; max 96\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "min 12\"; max 48\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "0-7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(307, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "3, 5 or 7 are valid. 10 is for normal shipping";
            // 
            // exitAdd
            // 
            this.exitAdd.AutoSize = true;
            this.exitAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAdd.Location = new System.Drawing.Point(12, 9);
            this.exitAdd.Name = "exitAdd";
            this.exitAdd.Size = new System.Drawing.Size(63, 32);
            this.exitAdd.TabIndex = 22;
            this.exitAdd.Text = "Exit";
            this.exitAdd.Click += new System.EventHandler(this.exitAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.comboBox1.Location = new System.Drawing.Point(456, 369);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 40);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 714);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exitAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rushDaysUpDown);
            this.Controls.Add(this.drawersUpDown);
            this.Controls.Add(this.numberOfDrawers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericDepth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rushDaysUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericDepth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numberOfDrawers;
        private System.Windows.Forms.NumericUpDown drawersUpDown;
        private System.Windows.Forms.NumericUpDown rushDaysUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label exitAdd;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}