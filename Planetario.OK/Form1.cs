using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Planetario.OK
{
    public partial class Form1 : Form
    {
        bool running = false;

        Timer timer = new Timer();

        Planetario planetario = new Planetario();
        Vector vectorInstance = new Vector();

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Paint += new PaintEventHandler(SolarSystem);
            
            timer.Tick += new EventHandler(tiktak_Tick);
        }

        private void SolarSystem(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            foreach (var pianeta in planetario.Pianeti)
            {
                pianeta.DisegnaPianeta(g);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            running = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            running = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                if (!CheckTextBox()) return;

                Pianeta p = new Pianeta(Vector.Parse(txtVelocita.Text), double.Parse(txtMassa.Text), Vector.Parse(txtPosizione.Text));
                p.Colore = GetColor();

                lstPianeti.Items.Add(p);
                planetario.Pianeti.Add(p);

                txtVelocita.Clear();
                txtPosizione.Clear();
                txtMassa.Clear();
                txtNome.Clear();
            } else
            {
                MessageBox.Show("Non puoi aggiungere mentre il programma sta andando");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                int index = lstPianeti.SelectedIndex;
                if (index == -1)
                {
                    MessageBox.Show("Nessun elemento è stato selezionato");
                }
                if (index >= 0)
                {
                    lstPianeti.Items.RemoveAt(index);
                    planetario.Pianeti.RemoveAt(index);
                }
            } else
            {
                MessageBox.Show("Non puoi aggiungere mentre il programma sta andando.");
            }
        }

        private bool CheckTextBox()
        {
            if (!vectorInstance.TryParse(txtVelocita.Text, out Vector velocita))
            {
                MessageBox.Show("La velocità inserita non corrisponde a un vettore");
                return false;
            }
            if (!vectorInstance.TryParse(txtPosizione.Text, out Vector posizione))
            {
                MessageBox.Show("La posizione inserita non corrisponde a un vettore");
                return false;
            }
            if (!double.TryParse(txtMassa.Text, out var massa))
            {
                MessageBox.Show("La massa inserita non è un numero");
                return false;
            }
            return true;
        }

        private Color GetColor()
        {
            switch(txtNome.Text)
            {
                case "Sole":
                    return Color.Gold;
                case "Mercurio":
                    return Color.DarkGray;
                case "Venere":
                    return Color.Peru;
                case "Terra":
                    return Color.CornflowerBlue;
                case "Marte":
                    return Color.Coral;
                case "Giove":
                    return Color.DarkGoldenrod;
                case "Saturno":
                    return Color.Tan;
                case "Urano":
                    return Color.SkyBlue;
                case "Nettuno":
                    return Color.DodgerBlue;
                default: 
                    return Color.White;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                if (lstPianeti.Items.Count == 0)
                {
                    MessageBox.Show("Nessun elemento è presente nella lista");
                }
                else
                {
                    lstPianeti.Items.Clear();
                    planetario.Pianeti.RemoveRange(0, planetario.Pianeti.Count - 1);
                }
            }
            else
            {
                MessageBox.Show("Non puoi rimuovere elementi mentre il programma sta andando");
            }
        }

        private void tiktak_Tick(object sender, EventArgs e)
        {
            timer.Interval = 100;
            planetario.Traiettoria((float)timer.Interval / 1000);
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "..\\..\\..\\background.jpg");
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
