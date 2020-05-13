using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Muestra1
{
    public partial class Form1 : Form
    {
        //Permite la conexion entre visual y postgres
        NpgsqlConnection conexion = new NpgsqlConnection();

        //Esta cadena permitrá la ejecucion de comandos SQL
        string cadenaConexion;

        String codImagen;

        byte[] imagenBytes;

        String tipo;

        public Form1()
        {
            InitializeComponent();


            //Validando inicio de sesion
            cadenaConexion = "Server = 127.0.0.1; Port = 5432; Database = muestra1;" +
                " User ID = postgres;" + " Password = c593a0de27;";

            conexion.ConnectionString = cadenaConexion;
            try
            {
                conexion.Open();
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                conexion.Close();
            }

            if (conexion.State.ToString() == "Open")
            {
                MessageBox.Show("Sesión confirmada");
            }
        }
        
        static string BytesToString(byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }

        //Convierte una cadena de bytes en un mapa de bits visualisable como imagen
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void btnMostrarImagen_Click(object sender, EventArgs e)
        {
            //VER TODAS LAS NOTAS SEGUN NUMERO DE MATRICULA
            string sql2 = ("SELECT imagen FROM esquemaMuestra.Imagen WHERE idimagen = 1;");
            Boolean existe = false;
            
            using (NpgsqlCommand command1 = new NpgsqlCommand(sql2, conexion))
            {
                NpgsqlDataReader reader = command1.ExecuteReader();

                while (reader.Read())
                {
                    existe = true;
                    imagenBytes = (byte[])reader[0]; 
                }
                reader.Close();
            }
            if (existe == false)
            {
                MessageBox.Show("No se obtuvo nada");
                return;
            }
            else
            {
                MessageBox.Show("Existe");
                /*
                imagenBytes = ObjectToByteArray(objeto);
                MessageBox.Show("imageBytes: " + imagenBytes.ToString());*/

                string str = BytesToString(imagenBytes);
                MessageBox.Show("The String is: " + str.Substring(1,2));
                Console.WriteLine("The String is: INICIO " + str + " FIN ");

                pbxImagen.Image = ByteToImage(imagenBytes);
                //pbxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        Boolean camposNoValidos = false;
        private void Evaluar_Click(object sender, EventArgs e)
        {
            camposNoValidos = false;
            lblTexto1.ForeColor = txtTexto1.Text.Length > 30 ? Color.Red : Color.Black;
            camposNoValidos = lblTexto1.ForeColor == Color.Red ? true : camposNoValidos;

            if (camposNoValidos)
            {
                MessageBox.Show("Texto no admitido");
                return;
            }
            else
            {
                MessageBox.Show("Texto admitido");
                txtContraseña.Text = GenerarPassword(8);
            }
                

        }

        //Metodo para generar una contraseña
        public static string GenerarPassword(int longitud)
        {
            string contraseña = string.Empty;
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Random EleccionAleatoria = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int LetraAleatoria = EleccionAleatoria.Next(0, 100);
                int NumeroAleatorio = EleccionAleatoria.Next(0, 9);

                if (LetraAleatoria < letras.Length)
                {
                    contraseña += letras[LetraAleatoria];
                }
                else
                {
                    contraseña += NumeroAleatorio.ToString();
                }
            }
            return contraseña;
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void btnCentrarComponente_Click(object sender, EventArgs e)
        {
            centraX(comboBox1, lblSexo);
        }
        public static void centraX(Control padre, Control hijo)
        {
            int xHijo = 0;
            
            //Punto X de la ubicacion padre mas la diferencia de los anchos de las mitades de los componentes
            xHijo = padre.Location.X + ( (padre.Width / 2) - (hijo.Width / 2) );

            //Asignando la ubicación del componente hijo
            hijo.Location = new System.Drawing.Point(xHijo, hijo.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Sergio se la come");
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton 3");
        }
    }
}
