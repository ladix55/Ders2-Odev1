using Classes;

internal class Program
{
    //Classları genel anlamda yapmak istediğimiz işlemleri gruplara ayırmak, bu grup üzerinden işlemleri yapmak ve ra-
    //hatlıkla bu gruba ulaşmak için kullanılırız.

    //Müşteri işlemleri yapmak için bir gruplama yapıyoruz. class oluşturuyoruz. Genelde alt kısımda tanımlanır.
    //satır sayısı değişemesin diye yukarıda tanımladık. Çalışma açısından bir fark yoktur.
    class CustomerManager
    {
        //Müşteri eklendi sonucunu döndüren metod yazıyoruz
        public void Add()
        {
            Console.WriteLine("Costomer Added.");
        }


        //Müşteri güncellendi sonucunu döndüren metod yazıyoruz.
        public void Update() { Console.WriteLine("Costomer Updated"); Console.WriteLine("--------****-------"); }
    }
    public static void Main(string[] args)
    {
        //classları kullanmak için bir örneğini oluşturmak gerekir.(referansını oluşturduk.)
        //Classlar oluşturulurken PascalCase (kelimelerin ilk harfleri büyük), ama örneği oluşturuurken camelCase (ke-
        //limelerin ilkinin ilkharfi küçük diğerlerinin ilk harfi büyük) şeklinde oluşturulur.
        CustomerManager customerManager = new CustomerManager();

        //Dışarıda oluşturmuş olduğumuz classın öreneğini oluşturuyoruz.
        ProductManager productManager = new ProductManager();

        //CostumerManager. dediğimizde ilgili metodlar otomatik olarak gelecektir. Yukarıdaki class içindeki metodlar
        customerManager.Add();
        customerManager.Update();
        
        //Dışarıdaki ürün classının ilgili metodlarını çağırıyoruz.
        productManager.Add();
        productManager.Update();

        //Customer clasının bir örneğini oluşturuyoruz.
        Customer customer = new Customer();
        customer.Id = 1;//Class özelliklerinde = eşittir ibaresi tanımdaki 'set' ibaresinden gelir. set etmek
        customer.FirstName = "Alp";
        customer.LastName = "Eren";
        customer.City = "Samsun";

        //İlgili class için farklı bir kullanım yöndetimi de örnek oluştururken normal parantez açmak yerine köşeli
        //parantez açarak tek satırda motoda bağlı bütün değişkenleri getirmek ve değer atamak mümkündür.
        Customer customer2 = new Customer { Id=2, City="İstanbul",FirstName="Engin",LastName="Demiroğ" };

        Console.WriteLine(customer2.FirstName + " " + customer2.LastName);//classların özelliklerinde = eşittir 
        //ibaresin olmadan işlem yapılırsa 'get' ibaresi çalışır.getirmek, almak şeklinde



        Console.ReadLine();

    }


}