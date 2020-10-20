using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace timer
{
    public partial class SEGON : Form
    {
        public SEGON()
        {
            InitializeComponent();
        }

        int attempt = 0;
        int attempt_limit = 3;
        string username;
        string password;
        string nombre_archivo;
        private void button1_Click(object sender, EventArgs e)
        {

            username = textBox1.Text;
            password = textBox3.Text;

            if ((username == "Admin") && (password == "admin"))
            {
                MessageBox.Show("ACCESO GARANTIZADO");
                Application.Exit();
            }

            else
            {
                attempt++;
                MessageBox.Show("Falló en " + attempt + " intentos de inicio de sesión. Acceso no autorizado");
                try
                {
                    nombre_archivo = "log_error.log";
                    //System.IO.File.WriteAllText(@"C:\Carlos_MSI_SDS\S2AM\M20 - DUAL\MESSI\DUAL-master\" + nombre_archivo, text);
                    System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Carlos_MSI_SDS\S2AM\M20 - DUAL\MESSI\DUAL-master\" + nombre_archivo, true);
                    //File.AppendAllText(@"C:\Carlos_MSI_SDS\S2AM\M20 - DUAL\MESSI\DUAL-master\" + nombre_archivo, nombre_archivo.ToString());
                    file.WriteLine(DateTime.Now.ToString("yyyyMMdd") + ":" + DateTime.Now.ToString("HHmmss") + ":" + username);
                    file.Close();
                }
                catch (Exception) { }

                this.textBox1.Text = String.Empty;
                this.textBox3.Text = String.Empty;
            }


            if (attempt == attempt_limit)
            {
                MessageBox.Show("Llegó al número máximo de intentos de inicio de sesión. El programa se cerrará");

                Application.Exit();
            }
        }

        private void SEGON_Load(object sender, EventArgs e)
        {

        }
    }
}