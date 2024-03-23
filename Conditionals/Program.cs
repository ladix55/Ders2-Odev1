using System;

internal class Program
{
    //yeni proje oluşturduğumuz, Solution alanında birden fazla projemiz olduğundan dolayı, hiç bir işlem yapmazsak
    //son çalıştığımız proje aktifdir ve çalıştır kısmında halen o çalışır.
    //yeni projeye sağ tıklayıp 'Set as Startup Projects' dersek aktif proje bu olmuş olur.

    private static void Main(string[] args)
    {
        //Öncelikle bir değişken tanımlıyoruz. Bu genelde değişen bir değer yada parametre sonucu dönen bir değer
        //olarak karşımıza çıkar. if çalıştırmak için biz sabit değer tuttuk.
        var number1 = 10;
        //if komutu için if yazıp iki (2) kez tab tuşuna başılırsa ilgili blok otomatik oluşacaktır. Burada ki ama-
        //cımız sayı değerinin 10 olup olmadığına bakmaktır.
        //Mantıklsa operatörlerde, '=' değeri atama olduğu için eşit midir derken çift '==' kullanıyoruz.

        if (number1 == 10) //Çalışma mantığı doğru olduğu durumda True yanlış olduğu durumda False döndürür
        {
            //Eğer number1 10 a eşit ise if blok içi çalıştırılır.
            Console.WriteLine("number1 is 10");
        }
        else
        {
            //Eğer number1 10 a eşit değilse else altındaki bloklar çalıştırılır.
            Console.WriteLine("number1 is not 10");
        }

        Console.WriteLine("----------oooooooooo----------");

        //standart if yapısı haricinde bir de böyle bir kullanım mevcuttur.
        //Single line if yapısı tek satırda if sorgusu 
        Console.WriteLine("Single line if ->");
        Console.WriteLine(number1 == 10 ? "Number1 is 10" : "Number is not 10");

        Console.WriteLine("----------oooooooooo----------");

        //******************************************---------------------------**************************************

        //if şartlarının birden fazla olduğu durumda if-else if kullanılır.

        var number2 = 16;

        if (number2 == 15)
        {
            //number2 değişkeni 15 e eşit ise if bloğu
            Console.WriteLine("number2 is 15");
        }
        else if (number2 == 20)
        {
            //number2 değişkeni 20 ye eşit ise else if bloğu
            Console.WriteLine("number2 is 20");
        }
        else
        {
            //her iki durumda sağlanmıyorsa bu durumda else bloğu çalışacaktır.
            Console.WriteLine("number2 is not 10 or 20");
        }
        //Bu kod bloğunda en az bir tanesi çalışacaktır. Çünkü bütün durumları bir şarta bağladık.

        Console.WriteLine("----------oooooooooo----------");

        //switch case şart yapısı switch ile değer alınır. Case lerde şarta bakılır ve ne yapılacağına karar
        //verilir. break ile case den çıkılıp diğer case e gidilir.

        switch (number2)
        {
            case 0://10 ise case 0 çalışsın
                Console.WriteLine("*Number2 is 10");
                break;
            case 1://20 ise case 1 çalışsın
                Console.WriteLine("*Number2 is 20");
                break;
            default://hiç biri değilse default çalışsın
                Console.WriteLine("*Number2 is not 10 or 20");
                break;
        }

        Console.WriteLine("----------oooooooooo----------");

        var number3 = 151;

        if (number3 >= 0 && number3 <= 100)
        {
            //eğer number3 0 ve 100 arasında ise (0-100 dahil) bu bloğu çalıştır.
            Console.WriteLine("Number is between 0-100");
        }
        else if (number3 > 100 && number3 <= 200)
        {
            //eğer number3 101 ile 200 arasında ise (200 dahil) bu bloğu çalıştır.
            Console.WriteLine("Number is between 101-200");
        }
        else if (number3 > 200 || number3 < 0)
        {
            //eğer number3 200 den büyük veya 0 dan küçük ise bu bloğu çalıştır.
            Console.WriteLine("Number is less than 0 or greater than 200");
        }

        Console.WriteLine("----------oooooooooo----------");

        var number4 = 14;
        if (number4 < 20)
        {
            if (number4 >= 10 && number4 <= 16)
            {
                if (number4 > 13 && number4 <15)
                {
                    Console.WriteLine("number is 14 :=)");
                }
            }
        }
        else
        {
            Console.WriteLine("number4 greater then 20");
        }

        Console.WriteLine("----------oooooooooo----------");



        Console.ReadLine();
    }
}