using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //KrediManager benim için tek başına bir anlam ifade etmiyor. Base görevi görüyor.
    //Imzanın aynı olduğu (void Hesapla()) fakat içerisinin farklı olduğu durumlarda 
    //class KrediManager değilde "interface IKrediManager" olarak oluştururuz.
    //Interface benim şablonum görevini görüyor. 
    // Bir interface şunu anlatır. Eğer bir kişi bu interface'i kullanırsa o arkadaş 
    // (void Hesapla();) bu method'u içermek zorunda. Birden fazla method olabilir.
    

    //Not: Bir interface oluşturduğumuzda o interface'in içindeki operasyonlar 
    // alternatif sistemler için bir şablon ve referans tutucu görevi görüyor.  
    
    //Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. 
    //Kredi türlerinin hepsinde hesaplama vardır. Tüm kredilerde ortaktır ama kodları farklıdır.  
    //Kredinin türüne göre hesaplama işlemleri farklılık gösterir.
    
    interface IKrediManager
    {
        void Hesapla();

        void BirseyYap();
    }

    //Örnek: Örneğin projede loglama yapmak istiyoruz. Kim ne zaman hangi operasyonu çağırdığıdır.
    //Loglamayı farklı yöntemlerle yapabiliriz. Örneğin: Bir dosyada tutabiliriz. Logları veri tabanında tutabiliriz. 
    //Logları sms atabiliriz. Krediye bir başvuru yaptığında ona sms atılmasıda süreç oda bir loglama türüdür. 
    //Mail gönderilmesi de loglamanın alternatifleridir. Hepsi logluyor. Hepsinin imzası aynı. Ama dosyaya yazarken
    //dosyaya yazma kodları, veri tabanına yazma kodları, sms yollama kodları email yollarken onun kodları. Ama hepsinde yapılan işlem loglamadır.
}