namespace PRG1_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_0 = new Button();
            btn_comma = new Button();
            btn_equal = new Button();
            btn_plus = new Button();
            btn_minus = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_divided = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            txtB_Show = new TextBox();
            btn_PlusMinus = new Button();
            btn_multiply = new Button();
            btn_clear = new Button();
            btn_storeInMemory = new Button();
            btn_catchFromMemory = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btn_1, 0, 4);
            tableLayoutPanel1.Controls.Add(btn_2, 1, 4);
            tableLayoutPanel1.Controls.Add(btn_3, 2, 4);
            tableLayoutPanel1.Controls.Add(btn_0, 1, 5);
            tableLayoutPanel1.Controls.Add(btn_comma, 2, 5);
            tableLayoutPanel1.Controls.Add(btn_equal, 3, 5);
            tableLayoutPanel1.Controls.Add(btn_plus, 3, 4);
            tableLayoutPanel1.Controls.Add(btn_minus, 3, 3);
            tableLayoutPanel1.Controls.Add(btn_6, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_5, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_4, 0, 3);
            tableLayoutPanel1.Controls.Add(btn_divided, 3, 2);
            tableLayoutPanel1.Controls.Add(btn_9, 2, 2);
            tableLayoutPanel1.Controls.Add(btn_8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_7, 0, 2);
            tableLayoutPanel1.Controls.Add(txtB_Show, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_PlusMinus, 0, 5);
            tableLayoutPanel1.Controls.Add(btn_multiply, 3, 1);
            tableLayoutPanel1.Controls.Add(btn_clear, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_storeInMemory, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_catchFromMemory, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(369, 496);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_1
            // 
            btn_1.Dock = DockStyle.Fill;
            btn_1.Font = new Font("Microsoft Sans Serif", 12F);
            btn_1.Location = new Point(3, 331);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(86, 76);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += NumberButton_Click;
            // 
            // btn_2
            // 
            btn_2.Dock = DockStyle.Fill;
            btn_2.Font = new Font("Microsoft Sans Serif", 12F);
            btn_2.Location = new Point(95, 331);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(86, 76);
            btn_2.TabIndex = 1;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += NumberButton_Click;
            // 
            // btn_3
            // 
            btn_3.Dock = DockStyle.Fill;
            btn_3.Font = new Font("Microsoft Sans Serif", 12F);
            btn_3.Location = new Point(187, 331);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(86, 76);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += NumberButton_Click;
            // 
            // btn_0
            // 
            btn_0.Dock = DockStyle.Fill;
            btn_0.Font = new Font("Microsoft Sans Serif", 12F);
            btn_0.Location = new Point(95, 413);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(86, 80);
            btn_0.TabIndex = 9;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += NumberButton_Click;
            // 
            // btn_comma
            // 
            btn_comma.Dock = DockStyle.Fill;
            btn_comma.Font = new Font("Microsoft Sans Serif", 12F);
            btn_comma.Location = new Point(187, 413);
            btn_comma.Name = "btn_comma";
            btn_comma.Size = new Size(86, 80);
            btn_comma.TabIndex = 15;
            btn_comma.Text = ",";
            btn_comma.UseVisualStyleBackColor = true;
            // 
            // btn_equal
            // 
            btn_equal.Dock = DockStyle.Fill;
            btn_equal.Font = new Font("Microsoft Sans Serif", 12F);
            btn_equal.Location = new Point(279, 413);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(87, 80);
            btn_equal.TabIndex = 14;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_plus
            // 
            btn_plus.Dock = DockStyle.Fill;
            btn_plus.Font = new Font("Microsoft Sans Serif", 12F);
            btn_plus.Location = new Point(279, 331);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(87, 76);
            btn_plus.TabIndex = 10;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += OperatorButton_Click;
            // 
            // btn_minus
            // 
            btn_minus.Dock = DockStyle.Fill;
            btn_minus.Font = new Font("Microsoft Sans Serif", 12F);
            btn_minus.Location = new Point(279, 249);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(87, 76);
            btn_minus.TabIndex = 11;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += OperatorButton_Click;
            // 
            // btn_6
            // 
            btn_6.Dock = DockStyle.Fill;
            btn_6.Font = new Font("Microsoft Sans Serif", 12F);
            btn_6.Location = new Point(187, 249);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(86, 76);
            btn_6.TabIndex = 5;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += NumberButton_Click;
            // 
            // btn_5
            // 
            btn_5.Dock = DockStyle.Fill;
            btn_5.Font = new Font("Microsoft Sans Serif", 12F);
            btn_5.Location = new Point(95, 249);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(86, 76);
            btn_5.TabIndex = 4;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += NumberButton_Click;
            // 
            // btn_4
            // 
            btn_4.Dock = DockStyle.Fill;
            btn_4.Font = new Font("Microsoft Sans Serif", 12F);
            btn_4.Location = new Point(3, 249);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(86, 76);
            btn_4.TabIndex = 3;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += NumberButton_Click;
            // 
            // btn_divided
            // 
            btn_divided.Dock = DockStyle.Fill;
            btn_divided.Font = new Font("Microsoft Sans Serif", 12F);
            btn_divided.Location = new Point(279, 167);
            btn_divided.Name = "btn_divided";
            btn_divided.Size = new Size(87, 76);
            btn_divided.TabIndex = 12;
            btn_divided.Text = "/";
            btn_divided.UseVisualStyleBackColor = true;
            btn_divided.Click += OperatorButton_Click;
            // 
            // btn_9
            // 
            btn_9.Dock = DockStyle.Fill;
            btn_9.Font = new Font("Microsoft Sans Serif", 12F);
            btn_9.Location = new Point(187, 167);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(86, 76);
            btn_9.TabIndex = 8;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += NumberButton_Click;
            // 
            // btn_8
            // 
            btn_8.Dock = DockStyle.Fill;
            btn_8.Font = new Font("Microsoft Sans Serif", 12F);
            btn_8.Location = new Point(95, 167);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(86, 76);
            btn_8.TabIndex = 7;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += NumberButton_Click;
            // 
            // btn_7
            // 
            btn_7.Dock = DockStyle.Fill;
            btn_7.Font = new Font("Microsoft Sans Serif", 12F);
            btn_7.Location = new Point(3, 167);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(86, 76);
            btn_7.TabIndex = 6;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += NumberButton_Click;
            // 
            // txtB_Show
            // 
            txtB_Show.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtB_Show, 4);
            txtB_Show.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB_Show.Location = new Point(10, 21);
            txtB_Show.Margin = new Padding(10, 3, 10, 3);
            txtB_Show.Name = "txtB_Show";
            txtB_Show.Size = new Size(349, 39);
            txtB_Show.TabIndex = 15;
            txtB_Show.Text = "0";
            txtB_Show.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_PlusMinus
            // 
            btn_PlusMinus.Dock = DockStyle.Fill;
            btn_PlusMinus.Font = new Font("Microsoft Sans Serif", 12F);
            btn_PlusMinus.Location = new Point(3, 413);
            btn_PlusMinus.Name = "btn_PlusMinus";
            btn_PlusMinus.Size = new Size(86, 80);
            btn_PlusMinus.TabIndex = 17;
            btn_PlusMinus.Text = "-/+";
            btn_PlusMinus.UseVisualStyleBackColor = true;
            // 
            // btn_multiply
            // 
            btn_multiply.Dock = DockStyle.Fill;
            btn_multiply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_multiply.Location = new Point(279, 85);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(87, 76);
            btn_multiply.TabIndex = 13;
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += OperatorButton_Click;
            // 
            // btn_clear
            // 
            btn_clear.Dock = DockStyle.Fill;
            btn_clear.Location = new Point(187, 85);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(86, 76);
            btn_clear.TabIndex = 16;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_storeInMemory
            // 
            btn_storeInMemory.Dock = DockStyle.Fill;
            btn_storeInMemory.Location = new Point(95, 85);
            btn_storeInMemory.Name = "btn_storeInMemory";
            btn_storeInMemory.Size = new Size(86, 76);
            btn_storeInMemory.TabIndex = 18;
            btn_storeInMemory.Text = "Lagra";
            btn_storeInMemory.UseVisualStyleBackColor = true;
            btn_storeInMemory.Click += btn_storeInMemory_Click;
            // 
            // btn_catchFromMemory
            // 
            btn_catchFromMemory.Dock = DockStyle.Fill;
            btn_catchFromMemory.Location = new Point(3, 85);
            btn_catchFromMemory.Name = "btn_catchFromMemory";
            btn_catchFromMemory.Size = new Size(86, 76);
            btn_catchFromMemory.TabIndex = 19;
            btn_catchFromMemory.Text = "Hämta";
            btn_catchFromMemory.UseVisualStyleBackColor = true;
            btn_catchFromMemory.Click += btn_catchFromMemory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 496);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_0;
        private Button btn_comma;
        private Button btn_equal;
        private Button btn_plus;
        private Button btn_minus;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_divided;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private TextBox txtB_Show;
        private Button btn_PlusMinus;
        private Button btn_multiply;
        private Button btn_clear;
        private Button btn_storeInMemory;
        private Button btn_catchFromMemory;
    }
}
