namespace ResolutionChanger
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtProcessName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numericWidth = new NumericUpDown();
            numericHeight = new NumericUpDown();
            btnStart = new Button();
            txtStatus = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericHeight).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя процесса:";
            // 
            // txtProcessName
            // 
            txtProcessName.Location = new Point(101, 12);
            txtProcessName.Name = "txtProcessName";
            txtProcessName.Size = new Size(169, 23);
            txtProcessName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Ширина:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Высота:";
            // 
            // numericWidth
            // 
            numericWidth.Location = new Point(101, 41);
            numericWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericWidth.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericWidth.Name = "numericWidth";
            numericWidth.Size = new Size(200, 23);
            numericWidth.TabIndex = 4;
            numericWidth.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericHeight
            // 
            numericHeight.Location = new Point(101, 70);
            numericHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericHeight.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericHeight.Name = "numericHeight";
            numericHeight.Size = new Size(200, 23);
            numericHeight.TabIndex = 5;
            numericHeight.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnStart
            // 
            btnStart.Location = new Point(101, 99);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(200, 30);
            btnStart.TabIndex = 6;
            btnStart.Text = "Начать мониторинг";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(101, 135);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(200, 60);
            txtStatus.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 8;
            label4.Text = "Состояние:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 15);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 9;
            label5.Text = ".exe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 211);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtStatus);
            Controls.Add(btnStart);
            Controls.Add(numericHeight);
            Controls.Add(numericWidth);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProcessName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resolution Changer";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProcessName;
        private Label label2;
        private Label label3;
        private NumericUpDown numericWidth;
        private NumericUpDown numericHeight;
        private Button btnStart;
        private TextBox txtStatus;
        private Label label4;
        private Label label5;
    }
}
