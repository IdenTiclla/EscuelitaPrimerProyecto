using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace SistemaEscuela
{
    [Serializable]
    class Curso
    {
        private int nro;
        private int capacidad;
        private int cantidad_estudiantes;
        private Profesor profesor;
        private Materia materia;
        private LinkedList<Estudiante> estudiantes;

        public Curso(int nro)
        {
            this.nro = nro;
            capacidad = 30;
            estudiantes = new LinkedList<Estudiante>();
        }

        public int Nro { get => nro; set => nro = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int Cantidad_estudiantes { get => cantidad_estudiantes; set => cantidad_estudiantes = value; }
        internal LinkedList<Estudiante> Estudiantes { get => estudiantes; set => estudiantes = value; }
        internal Profesor Profesor { get => profesor; set => profesor = value; }
        internal Materia Materia { get => materia; set => materia = value; }

        
        public override string ToString()
        {
            return $"N-{this.Nro} {this.Profesor} {this.Materia} \n {this.mostrar_estudiantes()}";
        }
        public string mostrar_curso()
        {
            return $"N-{this.Nro}";
        }
        public void addEstudiante(Estudiante e)
        {
            estudiantes.AddLast(e);
            this.cantidad_estudiantes++;

        }
        public void remove_student(Estudiante e)
        {
            estudiantes.Remove(e);
        }
        

        public string mostrar_estudiantes()
        {
            string res = "";
            foreach (Estudiante e in this.estudiantes)
            {
                res = res + $"{e}\n";
            }
            return res;
        }
    }
}
