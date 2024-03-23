enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}
internal class Program
{
    private static void Main(string[] args)
    {
        //Programcının ilk dersi Ekrana "Merhaba Dünya" yazdırmaktır.
        Console.WriteLine("Hello, World!");
        //Kullanıcıdan bilgi almak için bekler. Genelde consol uygulamalarında ekranın kaybolmaması için kullanılır.
        //Console.ReadLine();

        Console.WriteLine("----------oooooooooo----------");

        int number1 = 20;
        int number2 = 50;
        Console.WriteLine(number1);
        //Süslü parantez ile verdiğimiz değer index yapısını temsil eder. {0} virgülden sonraki ilk değer anlamındadır.
        //int değişkeni -2147483648 ile 2147483647 arasındaki sayılardan oluşabilir.
        Console.WriteLine("Number1-2 is {0}-{1}",number1,number2);
        //int değer kümesi dışında bir değere ihtiyaç duyulursa aynı türden olan long da kullanılabilir.
        //Peki ne gerek var int e o zaman hepsine long verir geçerim diyebilirsiniz, Fakat tam olarak öyle değil
        Console.WriteLine("----------oooooooooo----------");

        long number3 = 2147483649;
        //int 32 bitlik (4byte) bir uzunluk ile bellekte yer tutarken, long 64 bitlik (8byte) uzunluk ile yer tutar.
        //doğal olarak da bellektteki tutulan statik boyutu büyük tutar.
        //long değişkeni –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 arasındaki sayılardan oluşabilir.
        Console.WriteLine(number3);
        Console.WriteLine("----------oooooooooo----------");

        short number4 = 32767;
        //short ise 16 bitlik (2byte) uzunlkta, -32768 ve 32767 arasındaki değerleri alabilir.
        Console.WriteLine(number4);
        Console.WriteLine("----------oooooooooo----------");

        byte number5 = 254;
        //Byte 8 bitlik (1byte) uzunlukta 0 ile 255 arasında değer alabilir. c# da byte tipi - (eksi) almaz.
        Console.WriteLine(number5);
        Console.WriteLine("----------oooooooooo----------");

        bool number6 = true;
        //bool 8 bitlik (1byte) uzunlukta, 1 ve 0 (true - false)olarak değer alabilir. Genellikle mantıklsal
        //bloklarında, if gibi şartlı döngülerde kullanılırız. Aklınıza şu gelmiş olabilir ->
        //Peki sadece iki değer alabiliyorken neden 8 bitlik veri tutuyor? 
        //Bunun cevabı bellek yapısının 8 er bitlik bloklardan oluşmuş olmasıdır.
        Console.WriteLine(number6);
        Console.WriteLine("----------oooooooooo----------");

        char char1 = 'A';
        //char 16 bit (2byte) uzuklukta, unicode standartlarında karaterlerin karşılığını tutar.
        //char tipinde değer alacak karakterin; direk kendisini, hexadecimal karşılığını, ascii karşılığını,
        //uniceode karşılığını da yazarbilirsiniz.
        Console.WriteLine(char1);
        //char tipi değişkenlerin ascii karşılığı int olarak tutulduğu için aşağıda ki örneğe bakılabilir.
        Console.WriteLine("Char1 is :{0}",(int)char1);
        //char değişkenler dizi ortamında birleşerek string veri tipini oluştururlar.
        Console.WriteLine("----------oooooooooo----------");

        double number7 = 10.4;
        //double 64 bit (8byte) uzunlukta olup, ondalıklı sayıları tutmamızı sağlamaktadır.
        //virgülden sonra 15-16 karakter tutabilir.
        Console.WriteLine(number7);
        Console.WriteLine("----------oooooooooo----------");

        decimal number8 = 10.5M;
        //dacimal 128 bit (16byte) uzunlukta olup, ondaklı sayı tutmamızı sağlar. double dan farkı ise virgülden
        //sonra ki basamak sayısıdır. decimalde virdülden sonra 28 karakter tutabilir.
        //eğer tam sayı değeri girilmeyecekse virgülden sonraki değerin sonuna 'm' koymak gerekir.
        Console.WriteLine(number8);
        Console.WriteLine("----------oooooooooo----------");
        
        //******************************************---------------------------**************************************

        //enumlar sabitlerle tanımlanmış ayırt edici veri tipleridir. mantık olarak dizi gibi çalışırlar.
        //tanımlaması class yapısının dışında tanımlanır. değerler ilgili bloğa aralarına virgül koyularak
        //yazılır. Eğer bir tanımlama yapılmazsa ilk değer diziler gibi 'sıfır' (0) dan başlar.
        //1-4 satırlar. Programlamada genelde bu tip tanımlamalar alt kısımda kullanılır. Satır sayısı sabit kalsın
        //diye yukarı yazıyorum.

        Console.WriteLine(Days.Monday);
        Console.WriteLine((int)Days.Monday);
        Console.WriteLine(Days.Friday);
        Console.WriteLine((int)Days.Friday);
        Console.WriteLine("----------oooooooooo----------");

        //var keyword u veri tipi olmamasına rağmen veri tutmak için kullanırız. tanımladığımız değişkenin 
        //veri tipi neyse onu otomatik tanımlayıp o tipde değişken oluşturur. ilk tanımlama hangi tip üzerinden 
        //oluşmuşsa o tip üzerinden devam eder başka tip atanamaz.

        var number9 = 12;
        Console.WriteLine(number9);
        var char2 = 'T';
        Console.WriteLine(char2);
        var number10 = 12.65;
        Console.WriteLine(number10);

        //******************************************---------------------------**************************************

       Console.ReadLine();

    }

}

