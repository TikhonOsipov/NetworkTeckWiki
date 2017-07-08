using System;
using System.Windows.Forms;

namespace AlevonProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static MainForm main = null;
        public static AnnotationPreview annotation = null;
        public static ProfilePreview profile = null;
        public static ExtendedProfilePreview extendedProfile = null;
    }
}
