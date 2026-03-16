using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestorTareasGUI1.Class1;

namespace GestorTareasGUI1
{

    public partial class Form1 : Form
    {
        List<Tarea> tareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Tarea t = new Tarea()
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = dtFecha.Value,
                Completada = false
            };

            tareas.Add(t);

           
            string prioridad = chkPrioridadAlta.Checked ? "Alta" : "Normal";
            string categoria = cmbCategoria.Text;

            Papi.Items.Add($"[{prioridad}] {t.Nombre} | {categoria} | {t.Fecha.ToShortDateString()}");

           
            lblContadorTareas.Text = "Total tareas: " + Papi.Items.Count;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Papi.SelectedItem != null)
            {
                tareas.Remove((Tarea)tareas[Papi.SelectedIndex]);
                Papi.Items.Remove(Papi.SelectedItem);

                lblContadorTareas.Text = "Total tareas: " + Papi.Items.Count;
            }
            else
            {
                MessageBox.Show("Selecciona una tarea primero");
            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (Papi.SelectedItem != null)
            {
                Tarea t = tareas[Papi.SelectedIndex];
                t.Completada = true;

                int index = Papi.SelectedIndex;
                Papi.Items[index] = "✔ " + Papi.Items[index].ToString();
            }
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Trabajo");
            cmbCategoria.Items.Add("Personal");
            cmbCategoria.Items.Add("Estudios");

            lblContadorTareas.Text = "Total tareas: 0";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            chkPrioridadAlta.Checked = false;
            cmbCategoria.SelectedIndex = -1;
        }
    }
}