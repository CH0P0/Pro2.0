using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa que permita registrar figuras geométricas,
//calcular su área y mostrarlas en su conjunto. 
//Todas las figuras tendrán un color propio indicado por el
//usuario al registrarlas. 
//Las figuras serán de un tipo de los siguientes, cada una con
//su propia definición de sus dimensiones: Rectángulo(definido
//por su ancho y largo), Círculo(definido por su radio) o
//Triángulo(definido por su base y su altura).
//A la hora de crear una nueva figura se tendrá que dar a elegir
//al usuario cuál de los 3 tipos quiere crear, así como su color y dimensiones.
//Utilizar mecanismos que ofrece la herencia para realizar este ejercicio.

namespace Geometria
{
    abstract class Formas
    {
        public string Color { get; set; }
        public Formas(string Color)
        {
            this.Color = Color;
        }

        public abstract double Area();
    }
}
