using Persona.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.negocios
{
    class NClsPersona
    {

        Clspersona clspersona = new clspersona(0, 0);
        public String calcularIMC()
        {

            double pro = clspersona.Peso / Math.Pow(clspersona.Altura, 2);

            if (pro < 20)
            {
                return "Su peso es ideal";
            }
            if (pro > 25)
            {
                return "Tiene sobre peso";
            }
            return "";
        }
        public String esMayorDeEdad()
        {
            if (clspersona.Edad >= 18)
            {
                return "Es Mayor de edad";
            }
            else
                return "No es mayor de edad";
        }
    }
}

