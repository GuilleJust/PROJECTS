namespace GrupoA
{
    partial class Prueba
    {

    }
}

namespace GrupoB
{
    namespace GrupoC
    {
        class Prueba
        {

        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            GrupoB.GrupoC.Prueba grupoC = new GrupoB.GrupoC.Prueba();
        }
    }
