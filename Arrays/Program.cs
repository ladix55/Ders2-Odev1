internal class Program
{
    //Dizilier ayni tip değişkenleri tek bir değişkende tutarak daha kolay işlem yapmak için kullanılır.
    //Genellikle veritabanı üzeridnen gelen değerleri alıp dizi içinde tutarız.
    private static void Main(string[] args)
    {
        //Bir öğretmenin bir sınıfı ve bu sınıftaki öğrencilerinin listesini tutmak ve yazdırmak istediği bir senaryo
        //düşünelim. Liste yazdırmak istediğimizde bütün değişkenleri ayrı ayrı yazmamız gerkir. Biz bu veriyi dizi 
        //içinde tutarsak daha kolay işlemler yapabiliriz.
        string student1 = "Engin";
        string student2 = "Derin";
        string student3 = "Salih";

        //Dizi tanımlamak için 'değişkentipi [] dizi ismi = new değişkentipi[eleman sayısı];' şeklindedir.
        string[] students = new string[3];
        students[0] = "Engin";
        students[1] = "Derin";
        students[2] = "Salih";

        //Aşağıdaki şekilde de tanımlanabilir.
        string[] students2 = new[] { "Hasan", "Merve", "Alp" };//=sonrası new[] de yazılmayabilir.

        //foreach dizi içindeki bütün elamanları gezmek için kullanılır.
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        foreach (var student in students2)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("----------oooooooooo----------");

        //Multi Dimensional Arrays Çok boyutlu dizler matrisler gibi çalışır.
        //syntax ı veritipi[,] diziadı = new string [boyutsayısı,elemansayısı]; Burada boyut sayısı satır sayısına
        //elemansayısı da sütün sayısına denk gelir. Not: Dizilerideki gibi 0 (sıfırdan) başlamaz.

        //Türkiyenin 7 bölgesine ait 3 er şehir yazacak şekilde dizi oluşturalım.
        string[,] regions = new string[7, 3]
        {
            {"İstanbul","İzmit","Balıkesir"},
            {"Ankara","Konya","Aksaray"},
            {"Antalya","Adana","Mersin"},
            {"Samsun","Trabzon","Rize"},
            {"İzmir","Manisa","Muğla"},
            {"Erzurum","Ağrı","Van"},
            {"Gaziantep","K.Maraş","Ş.Urfa"},

        };

        //Burada i <= yazmammızın sebebi dizi indexleri 0 dan başladığı için sınırlar ise 7 ve 3 olduğu için 
        //satır için 6 da sütün için 2 de kalır.
        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i,j]);
            }

            Console.WriteLine("--------****-------");
        }


        Console.ReadLine();
    }

}