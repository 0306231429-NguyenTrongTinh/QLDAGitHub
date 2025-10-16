using System;
using System.Windows.Forms;
using QLBH.Forms;

namespace QLBH
{
    internal static class Program
    {
        /// <summary>
        /// Điểm bắt đầu của chương trình.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Form khởi động đầu tiên là frmLogin
            Application.Run(new frmLogin());
        }
    }
}
