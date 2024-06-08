using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class CrearForm : Form
    {
        private Database db;

        public CrearForm()
        {
            InitializeComponent();
            db = new Database();
            LoadUsuarios();
        }

        private void LoadUsuarios()
        {
            var usuarios = db.GetUsuarios();
            foreach (var usuario in usuarios)
            {
                comboUsuario.Items.Add($"{usuario.Key} - {usuario.Value}");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string carnet = txtCarnet.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string grado = txtGrado.Text;
            string usuario = comboUsuario.SelectedItem.ToString().Split('-')[0].Trim();

            if (!string.IsNullOrEmpty(carnet) && !string.IsNullOrEmpty(nombre) &&
                !string.IsNullOrEmpty(telefono) && !string.IsNullOrEmpty(grado) &&
                !string.IsNullOrEmpty(usuario))
            {
                db.InsertAlumno(carnet, nombre, telefono, grado, usuario);
                MessageBox.Show("Alumno guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}