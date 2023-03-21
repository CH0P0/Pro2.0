namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AlmacenObjetos archivos = new AlmacenObjetos(4);

            archivos.Agregar("Juan");
            archivos.Agregar("Julian");
            archivos.Agregar("Antonio");
            archivos.Agregar("Mani");
            Console.WriteLine(archivos.GetElement(2));
            String nombrePersona = (String)archivos.GetElement(1);
            Console.WriteLine(nombrePersona);

            AlmacenObjetos empleados = new AlmacenObjetos(4);
            empleados.Agregar(new Empleado(1500));
            empleados.Agregar(new Empleado(2500));
            empleados.Agregar(new Empleado(3500));
            empleados.Agregar(new Empleado(4500));

            Console.WriteLine(empleados.GetElement(2));
            Empleado empleado = (Empleado)empleados.GetElement(2);
            Console.WriteLine(empleado.GetSalario());

            Almacen<Empleado> empl = new Almacen<Empleado>(4);
            empl.Agregar(new Empleado(1500));
            empl.Agregar(empleado);
        }
    }

    class AlmacenObjetos
    {
        private Object[] datosElemento;
        private int i = 0;
        public AlmacenObjetos(int z)
        {
            datosElemento = new Object[z];
        }

        public void Agregar(Object obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public Object GetElement(int i) => datosElemento[i];
    }

    class Empleado
    {
        private double salario;
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario() => salario;
    }

    class Almacen<T>
    {
        public Almacen(int z)
        {
            datos = new T[z];
        }

        public void Agregar(T obj)
        {
            datos[i] = obj;
            i++;
        }

        public T GetElem(int i) => datos[i];

        private T[] datos;
        private int i = 0;
    }
}