﻿namespace Practica_7_U_3
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Desicion_Click = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 63);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Longitud lado A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 104);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Longitud lado B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 144);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Longitud lado C";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // Desicion_Click
            // 
            Desicion_Click.Location = new Point(42, 205);
            Desicion_Click.Name = "Desicion_Click";
            Desicion_Click.Size = new Size(75, 23);
            Desicion_Click.TabIndex = 6;
            Desicion_Click.Text = "Decision";
            Desicion_Click.UseVisualStyleBackColor = true;
            Desicion_Click.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(134, 205);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(231, 205);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 262);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 9;
            label4.Text = "Tipo Triangulo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(153, 254);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Desicion_Click);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Desicion_Click;
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox textBox4;
    }
}