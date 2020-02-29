using BLL;
using GUI.ArquivosMortos.Emprestimos;
using GUI.Login;
using GUI.Menu_Iniciar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]

        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (ConfiguracoesBLL.BuscarLogin()) Application.Run(new frmLogin());
                else Application.Run(new frmMenu());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Iniciar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}