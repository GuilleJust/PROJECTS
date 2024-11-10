namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Start();
        }

        public static void Start()
        {
            FormPrincipal main;
            using (var dlg = new FormLogin())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                main = new FormPrincipal();
                main.Employee = dlg.Employee;

                // Make main form show up at the same location
                main.StartPosition = FormStartPosition.Manual;
                main.Location = dlg.Location;
            }

            Application.Run(main);
        }
    }
}