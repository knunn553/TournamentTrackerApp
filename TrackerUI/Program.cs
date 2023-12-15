namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
            // Removed internal from the Main() method.
        {
            // To customize application configuration such as set high DPI settings or default font,
           
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialize the database connections
            // Now that it is initialized, everybody can use the initialization
            TrackerLibrary.GlobalConfig.InitializeConnections(TrackerLibrary.DatabaseType.Sql);
            //Application.Run(new CreatePrizeForm());
            Application.Run(new CreateTournamentForm());
            // Application.Run(new TournamentDashboardForm());
        }
    }
}