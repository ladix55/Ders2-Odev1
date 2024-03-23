internal class Program
{
    private static void Main(string[] args)
    {
        //interfaceler new yapılamadığı için aşağıda CustomerManager class yapısı kurarak onun üzerinden interface yapısına
        //erişim sağlayarak sistemde kullanılması sağlandı. Aşağıda ilgili class ı çağırarak new ledik.
        CustomerManager customerManager = new CustomerManager(); //class yapısını new leyerek kullanılabilir hale geitrdik
        customerManager.Add(new SqlServerCustomerDal()); //çağırılan class yapısının özelliklerindeki ekleme özelliği 
        //çağırıldığında ilgili class a bağlı interface yapısını da kullanılabillir yaptık.
        //Doğal olarak kodu her ihtimaller dahilinde 1 kez yazarız, ondan sonraki durumlarda ufak tefek değişiklikler
        //ile sistemi çok rahat revize edebilir hale getirebiliriz. Uygulamalar bağımlılıklardan kurtuluyor.Bunun
        //en önemli adımı 'İnterface'lerdir

        Console.ReadLine();
        
    }

    //Db tarafında farklı iki db sistemi yada aynı anda iki farklı db sistemi kullanılmak istenilen proje için bir
    //senaryo düşünelim. Tek bir yapıyı interface yardımı ile iki farklı db için kullanılacak kod yapısını class 
    //formunda yazarak onu da interface implementasyon ile tek kod yapısında iki farklı db için hangisini istersek
    //onu aktif olarak kullanabiliriz.
    interface ICustomerDal //Yapılcak ana işler için yazılan kod bloğunu interface olarak tanımladık.
    {
        void Add(); //ekleme işlemi
        void Update(); //güncelleme işlemi
        void Delete(); // silme işlemi

    }

    class SqlServerCustomerDal : ICustomerDal //Sql server için yapılacak işlemlerde yazılan kod bloklarını class olarak
    //tanımladık ve interface üzerinden implementasyon yaptık.
    {
        public void Add() // db ekleme işlemleri yapıldığını varsayıyoruz
        {
            Console.WriteLine("SqlServer Added"); 
        }

        public void Delete() // db silme işlemleri yapıldığını varsayıyoruz
        {
            Console.WriteLine("SqlServer Deleted");
        }

        public void Update() // db güncelleme işlemleri yapıldığını varsayıyoruz
        {
            Console.WriteLine("SqlServer Updated");
        }
    }

    class OracleCustomerDal : ICustomerDal //Oracle db için yapılacak işlemlerde yazılan kod bloklarını class olarak
    //tanımladık ve interface üzerinden implementasyon yaptık.
    {
        public void Add() // db ekleme işlemleri yapıldığını varsayıyoruz
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete() // db silme işlemleri yapıldığını varsayıyoruz
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()// db güncelleme işlemleri yapıldığını varsayıyoruz
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class CustomerManager //interfaceden implementasyon alınarak class yapısını kurduk. Ekleme işlemi için kullanılacak. 
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

}