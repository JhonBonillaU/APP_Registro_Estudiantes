using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App_Estudiantes_Universitarios
{
	public partial class FrmGestionEstudiantil : Form
	{
		// lista de estudiantes 
		List<Estudiante> lista = new List<Estudiante>();

		// constructor del formulario
		public FrmGestionEstudiantil()
		{
			InitializeComponent();
		}

		// union de dgvEstudiantes con la lista de estudiantes
		private void MostrarEstudiantes(List<Estudiante> listaMostrar)
		{
			dgvEstudiantes.Rows.Clear(); // evitamos duplicados al mostrar la lista
            

            foreach (Estudiante est in listaMostrar)
			{
				dgvEstudiantes.Rows.Add(est.Nombre, est.Carnet, est.Carrera, est.Promedio); // agregamos los datos del estudiante
			}
		}

		// boton agregar estudiante
		private void btnMostrarEstudiantes_Click(object sender, EventArgs e)
		{
			MostrarEstudiantes(lista);
		}

		// boton agregar estudiante
		private void btnEstudiantesDestacados_Click(object sender, EventArgs e)
		{
			List<Estudiante> destacados = new List<Estudiante>(); // lista temporalde estudiantes destacados

			foreach (Estudiante est in lista)
			{
				if (est.EsDestacado())
				{
					destacados.Add(est); // agregamos el estudiante destacado a la lista
				}
			}
			MostrarEstudiantes(destacados); // mostramos la lista de estudiantes destacados
		}

		private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		//boton registrar estudiante
		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtboName.Text) ||
				string.IsNullOrWhiteSpace(txtboCarnet.Text) ||
				string.IsNullOrWhiteSpace(txtboCarrera.Text))
			{
				MessageBox.Show("Por favor, complete todos los campos antes de registrar un estudiante.", "Campos incompletos",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!double.TryParse(txtboPromedio.Text, out double promedio))
			{
				MessageBox.Show("Por favor, ingrese un promedio válido (número).", "Promedio inválido",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			} 

			if (promedio < 0 || promedio > 10)
			{
				MessageBox.Show("Por favor, ingrese un promedio válido entre 0 y 10.", "Promedio inválido",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
            }

            Estudiante nuevoEstudiante = new Estudiante(
					txtboName.Text,
					txtboCarnet.Text,
					txtboCarrera.Text,
					promedio
					);

			lista.Add(nuevoEstudiante);

			MostrarEstudiantes(lista);
			LimpiarTextBox();

        }


        //Creando Metodo para limpiar los TextBox
        private void LimpiarTextBox()
		{
			txtboName.Clear();
			txtboCarnet.Clear();
			txtboCarrera.Clear();
			txtboPromedio.Clear();
			txtboName.Focus();
		}

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            // validamos que la lista no este vacia para evitar error de division entre cero
            if (lista.Count == 0)
            {
                MessageBox.Show("no hay estudiantes registrados para calcular el promedio.",
                                "advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // acumulador para sumar todos los promedios
            double sumaPromedios = 0;

            // recorremos la lista de estudiantes
            foreach (Estudiante est in lista)
            {
                // acumulamos el promedio de cada estudiante
                sumaPromedios += est.Promedio;
            }

            // calculamos el promedio general
            double promedioGeneral = sumaPromedios / lista.Count;

            // mostramos el resultado exacto tal cual sin aproximar
            txtboResultadoPromedio.Text = promedioGeneral.ToString("0.00");
        }
    }
}
