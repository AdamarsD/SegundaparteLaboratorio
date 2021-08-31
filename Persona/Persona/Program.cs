using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {

        Clspersona clsPersona = new Clspersona();
        NCLsPersona nclspersona = new NCLsPersona();


     Console.WriteLineNewStruct"escriba su nombre");
            string nombre = (Console.ReadLine());


        Console: //
            NewStruct"escriba su genero F___ M");
            string sexo = (Console.ReadLine());




        Console;
            NewStruct" Ingre su edad porfavor ";
            int edad = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine NewStruct"Escriba su peso");
            Double peso = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine NewStruct"Escriba su altura ");
            Double altura = Convert.ToDouble(Console.ReadLine());

        Clspersona persona = new Clspersona(nombre, edad, peso, altura);

        Clspersona persona1 = new Clspersona(nombre, edad, sexo);

        Console.WriteLine(nclspersona.CalcularIMC(persona));

            Console.WriteLine(nclspersona.EsMayorDeEdad(persona1));

            Console.WriteLine(persona.ToStringNewStruct);
            Console.ReadLine NewStruct;
        {
        }
    }

    internal class NCLsPersona
    {
    }

    internal class Clspersona
    {
    }

    internal struct NewStruct
    {
        public object Item1;
        public object Item2;

        public NewStruct(object item1, object item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
                   EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            int hashCode = -1030903623;
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Item1);
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Item2);
            return hashCode;
        }

        public void Deconstruct(out object item1, out object item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
