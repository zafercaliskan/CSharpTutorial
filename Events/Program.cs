using System;

namespace Events
{
    class Program
    {
        //Events: örneğin: Bir mağaza işletiyoruz sattığımız ürünlerden biri akıllı telefon
        //(bir markanın bir ürünü) birde harici disk satıyoruz. Düşünelim ki harici disk önemini yitirdi
        //insanlar cloud disk diskleri kullanıyorlar vs. Harici disk satışı nerdeyse yok gibi
        //bizde elimizdeki harici diskler bitsin sonrasında satmayalım düşünelim. Diğer taraftanda da
        //telefon çok alan var ve hep stokda bulundurmak ve yok çekmek istemediğimizi düşünelim. 
        //Yani kısaca bir ürün bizim için önemli çünkü sürdürülmesi gereken bir ürün diğeri ise tam tersi
        //bitmesini istiyoruz sadece. Telefon bitmeye yakın bir kural koyuyoruz. Bir magazada elimde 20 tane
        //telefon kaldığında (normalde 100 tane var) beni uyar bana mail at telefon stoğunun azaldığını bildir.
        //İşte bu bir event. Yani bir uygulamada nbir hareket olduğunda o harekete ek olarak yapmak istediğimiz
        //işlem varsa bunu event ile yapabiliriz.  Aynı event'i harici disk için istemiyoruz.
        //Bir ürün nesnesi için ürünün türüne göre bir event var ve o event'e abone olursak o event bizim için çalışıyor. 
        //Ama bir ürünü event'e abone etmezsek örneğin harici disk için etmezsek onu uyarmaz.

        //Normalde bir programcı şöyle yapar: if eğer ürünün tipi telefonsa mail atma kodunu çalıştır.
        //Her ürün için sürekli sürekli bunu yapar. Yani birsürü logiclerle uğraşır dururuz.

        static void Main(string[] args)
        {
            Product hardDisk = new Product(50);
            hardDisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "Akıllı Telefon";
            gsm.StockControlEvent += Gsm_StockControlEvent; //Burada += yaptıktan sonra tab tab yapıyoruz.

            for (int i = 0; i < 10; i++)
            {
                hardDisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
        }

        private static void Gsm_StockControlEvent()  //Bu eventde ne yapacağımızı belirtiyoruz.
        {
            Console.WriteLine("Gsm stoğu bitmek üzere!!! ");
        }
    }
}
