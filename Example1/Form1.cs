using System.CodeDom.Compiler;

namespace Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //8x8 lik dama tahtasý yapmak istiyoruz bunu da program çalýþtýðýnda kendisi
        //otomatik olarak oluþturmasýný istiyoruz.
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();//ilgili metodu çaðýrarak kodlarý çalýþtýrdýk.
        }



        private void GenerateButtons() //oluþturduðumuz kodu metod haline getirdik.
        {
            /*tanýmlama için yazýldý örenk olsun diye kullanýlmayacak.
            Button button = new Button();//buton isminde nesne oluþturuyoruz.
            button.Width = 50;//buton özelliklerinden geniþlik özelliði
            button.Height = 50;//buton özelliklerinden yükseklik özelliði
            //button.Text = "My Buton"; //buton özelliklerinden isim özelliði
            this.Controls.Add(button);//butonu ekrana koy 
            
            ---------------*******************----------------

            *Yapacaðýmýz iþlem 8x8 64 adet buton oluþturmak olduðu için yukarýdaki kod
            * bloðunu 64 defa yazarak yapabiliriz ki bu hamallýk olur. ikinci bir yön-
             * tem ise for ile döngü kurabiliriz.
             * for (int i = 1; i <= 64; i++)
                {

                }
             * Bu da oluþturduðumuz butonlar sayý olarak 64 ü yakalacayacak fakat
             * hepsi üst üste gelceðinden ayrý ayrý iþlem yapmaya çalýþtýðýmýzda
             * karþýmýza problem olarak gelecektir. her butona ayrý ayrý eriþim saðla
             * yabilmek için daha doðrusu ayný iþlemden farklý nesneler oluþturup kont
             * rolde tutmak için dizi yapýsýný kullanmak çok mantýklý olacaktýr
             */

            Button[,] buttons = new Button[8, 8];//iki boyutlu 8 e 8 elamanlý bir dizitanýmlýyoruz.
            int top=0;
            int left=0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)//for döngüsü ile dizinin GetUpperBound
            //(alabileceði en büyük eleman) sayýsý kadar ilk 8 li dizide döngü kuruyoruz.
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)//ayný þekilde ikinci
                //8li dizi için de döngü kuruyoruz.
                {
                    buttons[i, j] = new Button();//her turda yeni buton oluþacaðýndan new
                    //komutu koþmamýz lazým.
                    buttons[i,j].Width = 50;//i ve j için geniþlik verildi
                    buttons[i,j].Height = 50;//i ve j için yükseklik verildi
                    buttons[i,j].Left = left;//ilgili butonun soldan uzaklýðý özelliðini
                    //yukarýda tanýmladýðýmýz left deðiþkenine (left=0) atýyoruz.
                    buttons[i,j].Top = top;//ilgili butonun üstten uzaklýðý özelliðini yukarýda 
                    //tanýmladýðýmýz top deðiþkenine (top=0) atýyoruz.
                    left += 50;//her döngüde left deðiþkenini 50 artýrýyoruz ki yan yana 
                    //oluþturabilsin.

                    if ((i+j) % 2 == 0)//i+j nin toplamýnýn 2 ile bölümünden kalan 0 ise yani her 
                    //turda bir çift bir tek geleceði için 
                    {
                        buttons[i, j].BackColor = Color.Black;//sayý çift ise arkaplan siyah
                    }
                    else
                    {
                        buttons[i,j].BackColor = Color.White;//sayý tek ise arkaplan beyaz
                    }
                    this.Controls.Add((Button)buttons[i,j]);//ilgili form için buton ekle-
                    //me komutu eklendi. Her i ve j için buton ekleyecektir.
                }
                left = 0;//döngü bitiminde left deðiþkenini 0 a eþitliyoruz. yan yana 
                //koyduðu botunlar döngü sayýsý kadar olsun.Not: Burada 64 botun oluþtura-
                //cak fakat 8 yanyana olacak diðerleri gene hep üstüne binecek. çünkü satýr 
                //kaydýrmasý yaptýk henüz sutun kaydýrmasý ortada yok.
                top += 50;//satýr döngüsü bittiðinde top deðiþkenini 50 artýrýyoruz ki buton 
                //ölçüsü kadar alt sutun a geçsin. Not: 77 ve 81 inci satýrlar iç for iþlemi
                //bittikten sonra dýþ for da iþlem yapacaktýr.
            }



        }
    }
}
