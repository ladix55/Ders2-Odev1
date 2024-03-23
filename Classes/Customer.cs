using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        //prop yazıp 2 kez tap tuşuna bastığımızda 'public int MyProperty { get; set; }' böyle bir yapı karşımıza çık-
        //maktadır. Müşterinin özelliklerini tutumak için kullanılan nesnedir. Genellikle DB tarafındaki kolonların
        //karşılıklarını tutmak için kullanırız.
  
        //Müşterinin özelliklerini oluşturuyoruz.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        //17 satır yerine aşağıdaki gibi bir tanımlama yapılabilir. programda herhangi bir bozulma olmaz yanlız
        //encapsulation kapsülleme işlemine tabi olmaz. Yukarıdaki tanımlamalarda bir class a özellik tanımladık (pro-
        //perty) aşağıdaki tanımlamada ise alan tanımlama (field) yapmış oluruz.

        //public string FirstName; -> bunu tercih etmeyiz.

        //***Property çalışma mantığı => _gender isiminde bir field tanımlanır. get bolğunda _gender i return ederek
        //geri döndeririz. set bloğunda ise _gender e değer ataması yaparız. Çokda kullanımda olan yöntem değildir.

        private string _gender;
        public string Gender 
        {
            get
            {
                return _gender;
            } 
            set
            {
                _gender = value;
            }
        }
    }
}
