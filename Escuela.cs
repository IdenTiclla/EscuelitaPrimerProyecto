using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading.Tasks;

namespace SistemaEscuela
{
    [Serializable]
    class Escuela
    {
        private string nombre;
        private int cantidad_cursos;
        LinkedList<Curso> cursos;

        public Escuela()
        {
            nombre = "La salle";
            cantidad_cursos = 0;
            cursos = new LinkedList<Curso>();
        }
        public void serealizar()
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream mistream = new FileStream("escuela.esc", FileMode.Create, FileAccess.Write, FileShare.None);
            formateador.Serialize(mistream, this);
            mistream.Close();
        }
        public object deserializar()
        {
            object o;
            BinaryFormatter formateador = new BinaryFormatter();
            Stream mistream = new FileStream("escuela.esc", FileMode.Open, FileAccess.Read, FileShare.None);
            
            o = formateador.Deserialize(mistream);
            mistream.Close();
            return o;

        }
        

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad_cursos { get => cantidad_cursos; set => cantidad_cursos = value; }
        internal LinkedList<Curso> Cursos { get => cursos; set => cursos = value; }

        public void addCurso(Curso c)
        {
            cursos.AddLast(c);
            cantidad_cursos++;
        }

        public override string ToString()
        {
            return $"Escuela: {Nombre}";
        }
    }
}
