namespace ER
{
    internal static class Program
    {
        internal static Form FormMain = new WinMain();
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(FormMain);
        }
    }
}