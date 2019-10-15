using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace SistemaEscuela
{
    [Serializable]
    class Estudiante
    {
        private string _nombre;
        private string _apellido;
        private string _tutor;
        private string _genero;
        private DateTime _fechanac;

        public Estudiante(string nombre, string apellido, string tutor, string genero, DateTime fechanac)
        {
            _nombre = nombre;
            _apellido = apellido;
            _tutor = tutor;
            _genero = genero;
            _fechanac = fechanac;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Tutor { get => _tutor; set => _tutor = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public DateTime Fechanac { get => _fechanac; set => _fechanac = value; }

        public override bool Equals(object obj)
        {
            return obj is Estudiante estudiante &&
                   _nombre == estudiante._nombre &&
                   _apellido == estudiante._apellido &&
                   _tutor == estudiante._tutor &&
                   _genero == estudiante._genero &&
                   _fechanac == estudiante._fechanac;
        }

        public override int GetHashCode()
        {
            var hashCode = 1161141616;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_apellido);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_tutor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_genero);
            hashCode = hashCode * -1521134295 + _fechanac.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} {this.Genero} {this.Tutor} {this.Fechanac}";
        }

        
    }
}
