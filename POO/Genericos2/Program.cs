using System.Runtime.Intrinsics.Arm;

namespace Genericos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AlmacenEmpleados<Director> direct = new AlmacenEmpleados<Director>(3);
            direct.Agregar(new Director(2500));
            direct.Agregar(new Director(1500));
            direct.Agregar(new Director(3500));
            AlmacenEmpleados<Secretario> secre = new AlmacenEmpleados<Secretario>(3);
            secre.Agregar(new Secretario(1500));
            secre.Agregar(new Secretario(1200));
            secre.Agregar(new Secretario(1100));
        }
    }

    class AlmacenEmpleados<T> where T : IEmpleados
    {
        private int i = 0;
        private T[] datosEmpleado;

        public AlmacenEmpleados(int z)
        {
            datosEmpleado= new T[z];
        }

        public void Agregar(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }

        public T GetEmpleado(int j) => datosEmpleado[j];



    }

    interface IEmpleados
    {
        double GetSalario();
    }

    class Director : IEmpleados
    {
        private double salario;
        public Director (double salario)
        {
            this.salario = salario;
        }

        public double GetSalario() => salario;
    }

    class Secretario : IEmpleados 
    {
        private double salario;
        public Secretario(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario() => salario;

    }

    class Electricista : IEmpleados
    {
        private double salario;
        public Electricista(double salario)
        {
            this.salario = salario;
        }
        
        public double GetSalario() => salario;

    }


}