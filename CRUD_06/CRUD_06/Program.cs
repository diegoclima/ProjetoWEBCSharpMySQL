using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_06 {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Validacao vld = new Validacao();
            vld.Show();

            if (vld.ShowDialog()== DialogResult.OK) {
                Application.Run(new Form1());
            }
           
            
           
        }
    }
}
