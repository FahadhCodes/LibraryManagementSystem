namespace LIBRARY_MANAGEMENT_SYSTEM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm login = new LoginForm();

            // Show login form first
            if (login.ShowDialog() == DialogResult.OK)
            {
                // If login successful, run main form
                Application.Run(new Admin_Panel());
            }
        }
    }
}