namespace TrackerUI
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
            
            // Initialize the database connections
            // Now that it is initialized, everybody can use the initialization
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);

            Application.Run(new CreatePrizeForm());
            // Application.Run(new TournamentDashboardForm());
        }
    }
}