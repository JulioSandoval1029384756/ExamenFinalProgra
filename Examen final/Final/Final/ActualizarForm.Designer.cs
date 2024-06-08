namespace Final
{
    partial class ActualizarForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.ComboBox comboUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblUsuario;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.comboUsuario = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtCarnet
            this.txtCarnet.Location = new System.Drawing.Point(100, 12);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.ReadOnly = true;
            this.txtCarnet.Size = new System.Drawing.Size(200, 20);
            this.txtCarnet.TabIndex = 0;

            // lblCarnet
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(12, 15);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(41, 13);
            this.lblCarnet.TabIndex = 6;
            this.lblCarnet.Text = "Carnet:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(100, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";

            // txtTelefono
            this.txtTelefono.Location = new System.Drawing.Point(100, 64);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 2;

            // lblTelefono
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 67);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Teléfono:";

            // txtGrado
            this.txtGrado.Location = new System.Drawing.Point(100, 90);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(200, 20);
            this.txtGrado.TabIndex = 3;

            // lblGrado
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(12, 93);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(39, 13);
            this.lblGrado.TabIndex = 9;
            this.lblGrado.Text = "Grado:";

            // comboUsuario
            this.comboUsuario.FormattingEnabled = true;
            this.comboUsuario.Location = new System.Drawing.Point(100, 116);
            this.comboUsuario.Name = "comboUsuario";
            this.comboUsuario.Size = new System.Drawing.Size(200, 21);
            this.comboUsuario.TabIndex = 4;

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 119);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario:";

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(100, 143);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // ActualizarForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 178);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.lblCarnet);
            this.Name = "ActualizarForm";
            this.Text = "Actualizar Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
