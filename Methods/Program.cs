using System;

internal class Program
{
    //Metodlar mevcut yapılacak işleri bir blok içerisinde toplayarak sonrandan lazım oluğunda tekrar yazmak yeri-
    //ne o blokları çağırarak işlem yapmak için kullanılır. Bize sağladığı fayda birden farklı yerlerde kullanmamız
    //gerekirse ve herhangibir değişiklik olduğunda sadece ilgili metodu değiştirerek işlemi kolayca yapabilmemizi
    //sağlar.Genelde programın alt kısmında yazılır. Biz okunabilir olsun diye üstte yazdık bir fark yok.
    static void Add() //Ekle isimide metod oluşturduk.
    {
        //Metedun yapacağı işleri bu bloğa yazıyoruz.
        Console.WriteLine("Added!");
    }

    //******************************************---------------------------**************************************

    //void bir işi yap anlamındadır. Eğer geri değer döndüreceksek void yerine dönüş tipini tanımlamalıyız.
    //Add2 den sonra parantez içinde tanımladığımız alan parametre dir. Metodun parametre almasını istiyorsak bu
    //şekilde belirtmemiz gerekir. return değer döndürdüğümüz durumlarda kullanılır.
    static int Add2(int number1, int number2)
    {
        var result = number1 + number2;
        return result;
    }

    //******************************************---------------------------**************************************

    //default parametreli metodlarda ise parametreye değer atanır. İlgili parametreye değer verilirse verilen değer
    //verilmez ise default değer kullanılarak işlem yapılır.
    //NOT:default parametre değeri metodun son parametreisine verilir. Bütün parametrelere de default verilebilir.
    //fakat ilk parametreye verip sonrakine vermemek syntax olarak hataya düşürür.
    static int Add3(int number1, int number2=11)
    {
        var result = number1 + number2;
        return result;
    }

    //******************************************---------------------------**************************************

    //iki sayıdan oluşan parametreli bir metod yazdık içinede tekrar değer ataması yaptık.
    static int Add4(int number1, int number2) 
    {
        number1 = 30;
        return number1 + number2;
    }

    //******************************************---------------------------**************************************

    //iki sayıdan oluşan parametreli bir metod yazdık. içine referans tip barındıran değer ataması yaptık
    //NOT:ref keyword u değer tiplerinin referans tip gibi kullanılmasını sağlar.
        static int Add5(ref int number5, int number6)
    {
        number5 = 30;
        return number5 + number6;
    }

    //******************************************---------------------------**************************************

    //ref keyword ü ile aynı yapıdadır.
    static int Add6(out int number7, int number8)
    {
        number7 = 30;
        return number7 + number8;
    }

    //******************************************---------------------------**************************************
    
    //iki paramatreli çarpma işlemi yapan bir metod tanımladık.
    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }
    //Olası bir üç değişkeni çarpma durumu ortaya çıktığı durumda aynı metod ismi ile tekrar metod yazılıp üçün-
    //cü parametre de kullanılabilir. Buna metod imzası denir.
    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }

    //parametrelerin sabit olmadığı durumlarda Birden fazla sayı ile işlem yapmak istediğimizde paramskeyword ünü
    //kullanırız. Gelen parametreleri dizi formunda tutar ve işleme sokar.
    static int Add7(params int[] numbers)
    {
        return numbers.Sum();
    }



    private static void Main(string[] args)
    {
        Add();//İlgili metodu çağırdık.
        
        Console.WriteLine("----------oooooooooo----------");
        
        Add2(5, 8);//ilgili metodu parametreleri ile birlikte yazdık.!!!
        //burada consola herhangi bir değer çıkmayacaktır. Değer çıktısı görmek için ;
        var result1 = Add2(5, 8);
        Console.WriteLine(result1);
        //komutu ile result üzerinden Add2 yi çağırıp Console.WriteLine ile yazdırmamız gerekir.
        
        Console.WriteLine("----------oooooooooo----------");

        var result2 = Add3(5);//ilgili metod tek parametre ile çağırıldı. ikinci parametre default değer geliyor.
        Console.WriteLine(result2);

        Console.WriteLine("----------oooooooooo----------");

        int number1 = 20;//değişken tanımladı ve değer atandı.
        int number2 = 100;//değişken tanımladı ve değer atandı.
        var result3 = Add4(number1, number2);//metod çağırıldı ve parametreler yukarıdaki değişkenlerden alındı
        Console.WriteLine(result3);//metodun çıktısı ekrana yazdırıldı. metod içerisinde number1 değerini 30 ola-
        //rak aldığından dolayı sonuç 130 gelecektir.
        Console.WriteLine(number1);//Peki mevcut durumda number1 değeri kaçtır? tabiki de 20 :=) Değer tiplerde
        //değerin kendisi esas alınır.

        Console.WriteLine("----------oooooooooo----------");

        //Yukarıdaki örneğin aynısını refarans tip kullanrak yapalım
        int number5 = 20;//değişken tanımladı ve değer atandı.
        int number6 = 100;//değişken tanımladı ve değer atandı.
        var result4 = Add5(ref number5, number6);//metod çağırıldı ve parametreler yukarıdaki değişkenlerden alındı
        Console.WriteLine(result4);//metodun çıktısı ekrana yazdırıldı. metod içerisinde number1 değerini 30 ola-
        //rak aldığından dolayı sonuç 130 gelecektir.
        Console.WriteLine(number5);//referans tip kullanıldığından 85.satırdaki değer ortadan kalkar ve metod içeri-
        //sindeki referans olan number5 değeri (30) dönecektir.

        Console.WriteLine("----------oooooooooo----------");

        //ref keyword ü ile aynı yapıdadır. Tek farkı parametreyi ilgili blokda set etmeye gerek yoktur ama metod 
        //içerisinde set edilemsi lazım.
        int number7;
        int number8 = 100;
        var result5 = Add6(out number7, number8);
        Console.WriteLine(result5);
        Console.WriteLine(number7);

        Console.WriteLine("----------oooooooooo----------");

        //ilk işlem iki değişkenli olduğu için iki parametre verdik ve 69-72 satırlar çalıştı. çıktı 8
        Console.WriteLine(Multiply(2, 4));
        //ikinci işlem üç değişkenli olduğu için üç parametre verdik ve üçüncü parametreyi görünce 75-78 arası
        //satırlar çalıştı. Çıktı 40
        Console.WriteLine(Multiply(2, 4, 5));

        Console.WriteLine("----------oooooooooo----------");

        //girilen bütün sayıları ayrı ayrı paremetre olarak tanımlayıp işleme aldı
        Console.WriteLine(Add7(1, 2, 3, 4, 5, 6));

       


        Console.ReadLine();
    }
}