internal class Program
    /*Inheritance (katılım - miras) class yapılarını birbirine bağıl yapmak için kullanılır. Yani  bir sınıfın aynı
     * özellikte başka bir alt sınıfı gibi düşünebiliriz yada miras alınan sınıf baba, miras verilen sınıf çocuk gibi
     * babanın özelliklerini taşır fakat kendine ait özellikler de barındırır. 
     * Interfaceler gibi çalışır. Arasındaki farklar Interface ler tek başlarına anlam ifade etmezken Inheritance ler
     * tek başlarına class yapısı gibi kullanılabilirler.
     * Class yapıları birden fazla interface e implementasyon yapılabilirken, tek bir inheritance alabilir, birden 
     * fazla inheritence alamazlar.
     * İnhetitance alan sınıflar aynı zamanda interface de alabilir fakat yazım şekli önce inheritance ler olacak
     * şekilde yazılır.
     * 
     */

{
    private static void Main(string[] args)
    {
        Person[] persons = new Person[3]
        {
            new Customer{FirstName = "Alp"}, new Student{FirstName="Doğukan"}, new Person{FirstName="İpek"}
        };

        foreach (var person in persons) 
        {
            Console.WriteLine(person.FirstName);
        }
     
        Console.ReadLine();
    }

    //Bir class tanımlaması yapıyoruz.
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //Customer diye class tanımlıyoruz ve Interfacelerde yaptığımız gibi syntax ile katılım yani miraslama yapıyoruz.
    //Anlamı Customer class ı Person Clasının alt sınıfı yada o sınıftan türetilmiş aynı özellikli sınıftır diyebiliriz.
    class Customer : Person
    {
        public string City { get; set; }
    }
    //Aynı şekilde burada da class tanımlayıp miraslama yapıyoruz.
    class Student : Person
    {
        public string Department { get; set; }
    }
}