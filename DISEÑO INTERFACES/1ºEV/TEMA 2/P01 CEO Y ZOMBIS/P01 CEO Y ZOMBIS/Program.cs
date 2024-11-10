namespace P01_CEO_Y_ZOMBIS
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new imagen());
        }
    }
}