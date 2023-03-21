namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisoTrafico av1 = new AvisoTrafico();
            av1.MostrarAviso();

            AvisoTrafico av2 = new AvisoTrafico("TGT", "Sancionado", "de ayer");
            av2.MostrarAviso();
        }
    }
}