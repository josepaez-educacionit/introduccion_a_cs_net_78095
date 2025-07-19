namespace _03_AplicacionVisualEscritorio
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
			btnCerrar = new Button();
			llblNombre = new Label();
			txtNombre = new TextBox();
			btnSaludar = new Button();
			btnLimpiar = new Button();
			lblSaludo = new Label();
			SuspendLayout();
			// 
			// btnCerrar
			// 
			btnCerrar.Location = new Point(554, 376);
			btnCerrar.Name = "btnCerrar";
			btnCerrar.Size = new Size(125, 35);
			btnCerrar.TabIndex = 0;
			btnCerrar.Text = "Cerrar";
			btnCerrar.UseVisualStyleBackColor = true;
			btnCerrar.Click += btnCerrar_Click;
			// 
			// llblNombre
			// 
			llblNombre.AutoSize = true;
			llblNombre.Location = new Point(40, 126);
			llblNombre.Name = "llblNombre";
			llblNombre.Size = new Size(51, 15);
			llblNombre.TabIndex = 1;
			llblNombre.Text = "Nombre";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(111, 118);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(242, 23);
			txtNombre.TabIndex = 2;
			// 
			// btnSaludar
			// 
			btnSaludar.Location = new Point(368, 118);
			btnSaludar.Name = "btnSaludar";
			btnSaludar.Size = new Size(75, 23);
			btnSaludar.TabIndex = 3;
			btnSaludar.Text = "Saludar";
			btnSaludar.UseVisualStyleBackColor = true;
			btnSaludar.Click += btnSaludar_Click;
			// 
			// btnLimpiar
			// 
			btnLimpiar.Location = new Point(368, 147);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(75, 23);
			btnLimpiar.TabIndex = 4;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = true;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// lblSaludo
			// 
			lblSaludo.AutoSize = true;
			lblSaludo.Font = new Font("Segoe UI", 14F);
			lblSaludo.ForeColor = Color.Blue;
			lblSaludo.Location = new Point(111, 169);
			lblSaludo.Name = "lblSaludo";
			lblSaludo.Size = new Size(0, 25);
			lblSaludo.TabIndex = 5;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblSaludo);
			Controls.Add(btnLimpiar);
			Controls.Add(btnSaludar);
			Controls.Add(txtNombre);
			Controls.Add(llblNombre);
			Controls.Add(btnCerrar);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCerrar;
		private Label llblNombre;
		private TextBox txtNombre;
		private Button btnSaludar;
		private Button btnLimpiar;
		private Label lblSaludo;
	}
}
