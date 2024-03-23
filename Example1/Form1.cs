using System.CodeDom.Compiler;

namespace Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //8x8 lik dama tahtas� yapmak istiyoruz bunu da program �al��t���nda kendisi
        //otomatik olarak olu�turmas�n� istiyoruz.
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();//ilgili metodu �a��rarak kodlar� �al��t�rd�k.
        }



        private void GenerateButtons() //olu�turdu�umuz kodu metod haline getirdik.
        {
            /*tan�mlama i�in yaz�ld� �renk olsun diye kullan�lmayacak.
            Button button = new Button();//buton isminde nesne olu�turuyoruz.
            button.Width = 50;//buton �zelliklerinden geni�lik �zelli�i
            button.Height = 50;//buton �zelliklerinden y�kseklik �zelli�i
            //button.Text = "My Buton"; //buton �zelliklerinden isim �zelli�i
            this.Controls.Add(button);//butonu ekrana koy 
            
            ---------------*******************----------------

            *Yapaca��m�z i�lem 8x8 64 adet buton olu�turmak oldu�u i�in yukar�daki kod
            * blo�unu 64 defa yazarak yapabiliriz ki bu hamall�k olur. ikinci bir y�n-
             * tem ise for ile d�ng� kurabiliriz.
             * for (int i = 1; i <= 64; i++)
                {

                }
             * Bu da olu�turdu�umuz butonlar say� olarak 64 � yakalacayacak fakat
             * hepsi �st �ste gelce�inden ayr� ayr� i�lem yapmaya �al��t���m�zda
             * kar��m�za problem olarak gelecektir. her butona ayr� ayr� eri�im sa�la
             * yabilmek i�in daha do�rusu ayn� i�lemden farkl� nesneler olu�turup kont
             * rolde tutmak i�in dizi yap�s�n� kullanmak �ok mant�kl� olacakt�r
             */

            Button[,] buttons = new Button[8, 8];//iki boyutlu 8 e 8 elamanl� bir dizitan�ml�yoruz.
            int top=0;
            int left=0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)//for d�ng�s� ile dizinin GetUpperBound
            //(alabilece�i en b�y�k eleman) say�s� kadar ilk 8 li dizide d�ng� kuruyoruz.
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)//ayn� �ekilde ikinci
                //8li dizi i�in de d�ng� kuruyoruz.
                {
                    buttons[i, j] = new Button();//her turda yeni buton olu�aca��ndan new
                    //komutu ko�mam�z laz�m.
                    buttons[i,j].Width = 50;//i ve j i�in geni�lik verildi
                    buttons[i,j].Height = 50;//i ve j i�in y�kseklik verildi
                    buttons[i,j].Left = left;//ilgili butonun soldan uzakl��� �zelli�ini
                    //yukar�da tan�mlad���m�z left de�i�kenine (left=0) at�yoruz.
                    buttons[i,j].Top = top;//ilgili butonun �stten uzakl��� �zelli�ini yukar�da 
                    //tan�mlad���m�z top de�i�kenine (top=0) at�yoruz.
                    left += 50;//her d�ng�de left de�i�kenini 50 art�r�yoruz ki yan yana 
                    //olu�turabilsin.

                    if ((i+j) % 2 == 0)//i+j nin toplam�n�n 2 ile b�l�m�nden kalan 0 ise yani her 
                    //turda bir �ift bir tek gelece�i i�in 
                    {
                        buttons[i, j].BackColor = Color.Black;//say� �ift ise arkaplan siyah
                    }
                    else
                    {
                        buttons[i,j].BackColor = Color.White;//say� tek ise arkaplan beyaz
                    }
                    this.Controls.Add((Button)buttons[i,j]);//ilgili form i�in buton ekle-
                    //me komutu eklendi. Her i ve j i�in buton ekleyecektir.
                }
                left = 0;//d�ng� bitiminde left de�i�kenini 0 a e�itliyoruz. yan yana 
                //koydu�u botunlar d�ng� say�s� kadar olsun.Not: Burada 64 botun olu�tura-
                //cak fakat 8 yanyana olacak di�erleri gene hep �st�ne binecek. ��nk� sat�r 
                //kayd�rmas� yapt�k hen�z sutun kayd�rmas� ortada yok.
                top += 50;//sat�r d�ng�s� bitti�inde top de�i�kenini 50 art�r�yoruz ki buton 
                //�l��s� kadar alt sutun a ge�sin. Not: 77 ve 81 inci sat�rlar i� for i�lemi
                //bittikten sonra d�� for da i�lem yapacakt�r.
            }



        }
    }
}
