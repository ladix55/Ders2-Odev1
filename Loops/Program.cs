using System.Runtime.CompilerServices;

internal class Program
{
    /*Girilen bir sayının asal olup olmadığını bulmak için bir program yazalım. Bunun algoritması öncelikle asal sayı-
     * nın tanımdan başlar. Asal sayı kendisi ve bir hariç tam böleni olmayan sayıdır.
     * 2 (iki) den kendisinin 1 (bir) eksiğine kadar döngü kurarsak, bu aradaki bütün sayıları kendisine bölmeye çalış-
     * sak bölünebiliyor ise asaldeğildir, bölünemiyor ise asaldır.
     */

    /*Metod yazıyoruz asal ise treu asal değilse false döndürsün. Sonucu tutmak için result tanımlıyoruz. For döngüsü
     * ile 2 den sayının 1 eksiğine kadar döngüde dönelim. Döngünün her turunda if ile sayının i ye bölümünden kalanın 
     * 0 olup olmadığının kontrol yapısını kuruyoruz. Çıkan sonuç tam bölünebilir olduğundan dolayı sonucu tutan 
     * result değişkenini false yaparak o sayının asal olmadıını söylüyoruz. Fakat programın gereksiz çalışmamasını 
     * engellemek için if bloğunda sayı asal değilse i=number değeri ile programın for a tekrar girmesi engellenir.
     * program alt kısımdan çalışmaya devam eder.
     * */

    private static bool IsPrimeNumber(int number3) //int number asal mı?
    {
        bool result = true;//Sonuç değişkenini tutmak için bool tanımlanıyor ve true değeri veriliyor.

        for (int i = 2; i < number3 - 1; i++)//for ile 2den başlayarak number değerinin 1 eksiğine kadar döngüde dönülür
        {
            if (number3 % i == 0)//if ile inin o anki değerinin 2 ile bölümünden kalanının 0 olup olmadığına bakılır
            {
                result = false;//Sonuç yanlış ise result false e çekilir
                //i = number3;//programın gereksiz çalışmaması için for a tekrar girmesin diye i yi number a eşitliyoruz.
            }
        }
     
        return result;//geriye result dönüyor.
    }

    //Döngüler (loops) bir veri kümesinin içinde dolaşmak için kullanılır.
    private static void Main(string[] args)
    {
        //for aslında dönüş verisi olarak true veya false döner. koşul sağlandığı sürece true, sağlanmadığında 
        //false döner ve ilgili bloktan çıkar.
        for (int i = 0; i <= 20; i=i+2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Finished!");
        
        Console.WriteLine("--------****-------");

        //While döngüsü şart olarak sürekli true döner. Döngü içerisinde matematiksel işlem (artırma yada eksiltme)
        //yapılmaz ise sonsuz döngüde kalır.
        int number = 100;
        while (number >=0 )
        {
            Console.WriteLine(number);
            number--;
        }
        //En son değerin -1 gelmesinin sebebi döngünün son turunda rakamı azltıp döngüye girmemesinden kaynaklanır.
        Console.WriteLine("Now number is {0}",number);

        Console.WriteLine("--------****-------");

        //Do while döngüsü normal while döngüsünden farkı do bloğunun en az bir kere çalışıyor olmasıdır.
        //Şart sağlanmasa bile en az bir kere döngüye girmektedir.
        int number2 = 10;
        do
        {
            Console.WriteLine(number2);
            number--;
        }
        while (number2 >= 11);

        Console.WriteLine("--------****-------");

        //foreach döngüsü genelde dizi elemanlarını dönmek için kullanılır.
        string[] stundents = new string[3] { "Serhat", "Alp", "Latin" };

        foreach (var stundent in stundents)
        {
            Console.WriteLine(stundent);
        }

        Console.WriteLine("--------****-------");

        //3-33 satılar arasındaki örnek program için;

        if (IsPrimeNumber(7)) //6 ve 7 için denemeler yapıyoruz.
        {
            Console.WriteLine("7 sayısı içina "+"This is a prime number");
        }
        else
        {
            Console.WriteLine("6 sayısı için "+"This is not a prime number");
        }

        Console.WriteLine("--------****-------");


        Console.ReadLine();
    }


   
}