using System.Data;

namespace ER
{
    internal static class Program
    {
        #pragma warning disable CS8618 
        internal static DataSet DataSetER;
        #pragma warning restore CS8618 
        internal static Form FormMain = new WinMain();
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(FormMain);
        }
    }
}