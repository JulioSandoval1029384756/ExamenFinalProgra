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
    public partial class ActualizarForm : Form
    {
        private Database db;
        private string carnet;

        public ActualizarForm(string carnet)
        {
            InitializeComponent();
            db = new Database();
            this.carnet = carnet;
            LoadAlumno();
            LoadUsuarios();
        }

        private void LoadAlumno()
        {
            var alumno = db.GetAlumno(carnet);
            txtCarnet.Text = alumno["carnet"];
            txtNombre.Text = alumno["nombre"];
            txtTelefono.Text = alumno["telefono"];
            txtGrado.Text = alumno["grado"];
            comboUsuario.SelectedItem = alumno["usuario"];
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
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string grado = txtGrado.Text;
            string usuario = comboUsuario.SelectedItem.ToString().Split('-')[0].Trim();

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(telefono) &&
                !string.IsNullOrEmpty(grado) && !string.IsNullOrEmpty(usuario))
            {
                db.UpdateAlumno(carnet, nombre, telefono, grado, usuario);
                MessageBox.Show("Alumno actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}