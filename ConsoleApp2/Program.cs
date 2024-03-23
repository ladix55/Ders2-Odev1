internal class Program
{
    //Senaryo olarak bir şirket düşünelim, bu şirketin çalışanları var, yapı olarak da işçiler, yöneticiler, robot-
    //lar şeklinde olsun.
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    //Çalışma için interface tanımlıyoruz. Çalışan yapısını kurmak için ise ayrı ayrı class lar tanımlayarak inter-
    //face yapısından implementasyon yapıyoruz. ilk örnekte tek interface ile işe başladık fakat robot clasında işler
    // karıştı çünkü robot sadece çalışır diğer durumlar yer almaz.
    //bunun için aşağıdaki örnekten vaz geçip ayrı ayrı implementasyon tanımlıyoruz.
    /*interface IWorker
    {
        void Work(); //çalışanlar çalışır.
        void Eat(); //çalışanlar yemek yer
        void GetSalary(); //çalışanlar maaş alır.

    }
    */

    //üç ayrı interface tanımladık 24-28-32 satırlar
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }


    //Yöneticiler aynı zamanda bir çalışandır. çalışır, yemek yer ve maaş alırlar
    class Manager : IWorker, IEat, ISalary //NOT:Burada en önemli detay bir classın birden fazla interface
    //implementasyon almasıdır.
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    //Çalışanlar aynı zamanda bir çalışandır. çalışır, yemek yer ve maaş alırlar
    class Worker : IWorker, IEat, ISalary 
    {
        public void Work()
        {

        }
        public void Eat()
        {

        } 
        public void GetSalary()
        {

        }
    }

    //Robotlarda aynı zamanda bir çalışandır. çalışır, yemek YEMEZ ve maaş ALMAZLAR.
    class Robot : IWorker // Robot çalışanında karşımıza sıkıntı tek ve sadece onunla ilgili olan interface i tanım-
    //ladığımız zaman problem çözülmüş olacaktır.
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
//NOT:SOLID in I harfi olan Interface Segregation prensibi yani ;Sorumlulukların hepsini tek bir arayüze toplamak
//yerine daha özelleştirilmiş birden fazla arayüz oluşturmayı tercih etmemizi söyleyen prensiptir. bunu gercekleştirdik