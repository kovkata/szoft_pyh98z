namespace a_kigyo_kigyoznak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public int lépésszám = 0;
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int hossz = 4;
        List<KígyóElem> kígyó = new List<KígyóElem>();
        Random random= new Random();    

        Alma a = new Alma();
        Méreg m = new Méreg();
        private void Form1_Load(object sender, EventArgs e)
        {

            a.Top = random.Next(0, ClientRectangle.Height / KígyóElem.Méret) * KígyóElem.Méret;
            a.Left = random.Next(0, ClientRectangle.Width / KígyóElem.Méret) * KígyóElem.Méret;
            Controls.Add(a);


            m.Top = random.Next(0, ClientRectangle.Height / KígyóElem.Méret )*KígyóElem.Méret;
            m.Left = random.Next(0, ClientRectangle.Width / KígyóElem.Méret) * KígyóElem.Méret;
            Controls.Add(m);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;
            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }
            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kígyó.Add(ke);
            Controls.Add(ke);





            if (lépésszám % 2 == 0) ke.BackColor = Color.Salmon;

            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            } 
            if(a.Top == fej_y && a.Left == fej_x)
            {
                hossz++;
                a.Top = random.Next(0, ClientRectangle.Height / KígyóElem.Méret) * KígyóElem.Méret;
                a.Left = random.Next(0, ClientRectangle.Width / KígyóElem.Méret) * KígyóElem.Méret;

            }

            if (m.Top == fej_y && m.Left == fej_x)
            {
                timer1.Enabled = false;
                return;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}