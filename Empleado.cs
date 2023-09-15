using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    public class Empleado
    {
        private string nombre;
        private float salario;
        private string genero;
        List<string> listaTareas;

        public Empleado(string nombre, float salario, string genero, List<string> listaTareas)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.genero = genero;
            this.listaTareas = new List<string>(listaTareas);
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Salario { get => salario; set => salario = value; }
        public string Genero { get => genero; set => genero = value; }
        public List<string> ListaTareas { get => listaTareas; set => listaTareas = value; }
    
        public string ToSring ()
        {
            return Nombre + "-" + Salario + "-" + Genero; 
        }
    }
}
