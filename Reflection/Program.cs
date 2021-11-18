using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection
{
    class Program
    {

        static void Main(string[] args)
        {
            //Intro();

            var type = typeof(DortIslem);
            var instance = Activator.CreateInstance(type, 6, 7);

            //GetMethod ile method'a ulaşıp Invoke ilede çalıştırabiliyoruz. null verdiğimiz yerde parametre verebiliriz.
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));


            var methods = type.GetMethods();

            foreach (var infoMethod in methods)
            {
                Console.WriteLine($"Method adı: {infoMethod.Name}");

                foreach (var parameterInfo in infoMethod.GetParameters()) //Methodun parametrelerine ulaşabiliyoruz.
                {
                    Console.WriteLine($"Parametre adı: {parameterInfo.Name}");
                }

                foreach (var attribute in infoMethod.GetCustomAttributes())
                {
                    Console.WriteLine($"Attribute adı: {attribute.GetType().Name}");
                }
            }
        }

        private static void Intro()
        {
            //reflaction ile çalışma anıda yani kısaca uygulama çalışırken çalıştığımız herhangi bir nesne hakında bilgi toplayabilir 
            //hatta bu bilgiye göre bu nesneyi istediğiniz zaman örneğin bir methodunu çalıştırabiliriz çalışma anında.

            var type = typeof(DortIslem); //Burada DortIslem de parametre olarak alabiliriz.

            //Çalışma anında dinamik instance üretiyoruz.
            var dortislem = (DortIslem)Activator.CreateInstance(type, 6, 7); //(DortIslem) ile cast işlemi yapıyoruz.
            //type, den sonra consructorın parametrelerini verebiliyoruz.
            //(DortIslem) ile cast işlemi yaptğımız için DortIslem class'ı altındaki methodlara erişebiliyoruz.
            Console.WriteLine(dortislem.Topla(4, 5));
            Console.WriteLine(dortislem.Topla2());
        }
    }

    
    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;


        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        [MethodName("Carpma")]
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        [MethodName("Toplama")]
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Bolme")]
        public int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

        [MethodName("Bolme")] //Bu attributeları GetCustomAttributes ile bulabiliyoruz.
        public int Bol2()
        {
            return _sayi1 / _sayi2;
        }
    }


    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
    }
}