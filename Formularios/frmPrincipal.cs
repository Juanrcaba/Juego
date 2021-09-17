using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer();
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmb_level.SelectedIndex = 0;
            //SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Juan Santos\source\repos\Juego\Formularios\Sounds/intro.wav";
            player.Play();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            frmGameTable form = new frmGameTable();
            int lvl = cmb_level.SelectedIndex;
            player.Stop();
            switch (lvl)
            {
                case 0:
                    form.filas = 4;
                    form.columnas = 4;                    
                    form.MaximumSize =  new System.Drawing.Size(460, 460);
                    form.MinimumSize = new System.Drawing.Size(460, 460);
                    form.Show();                   
                    this.Hide();
                    break;
                case 1:
                    form.filas = 5;
                    form.columnas = 4;
                    form.MaximumSize = new System.Drawing.Size(466, 554);
                    form.MinimumSize = new System.Drawing.Size(466, 554);
                    form.Show();
                    this.Hide();
                    break;
                case 2:
                    form.filas = 5;
                    form.columnas = 6;
                    form.MaximumSize = new System.Drawing.Size(470, 554);
                    form.MinimumSize = new System.Drawing.Size(470, 554);
                    form.Show();
                    this.Hide();
                    break;
                case 3:
                    form.filas = 6;
                    form.columnas = 7;
                    form.MaximumSize = new System.Drawing.Size(666, 750);
                    form.MinimumSize = new System.Drawing.Size(666, 750);
                    form.Show();
                    this.Hide();
                    break;
                
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
