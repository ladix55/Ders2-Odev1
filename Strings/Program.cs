internal class Program
{
    //Stringler metinsel ifadeleri tutumak için kullanığımız değişken tipleri. Aslında arka planda değer tipi ola-
    //rak kullandığımız char tipinde bir array (dizi) oluşturur.
    private static void Main(string[] args)
    {
        string city = "Ankara";//string tipinde city değişkeni tanımlandı. Değer olarak 'Ankara' verildi
        string city1 = "+İstanbul";//string tipinde city1 değişkeni tanımlandı. Değer olarak '+İstanbul' verildi
        string result = city + city1;//string tipinde result değişkeni tanımlandı. Değer olarak city+city1 verildi 

        Console.WriteLine(city);//city değişkeninin sting halini yazdırdık.

        Console.WriteLine("--------****-------");

        Console.WriteLine(city[0]);//city dizinin 0 ıncı elamanını yazdırdık.

        Console.WriteLine("--------****-------");

        foreach (var item in city)
        {
            Console.WriteLine(item);//city dizinin elamanlarının içinde dönüp değer yazdırdık.
        }

        Console.WriteLine("--------****-------");

        Console.WriteLine(result);//result isimli değişken yazdırıldı.(stringleri yanyana yazmak toplamak)

        Console.WriteLine("--------****-------");

        //Aşağıdaki örnekte 9. satırdaki result değişkeni tanımlamadan direk olarak değişkenleri yan yana yazmak 
        //için String classının Format parametresinden yararlanarak yazdırdık.(*Bellekte 3. değişken tanımlamadık)
        //Not:String.Format yazmamıza normalde gerek yok ama başka yerlerde kullanırken lazım olur diye not alındı
        Console.WriteLine(String.Format("{0} {1}", city, city1));

        Console.WriteLine("--------****-------");

        string sentence = "My name is Alp";//Cümle isminde değişken tanımlıyoruz.Değer olarak 'My name is Alp' verildi

        //stringdeğişken.Length string değişkeninin özellikleri arasında yer alır. içinde bulunan kelimlerin toplam sa-
        //yısını değer tipi string olduğu için boşluklar dahil verir. result1 değişkenine değişkenin uzunluğu atandı.
        var result1 = sentence.Length;
        //string.Clone() değişkeni klonlamak için kullanılır.
        var result2 = sentence.Clone();
        sentence = "My name is Eren";//santance değişkenin son
        //string.EndsWith("değişken") ilgili string ifadesinin ilgili değişken ile bitip bitmediğine bakar. aynı şekilde
        //string.StartsWith("değişken") ilgili string ifadesinin ilgili değişken ile başlayıp başlamadığına bakar.
        //string.EndsWith-StartsWith geriye true yada false döner.
        bool result3 =sentence.EndsWith("n");
        bool result4=sentence.StartsWith("My");
        //string.IndexOf("") ilgili ifadede ilgili değişkenin kaçıncı karakterden başladığını döndürür. aranan değiş-
        //ken bulunamadığında ise -1 (eksibir) döndürür.Not:Bulduğu ilk değeri döndürür arama kesilir.
        var result5 = sentence.IndexOf("name");
        //string.IndexOf("") gibi çalışır. Aramaya sondan başlar. Karakterleri baştan sayar.
        var result6 = sentence.LastIndexOf(" ");
        //String.Insert(karaktersayısı, "eklenecek metin") ilgili değişkene sonradan değer eklemek için kullanılır.
        var result7 = sentence.Insert(0, "Merhaba ");
        //string..Substring(n,m) ilgili sting değişkenini parçalamak için kullanılır. kaçıncı karakterden parçalanması
        //gerektiği parametre olarak verilir. n başlangıç karakteri, m kaç karakter alınacağı.Not: m için değer veril-
        //mez ise geriye kalan değeri komple getirir.
        var result8 =sentence.Substring(3,8);
        //string.ToLower ilgili değişkenin bütün karakterlerlerini küçük harf yapar.
        var result9 = sentence.ToLower();
        //string.ToLower ilgili değişkenin bütün karakterlerlerini büyük harf yapar.
        var result10 = sentence.ToUpper();
        //string.Replace ilgili değişkenin içindeki ilgili değerlerin yerine yeni değer ile değiştirmeye yarar.
        //sentence.Replace("aranan değer","yerine yazılacak değer")
        var result11 = sentence.Replace(" ","-");
        //sentence.Remove ilgili değişkende belli bir indexten sonrasını atmak için kullanılır.
        var result12 = sentence.Remove(2);
        var result13 = sentence.Remove(2,5);//2 den sonra 5 karakter kaldırmak, atmak

        Console.WriteLine(result1);//Cümlenin kelime karakter sayısı
        Console.WriteLine(result2);//Cümlenin klonu
        Console.WriteLine(sentence);//cümlenin değiştirilmiş hali
        Console.WriteLine(result3);//cümlenin 'n' ile bitip bitmediği
        Console.WriteLine(result4);//cümlenin 'My' ile başlayıp başlamadığı
        Console.WriteLine(result5);//name kalimesinin kaçıncı karakterden itibaren başladığını döndürür.
        Console.WriteLine(result6);//Boşluk değerini sondan arar. baştan sayarak 10 değerini bulur.
        Console.WriteLine(result7);//0 (sıfır) ıncı karakterden başlayarak 'Merhaba ' değişkeni eklenmiştir.
        Console.WriteLine(result8);//3. karakterden başlayarak 8 karakter olacak şekilde değerleri alır.(name is)
        Console.WriteLine(result9);//Bütün karakterler küçük
        Console.WriteLine(result10);//Bütün karakterler büyük
        Console.WriteLine(result11);//Cümlede boşluk karakteri yerine - yazıldı.
        Console.WriteLine(result12);//My dan sonrası kaldırıldı
        Console.WriteLine(result13);//My is Eren

        Console.WriteLine("--------****-------");

        Console.ReadLine();
    }
}