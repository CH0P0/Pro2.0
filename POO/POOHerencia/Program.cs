using System;
using System.Runtime;

namespace POOHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamiferos mamifero = new Mamiferos("Momo");
            Caballo caballo = new Caballo("Barbaluna");
            IMamiferosTerrestres Icaballo = caballo;
            Humano humano = new Humano("Juan");
            Gorila gorila= new Gorila("Copito");

            mamifero.cuidarCrias();
            caballo.respirar();
            humano.respirar();
            gorila.cuidarCrias();
            humano.getNombre();

            Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = caballo;
            almacenAnimales[1] = humano;
            almacenAnimales[2] = gorila;

            almacenAnimales[1].getNombre();

            Ballena wally = new Ballena("Wally");
            wally.nadar();
            Console.WriteLine($"Numero de patas de caballo: {Icaballo.NumeroPatas()}");

            Lagartija lag = new Lagartija("Juana");
            lag.respirar();
        }   
    }

    interface IMamiferosTerrestres
    {
        int NumeroPatas();
    }

    interface IAnimalesDeportes
    {
        string TipoDeporte();
        bool EsOlimpico();
    }

    interface ISaltoConPatas
    {
        int NumeroPatas();
    }

    abstract class Animales
    {
        public void respirar() => Console.WriteLine("Breath");
        public abstract string getNombre();
    }
    class Mamiferos : Animales
    {
        public Mamiferos(string nombre) => nombreSerVivo = nombre;

        public virtual void pensar() => Console.WriteLine("Pensamiento basico");

        public void cuidarCrias() => Console.WriteLine("Cuido crías");

        public override string getNombre() => $"El nombre del ser vivo es {nombreSerVivo}";

        private string nombreSerVivo;
    }

    class Lagartija : Animales
    {
        private string nombreReptil;

        public Lagartija(string nombreReptil)
        {
            this.nombreReptil = nombreReptil; 
        }
        public override string getNombre() => $"El nombre de la lagartija es {nombreReptil}"
    }

    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena):base(nombreBallena) { }
        public override void pensar() => Console.WriteLine("Ballena piensa");
        public void nadar() => Console.WriteLine("Nado");
    }

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportes, ISaltoConPatas
    {
        public Caballo(string nombreCaballo):base(nombreCaballo) { }
        public void Galopar() => Console.WriteLine("galopo");
        public override void pensar() => Console.WriteLine("Pienso, luego galopo");
        int IMamiferosTerrestres.NumeroPatas() => 4;
        int ISaltoConPatas.NumeroPatas() => 2;
        public string TipoDeporte() => "Hípica";
        public bool EsOlimpico() => true;
    }

    class Humano : Mamiferos
    {
        public Humano(string nombreHumano):base(nombreHumano) { }
        public sealed override void pensar() => Console.WriteLine("Pienso, luego existo");
    }

    sealed class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreGorila):base(nombreGorila) { }

        public override void pensar() => Console.WriteLine("Pensamiento burdo");
        public void trepar() => Console.WriteLine("trepo");
        public int NumeroPatas() => 2;

    }
}