namespace Mayin_Tarlasi.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            ButonOlustur();
        }
        private Dictionary<Button, bool> mayinlar = new Dictionary<Button, bool>();
        private void ButonOlustur()
        {
            grpMayinlar.Controls.Clear();
            mayinlar.Clear();

            Random rnd = new Random();
            int buttonBoyutu = 20;
            int bosluk = 5;

            int sutunSayisi = grpMayinlar.Height / (buttonBoyutu + bosluk);
            int satirSayisi = grpMayinlar.Width / (buttonBoyutu + bosluk);


            int toplamGenislik = satirSayisi * (buttonBoyutu + bosluk) - bosluk;
            int toplamYukseklik = sutunSayisi * (buttonBoyutu + bosluk) - bosluk;


            int baslangicX = (grpMayinlar.Width - toplamGenislik) / 2;
            int baslangicY = (grpMayinlar.Height - toplamYukseklik) / 2;

            int konumX = baslangicX;
            int konumY = baslangicY;
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    Button button = new Button();
                    button.Width = buttonBoyutu;
                    button.Height = buttonBoyutu;
                    button.Location = new Point(konumX, konumY);
                    button.BackColor = Color.White;

                    button.Click += Button_Click;

                    bool mayinVarMi = rnd.Next(100) < 20 ? true : false; //%20 ihitmalle mayýn atama

                    mayinlar.Add(button, mayinVarMi);
                    grpMayinlar.Controls.Add(button);

                    konumX += buttonBoyutu + bosluk;
                }
                konumX = baslangicX;
                konumY += buttonBoyutu + bosluk;
            }
        }
        int sayac = 0;
        private void Button_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (mayinlar[btn] == true)
            {
                btn.BackColor = Color.Red;

                MessageBox.Show("OYUN BÝTTÝ!!!");
                Application.Exit();

            }
            else
            {

                btn.BackColor = Color.Green;
                sayac++;
                if(sayac==80)
                {
                    MessageBox.Show("Tebrikler Kazandýnýz!!!");
                }
            }
        }

       
    }
}
