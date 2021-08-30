using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.entidades
{
    class ClsPersona
    {

        private String nombre;
        private String sexo;
        private int edad;
        private int peso;
        private int altura;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Altura { get => altura; set => altura = value; }

    }
}
