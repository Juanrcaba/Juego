using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Juego.Formularios
{
    public partial class frmGameTable : Form
    {
        public frmGameTable()
        {
            InitializeComponent();
        }
        //variables publicas
        public float filas = 0, columnas = 0;
       
        List<string> validar = new List<string>();
        float contador = 0;
        int Intentos = 10;

        private void frmGameTable_Load(object sender, EventArgs e)
        {
            float qty_botones = filas * columnas;           
            btnGenerate((int)qty_botones);
            lbl_progreso.Text = (contador).ToString() + "%";
            lbl_intentos.Text = Intentos.ToString();
            //this.MaximumSize = new System.Drawing.Size(460, 460);
            //this.MinimumSize = new System.Drawing.Size(460, 460);
            
        }

        //funcion para generar botones
        void btnGenerate(int btnQty)
        {
            List<int> prueba = DesordenarLista(aleatorios(btnQty / 2)); 
            for (int i = 0; i < btnQty; i++)
            {
                Button btn = new Button();
                btn.Text = "Click Me!!";
                btn.Name = prueba[i].ToString();
                btn.Height = 87;
                btn.Width = 98;
                btn.Font = new Font(btn.Name, 10, FontStyle.Bold);                
                btn.Click += new EventHandler(btn_event);
                container.Controls.Add(btn);
            }
        }

        //funcion evento de botones
        void btn_event(object sender, EventArgs e)
        {
            ((Button)sender).Text = ((Button)sender).Name;
            ((Button)sender).Font = new Font(((Button)sender).Name, 25);
            if (validar.Count < 2) { validar.Add(((Button)sender).Name); ((Button)sender).Enabled = false; };
            if(validar.Count == 2)
            {
                SoundPlayer player = new SoundPlayer();
                if (validar[0] == validar[1])
                {
                    foreach (Control item in container.Controls)
                    {
                        if (item is Button)
                        {
                            if (item.Text == validar[0].ToString()) { item.Enabled = false; }                      
                                                   
                          
                        }
                    }
                    player.SoundLocation = @"C:\Users\Juan Santos\source\repos\Juego\Formularios\Sounds/mario-correct.wav";
                    player.Play();
                    lbl_progreso.Text = (contador += (100 / ((filas * columnas) / 2))).ToString("#,###.##") + "%";
                     
                }
                else
                {                   
                    player.SoundLocation = @"C:\Users\Juan Santos\source\repos\Juego\Formularios\Sounds/error.wav";
                    player.Play();
                    Thread.Sleep(1000);
                    Intentos -= 1;
                    foreach (Control item in container.Controls)
                    {
                        if (item is Button)
                        {
                            if (item.Text == validar[0] || item.Text == validar[1]) {
                                item.Text = "Click Me!!";
                                item.Font = new Font(item.Name, 10, FontStyle.Bold);
                                item.Enabled = true;
                            }
                        }
                    }
                    lbl_intentos.Text = Intentos.ToString();
                }
                validar.Clear();
                if (Intentos == 0) TryAgain("Perdiste");
                if (contador == 100) TryAgain("Ganaste");
            }
        }
        //aleatorios
        List<int> aleatorios(int qty)
        {
            Random rand = new Random();
            int nrand = 0, qty1 = qty,qty2 = qty;
            bool condicion = false;
            List<int> lst1 = new List<int>();
            List<int> lst2 = new List<int>();

            for (int i = 0; i < qty1; i++)
            {                
                nrand = rand.Next(1, qty + 1);
                for (int j = 0; j < lst1.Count; j++)
                {
                    if (nrand == lst1[j]) { condicion = true; break; }
                }
                if (condicion)
                {
                    qty1 += 1;
                    condicion = false;
                }
                else
                {
                    lst1.Add(nrand);
                }
            }
            for (int i = 0; i < qty2; i++)
            {
                nrand = rand.Next(1, qty + 1);
                for (int j = 0; j < lst2.Count; j++)
                {
                    if (nrand == lst2[j]) { condicion = true; break; }
                }
                if (condicion)
                {
                    qty2 += 1;
                    condicion = false;
                }
                else
                {
                    lst2.Add(nrand);
                }
            }

            List<int> lista = new List<int>();  
            lista.AddRange(lst1);          
            lista.AddRange(lst2);
           
            return lista;
        }
         List<T> DesordenarLista<T>(List<T> input)
        {
            List<T> arr = input;
            List<T> arrDes = new List<T>();

            Random randNum = new Random();
            while (arr.Count > 0)
            {
                int val = randNum.Next(0, arr.Count - 1);
                arrDes.Add(arr[val]);
                arr.RemoveAt(val);
            }

            return arrDes;
        }

        private void frmGameTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // funcion Volver a jugar
        void TryAgain(string mensaje)
        {
            SoundPlayer player = new SoundPlayer();
            
            if (mensaje.Equals("Ganaste")) {
                player.SoundLocation = @"C:\Users\Juan Santos\source\repos\Juego\Formularios\Sounds/win.wav";
            }
            else {
                player.SoundLocation = @"C:\Users\Juan Santos\source\repos\Juego\Formularios\Sounds/gameover.wav";
            }
            player.Play();
            if (DialogResult.OK == MessageBox.Show("Press OK to Tray Again or Cancel to Close the Game",mensaje,MessageBoxButtons.OKCancel,MessageBoxIcon.Information ))
            {
                container.Controls.Clear();
                float qty_botones = filas * columnas;
                btnGenerate((int)qty_botones);
                contador = 0;              
                Intentos = 10;
                lbl_progreso.Text = (contador).ToString() + "%";
                lbl_intentos.Text = Intentos.ToString();

            }
            else
            {
                frmPrincipal form = new frmPrincipal();
                form.Show();
                this.Hide();
            }
        }
    }
}
