using MVCModelSending_2.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelSending_2.Controllers
{
    public class HomeController : Controller
    {
        #region OnemliNotlar

        //View metodu, icerisine bir argüman verilmeden cagrıldıgı zaman hangi ACtion icerisindeyse o ACtion ile aynı isimde View döndürme görevine sahiptir...Eger bu View metodu, icerisine explicit(acıkca) string bir tipte argüman alıyorsa o zaman o isimde bir View döndürür...

        //Bir View metodunun farklı bir View döndürmesi ile Model göndermesi arasında fark vardır... Bu metodun overloadlarindan birinde acık bir şekilde bir string parametre tanımlaması yapıldığından dolayı  metodun object parametre alan bir overload'i olmasına rağmen ilgili Metot bir string argümanla cagrılırsa string parametreli overload'i calısır...Onun object parametreli overload'ini calıstırmak icin string argümanı object'e cast etmeniz gerekir.... Yani siz nasıl olsa her şey object'e gidiyor diye o ilgili overload'in calıstıgını düsünmemelisiniz... Yani siz bu bilgiyi gözden kacırırsanız verdiginiz string argümanın veri göndermek oldugunu(model göndermek oldugunu) zannedersiniz ama aslında o isimde bir sayfa döndürme görevi yapılır...


        //Model Göndermek Front End'e göstermek istediginiz bilgileri Back End'den Front End'e veya Front End'den almak istediginiz verileri Front End'den Back End'e göndermenin bir yoludur...Eger bu bilgi string bir tipte yollanacak ise o zaman string verisinin object'e cast edilerek argüman olarak verilmesi gerekir ("Deneme" as object=



        //Bir Model gönderiliyorsa karşılanmak zorundadır...
        #endregion

        List<Product> products = new List<Product>
        {
           new Product
           {
               ID = 1,
               ProductName = "Tadelle",
               UnitPrice = 12
           },
           new Product
           {
               ID = 2,
               ProductName = "Biskrem",
               UnitPrice = 15
           },
           new Product
           { 
               ID =3,
               ProductName = "Cizi",
               UnitPrice = 20
           }
        };


        public ActionResult Index()
        {
            return View("Deneme" as object);

            
        }

        public ActionResult Contact()
        {
            return View(products);
        }
    }
}