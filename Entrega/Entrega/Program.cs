namespace Entrega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ficheros.MakeFile(Ficheros.ERRORFILE);
            if (Ficheros.FileExist(Ficheros.ERRORFILE))
            {
                if (Ficheros.FileExist(Ficheros.FILENAME))
                {
                    if (Ficheros.ReadFile())
                    {
                        if (Ficheros.ValidateData())
                        {
                            Ficheros.MakeFile(Ficheros.MFILENAME);
                            if (Ficheros.FileExist(Ficheros.MFILENAME))
                                Ficheros.WriteFile();
                            else
                            {
                                Ficheros.Errors("No se pudo crear media_poblacion.csv");
                            }
                        }
                    }
                }
                else
                    Ficheros.Errors("No se pudo encontrar edades-medias-de-la-poblacion.csv");
            }
            else
            {
                Console.WriteLine("No se pudo crear errores.log");
            }
        }
    }
}