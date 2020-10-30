using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace timer
{
    public partial class Coordenadas : Form
    {
        public Coordenadas()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{


        //    //if (Diccionario1.ContainsKey(id_codigo[i]))
        //    //{
        //    //    Diccionario1.Remove(id_codigo[i]);
        //    //    i--;
        //    //}
        //    //else
        //    //{
        //    //    Label label_panel = new Label();
        //    //    label_panel.Width = 80;
        //    //    label_panel.Height = 80;
        //    //    label_panel.BackColor = Color.White;
        //    //    label_panel.Text = Diccionario1[id_codigo[i]].ToString();
        //    //    tableLayoutPanel1.Controls.Add(label_panel);
        //    //}

        //}

        Dictionary<String, String> Diccionario1;
        String[] id_codigo = new string[20];

        public string Obtener_numero()
        {
            int numero;
            String numero_cadena;
            Random r = new Random();
            Diccionario1 = new Dictionary<String, String>();

            numero = r.Next(0, 9999);
            numero_cadena = numero.ToString();

            if (numero_cadena.Length == 1)
            {
                numero_cadena = "000" + numero_cadena;
            }

            else if (numero_cadena.Length == 2)
            {
                numero_cadena = "00" + numero_cadena;
            }

            else if (numero_cadena.Length == 3)
            {
                numero_cadena = "0" + numero_cadena;
            }

            return numero_cadena;
        }

        public void Coordenadas_Load(object sender, EventArgs e)
        {
            //Diccionario1 = new Dictionary<String, String>();
            //Random r = new Random();
            //int numero;
            String letra;
            //String numero_cadena;
            String codigo;

            char[] char_codigo_letra = "ABCD".ToCharArray();
            char[] char_codigo_numero = "12345".ToCharArray();

            int acumulador_letra = 0;
            int acumulador_codigo = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int o = 0; o < 5; o++)
                {
                    id_codigo[acumulador_codigo] = char_codigo_letra[acumulador_letra].ToString() + char_codigo_numero[o].ToString();
                    acumulador_codigo++;
                }
                acumulador_letra++;
            }

            //String dc_primer_valor = Obtener_numero();

            //Diccionario1.Add(id_codigo[0], dc_primer_valor);


                for (int i = 0; i < 20; i++)
            {
                String dc_valor;
                dc_valor = Obtener_numero();
                while (Diccionario1.ContainsValue(dc_valor) == true)
                {
                    dc_valor = Obtener_numero();
                }

                Diccionario1.Add(id_codigo[i], dc_valor);
                //Label label_panel = new Label();
                //label_panel.Width = 80;
                //label_panel.Height = 80;
                //label_panel.BackColor = Color.White;
                //label_panel.Text = Diccionario1[id_codigo[i]]
                ///*label_panel.Text = Diccionario1[id_codigo[i]].ToString()*/;
                //tableLayoutPanel1.Controls.Add(label_panel);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (KeyValuePair<string, string> entry in Diccionario1)
            {
                Label label_panel = new Label();
                label_panel.Width = 80;
                label_panel.Height = 80;
                label_panel.BackColor = Color.White;
                label_panel.Text = Diccionario1[id_codigo[i]].ToString();
                /*label_panel.Text = Diccionario1[id_codigo[i]].ToString()*/
                tableLayoutPanel1.Controls.Add(label_panel);
                i++; 
            }
        }
    }
}

