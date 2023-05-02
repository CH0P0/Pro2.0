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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Formas> formas = new List<Formas>();
            int option;
            do
            {
                option = Functions.Menu();
                switch (option)
                {
                    case 1:
                        formas.Add(Circle.ReadCircle());
                        break;
                    case 2:
                        formas.Add(Triangle.ReadTriangle());
                        break;
                    case 3:
                        formas.Add(Rectangle.ReadRectangle());
                        break;
                    case 4:
                        if(formas.Count != 0) Formas.ShowList(formas);
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (option != 0);
        }
    }
}