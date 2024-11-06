namespace LB5KRPP
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
            groupBox1 = new GroupBox();
            txtX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtY = new TextBox();
            label3 = new Label();
            txtR1 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            btnCheck = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtR1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtY);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtX);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // txtX
            // 
            txtX.Location = new Point(97, 28);
            txtX.Name = "txtX";
            txtX.Size = new Size(120, 23);
            txtX.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Координата X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 2;
            label2.Text = "Координата Y:";
            // 
            // txtY
            // 
            txtY.Location = new Point(97, 57);
            txtY.Name = "txtY";
            txtY.Size = new Size(120, 23);
            txtY.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Радиус r1:";
            // 
            // txtR1
            // 
            txtR1.Location = new Point(96, 88);
            txtR1.Name = "txtR1";
            txtR1.Size = new Size(121, 23);
            txtR1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 120);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "Радиус r2:";
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCheck.Location = new Point(241, 22);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(393, 155);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Запуск программы";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 190);
            Controls.Add(btnCheck);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtR1;
        private Label label3;
        private TextBox txtY;
        private Label label2;
        private Label label1;
        private TextBox txtX;
        private Label label4;
        private TextBox textBox1;
        private Button btnCheck;
    }
}
