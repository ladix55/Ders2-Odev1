internal class Program
{
    /*İnterface ler class mantığında çalışır. syntax ı interface Intercafeismi şeklindedir. oluşturcağımız interfa-
     * ce isminin başına büyük harf 'I' ile başlatıp ilgili interfacein isminin ilk harfide büyük olacak şeklinde
     * tanımlarız. İnterfacelerin asıl amacı bir temel nesne oluşturup diğer bütün nesneleri ondan implamente etmek-
     * tir.
     * Aşağıdaki yapacağımız örnekte kişi diye interface tanımlıyoruz. Aynı zamanda müşteri ve öğrenci adında iki ta-
     * ne de class tanımlıyoruz. kişi hem müşteri olabilir hem öğrenci olabilir. müşteri ve öğrenci classları somut
     * kişi interface ise soyut nesnedir. Soyut nesneler tek başlarına hiçbir anlam ifade etmezler. Bu yüzden oluştur
     * duğumuz classları interface e implement ederiz ki interface tanımlanmış her şeyi classlar üzerinde ulaşabilelim.
     */

    private static void Main(string[] args)
    {
        InterfacessIntro();

        Console.ReadLine();
    }

    private static void InterfacessIntro()
    {
        PersonManager Manager = new PersonManager();
        Student student = new Student();

        Manager.Add(new Customer { Id = 1, FirstName = "Alp", LastName = "Eren", Address = "Samsun" });//ekle1

        Manager.Add(new Student { Id = 1, FirstName = "Onur", LastName = "Eren", Departmant = "Sales" });//ekle2
    }

    interface IPerson//interface oluşturduk.
    {
        int Id { get; set; } //interface bağlı özellikler oluşturduk
        string FirstName { get; set; } //interface bağlı özellikler oluşturduk
        string LastName { get; set; } //interface bağlı özellikler oluşturduk

    }

    class Customer : IPerson //Müşteri classı oluşturduk ve IPerson ile implementasyon yaptık
    {
        public int Id { get; set; } //İnterface den gelen özellikleri aldık.
        public string FirstName { get; set; } //İnterface den gelen özellikleri aldık.
        public string LastName { get; set; } //İnterface den gelen özellikleri aldık.

        public string Address { get; set; }//Müşteriye ait ayrıca bir özellik tanımladık. İnterface haricinde


    }

    class Student : IPerson //Öğrenci classı oluşturduk ve IPerson ile implementasyon yaptık
    {
        public int Id { get; set; } //İnterface den gelen özellikleri aldık.
        public string FirstName { get; set; } //İnterface den gelen özellikleri aldık.
        public string LastName { get; set; } //İnterface den gelen özellikleri aldık.

        public string Departmant { get; set; } //Öğrenciye ait ayrıca bir özellik tanımladık. İnterface haricinde

    }

    class PersonManager //Yönetici isiminde class tanımlıyoruz.
    {
        /*normalde aşağıda oluşturduğumuz yapıda ekle1 satırdaki müşteri ekleme metodunda hiçbir problem olmayacaktır.
        fakat ekle2 nin olduğu satırda ekleme işlemini öğrenci için yapmaya çalıştığımızda tanımladığımız metod 
        sadece customer ı kapsadığı için kod hataya düşecektir. İnterfaceler tam olarak burada yardımımıza yetişiyor.

        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }

        Aşağıdaki örnekte metodu class a bağlamak yerine interface bağladığımız için class lar da interfaceden implement
        yapıldığı için (her iki class yapısında da 'FirstName' olduğu için interface den geliyor) otomatik olarak hem
        müşteri classında hem öğrenci classında kod olarak sıkıntı çıkmayacaktır.
        */
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);// 18 ve 20 satırdaki girdi işlemlerinin 'FirstName' değişkenlerini
            //ekrana yazdırdık.
        }

    }
}
