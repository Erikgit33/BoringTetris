namespace BoringTetris
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // skapa en ny modell med r�tt antal rader och kolumner
            Model model = new Model(View.NUM_ROWS, View.NUM_COLS);

            // skapa en ny view, i winforms �r detta ett Form
            View view = new View();

            // skapa en controller som styr b�de model och view
            Controller controller = new Controller(model, view);

            Application.Run(view);
        }
    }
}