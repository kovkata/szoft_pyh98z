namespace a_kigyo_kigyoznak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public int l�p�ssz�m = 0;
        int fej_x = 100;
        int fej_y = 100;
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int hossz = 4;
        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();
        Random random= new Random();    

        Alma a = new Alma();
        M�reg m = new M�reg();
        private void Form1_Load(object sender, EventArgs e)
        {

            a.Top = random.Next(0, ClientRectangle.Height / K�gy�Elem.M�ret) * K�gy�Elem.M�ret;
            a.Left = random.Next(0, ClientRectangle.Width / K�gy�Elem.M�ret) * K�gy�Elem.M�ret;
            Controls.Add(a);


            m.Top = random.Next(0, ClientRectangle.Height / K�gy�Elem.M�ret )*K�gy�Elem.M�ret;
            m.Left = random.Next(0, ClientRectangle.Width / K�gy�Elem.M�ret) * K�gy�Elem.M�ret;
            Controls.Add(m);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;
            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }
            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            k�gy�.Add(ke);
            Controls.Add(ke);





            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Salmon;

            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            } 
            if(a.Top == fej_y && a.Left == fej_x)
            {
                hossz++;
                a.Top = random.Next(0, ClientRectangle.Height / K�gy�Elem.M�ret) * K�gy�Elem.M�ret;
                a.Left = random.Next(0, ClientRectangle.Width / K�gy�Elem.M�ret) * K�gy�Elem.M�ret;

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
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}