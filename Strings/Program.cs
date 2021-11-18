using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            StringMethods();
        }

        private static void StringMethods()
        {
            string sentence = "My name is Zafer Çalışkan.";
            var result1 = sentence.Length; //String kaç karakterden oluştuğunu verir.
            var result2 = sentence.Clone(); //Klonlama yapar çok kullanılmaz.
            var result3 = sentence.EndsWith("."); //İle bitiyormu? Karakter veya kelime etc. olabilir.
            var result4 = sentence.StartsWith("My"); //İle başlıyor mu?
            var result5 = sentence.IndexOf("My"); //bir karakteri veya ifadeyi aramak için kullanılır.
            var result6 = sentence.LastIndexOf("Çalışkan."); //Aramaya sondan başlar.
            var result7 = sentence.Insert(0, "Hello, "); //belirtiğimiz indexten başlayarak harf veya kelime ekleyebiliriz.
            //Belirtiğimiz indexten sonrasını alır. Ve kaç karakter laacağınıda belirtebiliriz.
            var result8 = sentence.Substring(3); //Çıktı: name is Zafer Çaliskan.
            var result9 = sentence.Substring(3, 13); //Çıktı: name is Zafer
            var result10 = sentence.ToLower(); //Tüm karakterleri küçük harf yapar.
            var result11 = sentence.ToUpper(); //Tüm karakterleri büyük harf yapar.
            var result12 =
                sentence.Replace("My name", "Name"); //oldValue, newValue şeklinde belirli karakterleri değiştirebiliriz.
            var result13 =
                sentence.Remove(25); //startIndex, count //İstediğimiz indexten sonra istediğimiz miktarda karakteri kaldırabiliriz.
            //My name is Zafer Çaliskan -> Noktayı sildik.
            var result14 =
                sentence.Remove(0,
                    11); //startIndex, count //İstediğimiz indexten sonra istediğimiz miktarda karakteri kaldırabiliriz.
            //Çıktı: Zafer Çalışkan.

            Console.WriteLine(result13);
        }

        private static void Intro()
        {
            //string aslında char dizisi
            string city = "Antalya";

            //Console.WriteLine(city[0]);

            foreach (var character in city)
            {
                Console.WriteLine(character);
            }

            string city2 = "İstanbul";
            //string result = city + city2; Yazmaya gerek yok.

            //Aşağıdaki ikisi gibi de olur.
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.WriteLine("{0} {1}", city, city2);
        }
    }
}