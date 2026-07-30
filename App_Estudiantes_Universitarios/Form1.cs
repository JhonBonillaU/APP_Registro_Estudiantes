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
	}

}
