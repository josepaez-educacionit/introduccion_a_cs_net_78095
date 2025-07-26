namespace Demo
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button[] digitButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEq;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonPorcentaje;
        private System.Windows.Forms.Button buttonPotencia;
        private System.Windows.Forms.Button buttonRaiz;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.digitButtons = new System.Windows.Forms.Button[10];
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEq = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonPorcentaje = new System.Windows.Forms.Button();
            this.buttonPotencia = new System.Windows.Forms.Button();
            this.buttonRaiz = new System.Windows.Forms.Button();

            // Colores para los botones
            System.Drawing.Color colorNumeros = System.Drawing.Color.White;
            System.Drawing.Color colorOperadores = System.Drawing.Color.LightSkyBlue;
            System.Drawing.Color colorEspeciales = System.Drawing.Color.LightGreen;
            System.Drawing.Color colorIgual = System.Drawing.Color.Orange;
            System.Drawing.Color colorBorrar = System.Drawing.Color.LightCoral;

            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 40);
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.ForeColor = System.Drawing.Color.DarkBlue;
            // 
            // digitButtons
            // 
            for (int i = 0; i < 10; i++)
            {
                this.digitButtons[i] = new System.Windows.Forms.Button();
                this.digitButtons[i].Size = new System.Drawing.Size(60, 50);
                this.digitButtons[i].TabIndex = i + 1;
                this.digitButtons[i].Text = i.ToString();
                this.digitButtons[i].UseVisualStyleBackColor = false;
                this.digitButtons[i].BackColor = colorNumeros;
                this.digitButtons[i].Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.digitButtons[i].Name = $"button{i}";
                this.digitButtons[i].Click += new System.EventHandler(this.button_Click);
            }
            // Posicionar botones numéricos (3x4 grid)
            int btnIndex = 1;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    this.digitButtons[btnIndex].Location = new System.Drawing.Point(20 + col * 65, 75 + row * 55);
                    btnIndex++;
                }
            }
            // Botón 0
            this.digitButtons[0].Location = new System.Drawing.Point(20, 75 + 3 * 55);
            this.digitButtons[0].Size = new System.Drawing.Size(125, 50);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(215, 75);
            this.buttonAdd.Size = new System.Drawing.Size(60, 50);
            this.buttonAdd.Text = "+";
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonAdd.Click += new System.EventHandler(this.operador_Click);
            this.buttonAdd.BackColor = colorOperadores;
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(215, 130);
            this.buttonSub.Size = new System.Drawing.Size(60, 50);
            this.buttonSub.Text = "-";
            this.buttonSub.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonSub.Click += new System.EventHandler(this.operador_Click);
            this.buttonSub.BackColor = colorOperadores;
            this.buttonSub.UseVisualStyleBackColor = false;
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(215, 185);
            this.buttonMul.Size = new System.Drawing.Size(60, 50);
            this.buttonMul.Text = "*";
            this.buttonMul.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonMul.Click += new System.EventHandler(this.operador_Click);
            this.buttonMul.BackColor = colorOperadores;
            this.buttonMul.UseVisualStyleBackColor = false;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(215, 240);
            this.buttonDiv.Size = new System.Drawing.Size(60, 50);
            this.buttonDiv.Text = "/";
            this.buttonDiv.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonDiv.Click += new System.EventHandler(this.operador_Click);
            this.buttonDiv.BackColor = colorOperadores;
            this.buttonDiv.UseVisualStyleBackColor = false;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(150, 295);
            this.buttonC.Size = new System.Drawing.Size(60, 50);
            this.buttonC.Text = "C";
            this.buttonC.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            this.buttonC.BackColor = colorBorrar;
            this.buttonC.UseVisualStyleBackColor = false;
            // 
            // buttonEq
            // 
            this.buttonEq.Location = new System.Drawing.Point(215, 295);
            this.buttonEq.Size = new System.Drawing.Size(105, 50);
            this.buttonEq.Text = "=";
            this.buttonEq.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonEq.Click += new System.EventHandler(this.buttonIgual_Click);
            this.buttonEq.BackColor = colorIgual;
            this.buttonEq.UseVisualStyleBackColor = false;
            // 
            // buttonPorcentaje
            // 
            this.buttonPorcentaje.Location = new System.Drawing.Point(20, 295);
            this.buttonPorcentaje.Size = new System.Drawing.Size(40, 50);
            this.buttonPorcentaje.Text = "%";
            this.buttonPorcentaje.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonPorcentaje.Click += new System.EventHandler(this.operador_Click);
            this.buttonPorcentaje.BackColor = colorEspeciales;
            this.buttonPorcentaje.UseVisualStyleBackColor = false;
            // 
            // buttonPotencia
            // 
            this.buttonPotencia.Location = new System.Drawing.Point(65, 295);
            this.buttonPotencia.Size = new System.Drawing.Size(40, 50);
            this.buttonPotencia.Text = "^";
            this.buttonPotencia.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonPotencia.Click += new System.EventHandler(this.operador_Click);
            this.buttonPotencia.BackColor = colorEspeciales;
            this.buttonPotencia.UseVisualStyleBackColor = false;
            // 
            // buttonRaiz
            // 
            this.buttonRaiz.Location = new System.Drawing.Point(110, 295);
            this.buttonRaiz.Size = new System.Drawing.Size(40, 50);
            this.buttonRaiz.Text = "√";
            this.buttonRaiz.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonRaiz.Click += new System.EventHandler(this.buttonRaiz_Click);
            this.buttonRaiz.BackColor = colorEspeciales;
            this.buttonRaiz.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 370);
            this.Controls.Add(this.textBox1);
            for (int i = 0; i < 10; i++)
                this.Controls.Add(this.digitButtons[i]);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonEq);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonPorcentaje);
            this.Controls.Add(this.buttonPotencia);
            this.Controls.Add(this.buttonRaiz);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
