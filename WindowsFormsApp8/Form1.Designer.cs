namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnResultado = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.BtnRest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(25, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(267, 45);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(28, 95);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 34);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(82, 95);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 34);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(136, 95);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 34);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(25, 132);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 34);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(82, 132);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 34);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(136, 132);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 34);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(25, 169);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 34);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(79, 169);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 34);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(136, 169);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 34);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(136, 206);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(48, 34);
            this.btnPunto.TabIndex = 11;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(28, 206);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(102, 34);
            this.Btn0.TabIndex = 12;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.button11_Click);
            // 
            // BtnResultado
            // 
            this.BtnResultado.Location = new System.Drawing.Point(244, 132);
            this.BtnResultado.Name = "BtnResultado";
            this.BtnResultado.Size = new System.Drawing.Size(48, 108);
            this.BtnResultado.TabIndex = 13;
            this.BtnResultado.Text = "=";
            this.BtnResultado.UseVisualStyleBackColor = true;
            this.BtnResultado.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(190, 95);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(48, 34);
            this.btnDiv.TabIndex = 14;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(190, 169);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(48, 34);
            this.BtnMulti.TabIndex = 15;
            this.BtnMulti.Text = "X";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(190, 206);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(48, 34);
            this.btnSuma.TabIndex = 16;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.button15_Click);
            // 
            // BtnRest
            // 
            this.BtnRest.Location = new System.Drawing.Point(190, 132);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(48, 34);
            this.BtnRest.TabIndex = 17;
            this.BtnRest.Text = "-";
            this.BtnRest.UseVisualStyleBackColor = true;
            this.BtnRest.Click += new System.EventHandler(this.button16_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 18;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(244, 95);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(48, 36);
            this.BtnClear.TabIndex = 19;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 310);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRest);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.BtnResultado);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnResultado;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button BtnRest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClear;
    }
}

