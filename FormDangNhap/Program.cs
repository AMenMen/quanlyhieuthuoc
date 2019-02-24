using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] 
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());

            // Ket noi phan mem voi co so du lieu PostGresSQL
            //PostGreSQL postGresSQL = new PostGreSQL();
            //postGresSQL.PostgreSQLtest1();

            //Application.Run(new FormDangNhap());

            //PostGreSQL pgs = new PostGreSQL();
            //List<string> l = pgs.GetDataNhomThuoc();

            //foreach(string s in l)
            //{
            //Console.WriteLine(s);
            //}

            //Form1 form1 = new Form1();
        }
    }
}
