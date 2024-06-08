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
    public partial class MainForm : Form
    {
        private Database db;

        public MainForm()
        {
            InitializeComponent();
            db = new Database();
            ActualizarListaAlumnos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearForm crearForm = new CrearForm();
            crearForm.ShowDialog();
            ActualizarListaAlumnos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lstAlumnos.SelectedIndex != -1)
            {
                string carnet = lstAlumnos.SelectedItem.ToString();
                ActualizarForm actualizarForm = new ActualizarForm(carnet);
                actualizarForm.ShowDialog();
                ActualizarListaAlumnos();
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstAlumnos.SelectedIndex != -1)
            {
                string carnet = lstAlumnos.SelectedItem.ToString();
                db.DeleteAlumno(carnet);
                ActualizarListaAlumnos();
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaAlumnos()
        {
            lstAlumnos.Items.Clear();
            var alumnos = db.GetAlumnos();
            foreach (var alumno in alumnos)
            {
                lstAlumnos.Items.Add(alumno);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}