using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Estudiantes_Universitarios
{
    public class Estudiante
    {
        private string _nombre;
        private string _carnet;
        private string _carrera;
        private double _prom;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Carnet
        {
            get { return _carnet; }
            set { _carnet = value; }
        }
        public string Carrera
        {
            get { return _carrera; }
            set { _carrera = value; }
        }
        public double Promedio
        {
            get { return _prom; }
            set { _prom = value; }
        }

        public Estudiante(string nom, string carnet, string carrera, double prom)
        {
            _nombre = nom;
            _carnet = carnet;
            _carrera = carrera;
            _prom = prom;
        }

        public bool EsDestacado()
        {
            return Promedio > 8.0;
        }
    }
}
