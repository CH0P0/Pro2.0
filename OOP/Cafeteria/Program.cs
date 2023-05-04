//La cafetería del centro nos ha pedido que realicemos un programa
//que permita gestionar los pedidos que realiza el alumnado.
//Estos pedidos se componen de una serie de productos, tantos
//como quiera el usuario, a elegir entre los que ofrece la cafetería
//en su menú. Los productos que contiene el menú se especificarán en el código. 
//La cafetería tendrá que ir anotando los pedidos en una cola de
//pedidos que solo admite un máximo de 5, de manera que si la cola está llena
//no se podrán añadir más pedidos hasta que se sirva alguno de los pendientes. 
//Los pedidos han de registrar un conjunto de productos y la fecha en la que
//fue pedido (dia, mes, año y hora).
//Los pedidos se sirven por orden de llegada, cuando el usuario así lo elija
//en el menú, teniendo que mostrar el coste que tenía el pedido servido. 
//El programa tendrá que permitir “hacer caja” mostrando todos los pedidos
//servidos hasta el momento, con sus productos y precio de pedido, y el total
//de dinero recaudado hasta el momento.

namespace Cafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new();
            Queue cola = new();
            int option;
            Console.WriteLine("Bienvenido a la cafeteria");
            bool value = true;
            do
            {
                option = Functions.Menu();
                switch(option)
                {
                    case 1:
                        if (!Order.ItIsFull(cola))
                        {
                            Order o = Order.MakeOrder();
                            orders.Add(o);
                            cola.Push(o);
                        }
                        else
                            Console.WriteLine("La cola esta llena, espere o vayase.");
                        break;
                    case 2:
                        cola.Pop();
                        break;
                    default:
                        value = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (value);
            decimal total = Order.CountMoney(orders);
            Order.ShowOrders(orders);
            Console.WriteLine($"El total de dinero recaudado ha sido: {total}");
            
        }
    }
}