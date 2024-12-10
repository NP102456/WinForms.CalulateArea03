namespace WinForms.CalulateArea
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
            label1 = new Label();
            txtRadius = new TextBox();
            label2 = new Label();
            txtHeight = new TextBox();
            txtWidht = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtHexagonWidth = new TextBox();
            lblResult = new Label();
            label6 = new Label();
            btnCircleArea = new Button();
            butnTriangleArea = new Button();
            btnHexagonArea = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            lblResult2 = new Label();
            lblResult3 = new Label();
            label5 = new Label();
            label7 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 49);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 0;
            label1.Text = "รัศมี";
            // 
            // txtRadius
            // 
            txtRadius.BorderStyle = BorderStyle.FixedSingle;
            txtRadius.Location = new Point(101, 47);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(125, 29);
            txtRadius.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 50);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 2;
            label2.Text = "ความสูง";
            // 
            // txtHeight
            // 
            txtHeight.BorderStyle = BorderStyle.FixedSingle;
            txtHeight.Location = new Point(172, 48);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 29);
            txtHeight.TabIndex = 3;
            // 
            // txtWidht
            // 
            txtWidht.BorderStyle = BorderStyle.FixedSingle;
            txtWidht.Location = new Point(172, 115);
            txtWidht.Name = "txtWidht";
            txtWidht.Size = new Size(125, 29);
            txtWidht.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 115);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 5;
            label3.Text = "ความยาวฐาน";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 78);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 6;
            label4.Text = "ความยาวฐาน";
            // 
            // txtHexagonWidth
            // 
            txtHexagonWidth.BorderStyle = BorderStyle.FixedSingle;
            txtHexagonWidth.Location = new Point(157, 76);
            txtHexagonWidth.Name = "txtHexagonWidth";
            txtHexagonWidth.Size = new Size(125, 29);
            txtHexagonWidth.TabIndex = 7;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(255, 128, 128);
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblResult.ForeColor = Color.FromArgb(0, 0, 192);
            lblResult.Location = new Point(655, 43);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(235, 94);
            lblResult.TabIndex = 8;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(655, 15);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 9;
            label6.Text = "พื้นที่วงกลม";
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(273, 39);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(225, 49);
            btnCircleArea.TabIndex = 10;
            btnCircleArea.Text = "คำนวณพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // butnTriangleArea
            // 
            butnTriangleArea.Location = new Point(340, 65);
            butnTriangleArea.Name = "butnTriangleArea";
            butnTriangleArea.Size = new Size(225, 49);
            butnTriangleArea.TabIndex = 11;
            butnTriangleArea.Text = "คำนวณพื้นที่สามเหลี่ยม";
            butnTriangleArea.UseVisualStyleBackColor = true;
            butnTriangleArea.Click += butnTriangleArea_Click;
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Location = new Point(325, 69);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(225, 49);
            btnHexagonArea.TabIndex = 12;
            btnHexagonArea.Text = "คำนวณพื้นที่รูปหกเหลี่ยม";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Red;
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 155);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่วงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Lime;
            groupBox2.Controls.Add(butnTriangleArea);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(txtWidht);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(28, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(621, 185);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Blue;
            groupBox3.Controls.Add(txtHexagonWidth);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnHexagonArea);
            groupBox3.Location = new Point(28, 364);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(621, 188);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า";
            // 
            // button1
            // 
            button1.Location = new Point(941, 579);
            button1.Name = "button1";
            button1.Size = new Size(91, 48);
            button1.TabIndex = 16;
            button1.Text = "ออก!!!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResult2
            // 
            lblResult2.BackColor = Color.FromArgb(128, 255, 128);
            lblResult2.BorderStyle = BorderStyle.FixedSingle;
            lblResult2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblResult2.ForeColor = Color.FromArgb(0, 0, 192);
            lblResult2.Location = new Point(655, 220);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(235, 94);
            lblResult2.TabIndex = 17;
            lblResult2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult3
            // 
            lblResult3.BackColor = Color.FromArgb(128, 128, 255);
            lblResult3.BorderStyle = BorderStyle.FixedSingle;
            lblResult3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblResult3.ForeColor = Color.FromArgb(0, 0, 192);
            lblResult3.Location = new Point(655, 403);
            lblResult3.Name = "lblResult3";
            lblResult3.Size = new Size(235, 94);
            lblResult3.TabIndex = 18;
            lblResult3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(655, 192);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 19;
            label5.Text = "พื้นที่วงกลม";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(655, 375);
            label7.Name = "label7";
            label7.Size = new Size(101, 21);
            label7.TabIndex = 20;
            label7.Text = "พื้นที่สี่เหลี่ยม";
            // 
            // button2
            // 
            button2.Location = new Point(941, 225);
            button2.Name = "button2";
            button2.Size = new Size(91, 74);
            button2.TabIndex = 21;
            button2.Text = "ล้างค่า";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 639);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(lblResult3);
            Controls.Add(lblResult2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "WinForms.CalculateArea (คำนวณพื้นที่รูปภาพเรขาคณิต)";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRadius;
        private Label label2;
        private TextBox txtHeight;
        private TextBox txtWidht;
        private Label label3;
        private Label label4;
        private TextBox txtHexagonWidth;
        private Label lblResult;
        private Label label6;
        private Button btnCircleArea;
        private Button butnTriangleArea;
        private Button btnHexagonArea;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private Label lblResult2;
        private Label lblResult3;
        private Label label5;
        private Label label7;
        private Button button2;
    }
}
