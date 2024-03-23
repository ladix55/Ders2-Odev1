internal class Program
{
    //Senaryo olarak iki türdeki veritabanı sistemini ayrı ayrı kullanıldığını varsayalım. Veritabanında ne işlem yapı-
    //lacaksa her iki tarafata da aynı anda işlemlerin yapılması isteniyor.
    private static void Main(string[] args)
    {
        //ICustomer interface yapısını dizi haline getiriyoruz. Sonra bunu iki elemanlı dizi olacak şekilde (hem sql
        //hem oracle kullanılcak) new liyoruz.
        ICustomerDal[] customerDals=new ICustomerDal[2] 
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
        };
        //Dizi yapısı oluştuğundan dolayı foreach ile dizinin içerisinde dönebildiğimizden dolayı aynı anda iki işlem 
        //yapabiliyor olduk. Dizinin içerisinde class yapılarını aldık. 
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();//Ekleme komutu foreach ile hem SqlServerCustomerDal da hemde OracleCustomerDal da 
            //ayrı ayrı komut çalıştıracaktır.
        }

        Console.ReadLine();

    }

   
    interface ICustomerDal
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

    class CustomerManager //interfaceden implementasyon yaparak class yapısını kurduk. Ekleme işlemi için kullanılacak. 
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

}