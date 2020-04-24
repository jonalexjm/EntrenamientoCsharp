using System;
using System.Collections.Generic;
using System.Text;

namespace Linq3
{
    public class CEstudiantes
    {
        private string nombre;
        private string id;
        private string curso;
        private double promedio;

        public string Nombre { get { return nombre; } }
        public string ID { get { return id; } }
        public string Curso { get { return id; } }
        public double Promedio { get { return promedio; } }

        public CEstudiantes(string pNombre, string pId,
                            string pCurso, double PPromedio)
        {
            nombre = pNombre;
            id = pId;
            curso = pCurso;
            promedio = PPromedio;

        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, curso {1}", nombre, id);
        }
    }
}
