using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //Classları harici bir class dosyası olarakda tanımlayabiliyoruz.
    public class ProductManager
    {
        //Ürün eklendi sonucunu döndüren metod yazıyoruz
        public void Add()
        {
            Console.WriteLine("Product Added.");
        }

        //Ürün güncellendi sonucunu döndüren metod yazıyoruz.
        public void Update() { Console.WriteLine("Product Updated"); Console.WriteLine("--------****-------"); }
    }
}
