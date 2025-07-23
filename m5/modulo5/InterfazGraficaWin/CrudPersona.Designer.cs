namespace InterfazGraficaWin
{
	partial class CrudPersona
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
			txtNombre = new TextBox();
			label2 = new Label();
			txtApellido = new TextBox();
			label3 = new Label();
			label4 = new Label();
			txtNumeroDocumento = new TextBox();
			label5 = new Label();
			txtDomicilio = new TextBox();
			label6 = new Label();
			txtTelefono = new TextBox();
			label7 = new Label();
			txtFechaNacimiento = new DateTimePicker();
			dgvPersonas = new DataGridView();
			btnAgregar = new Button();
			((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
			SuspendLayout();
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(155, 83);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(290, 23);
			txtNombre.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(33, 83);
			label2.Name = "label2";
			label2.Size = new Size(51, 15);
			label2.TabIndex = 2;
			label2.Text = "Nombre";
			// 
			// txtApellido
			// 
			txtApellido.Location = new Point(155, 112);
			txtApellido.Name = "txtApellido";
			txtApellido.Size = new Size(290, 23);
			txtApellido.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(33, 112);
			label3.Name = "label3";
			label3.Size = new Size(51, 15);
			label3.TabIndex = 4;
			label3.Text = "Apellido";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(33, 138);
			label4.Name = "label4";
			label4.Size = new Size(103, 15);
			label4.TabIndex = 6;
			label4.Text = "Fecha Nacimiento";
			// 
			// txtNumeroDocumento
			// 
			txtNumeroDocumento.Location = new Point(155, 170);
			txtNumeroDocumento.Name = "txtNumeroDocumento";
			txtNumeroDocumento.Size = new Size(100, 23);
			txtNumeroDocumento.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(33, 167);
			label5.Name = "label5";
			label5.Size = new Size(117, 15);
			label5.TabIndex = 8;
			label5.Text = "Numero Documento";
			// 
			// txtDomicilio
			// 
			txtDomicilio.Location = new Point(155, 199);
			txtDomicilio.Name = "txtDomicilio";
			txtDomicilio.Size = new Size(290, 23);
			txtDomicilio.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(33, 199);
			label6.Name = "label6";
			label6.Size = new Size(58, 15);
			label6.TabIndex = 10;
			label6.Text = "Domicilio";
			// 
			// txtTelefono
			// 
			txtTelefono.Location = new Point(155, 228);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.Size = new Size(290, 23);
			txtTelefono.TabIndex = 13;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(33, 228);
			label7.Name = "label7";
			label7.Size = new Size(53, 15);
			label7.TabIndex = 12;
			label7.Text = "Telefono";
			// 
			// txtFechaNacimiento
			// 
			txtFechaNacimiento.Location = new Point(155, 138);
			txtFechaNacimiento.Name = "txtFechaNacimiento";
			txtFechaNacimiento.Size = new Size(200, 23);
			txtFechaNacimiento.TabIndex = 14;
			// 
			// dgvPersonas
			// 
			dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPersonas.Location = new Point(33, 279);
			dgvPersonas.Name = "dgvPersonas";
			dgvPersonas.Size = new Size(536, 150);
			dgvPersonas.TabIndex = 15;
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(493, 83);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(75, 23);
			btnAgregar.TabIndex = 16;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// CrudPersona
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(604, 466);
			Controls.Add(btnAgregar);
			Controls.Add(dgvPersonas);
			Controls.Add(txtFechaNacimiento);
			Controls.Add(txtTelefono);
			Controls.Add(label7);
			Controls.Add(txtDomicilio);
			Controls.Add(label6);
			Controls.Add(txtNumeroDocumento);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(txtApellido);
			Controls.Add(label3);
			Controls.Add(txtNombre);
			Controls.Add(label2);
			Name = "CrudPersona";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox txtNombre;
		private Label label2;
		private TextBox txtApellido;
		private Label label3;
		private Label label4;
		private TextBox txtNumeroDocumento;
		private Label label5;
		private TextBox txtDomicilio;
		private Label label6;
		private TextBox txtTelefono;
		private Label label7;
		private DateTimePicker txtFechaNacimiento;
		private DataGridView dgvPersonas;
		private Button btnAgregar;
	}
}
