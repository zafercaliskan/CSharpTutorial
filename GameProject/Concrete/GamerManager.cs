using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Hiçbir sınıfı çıplak bırakmayacağız.
    //(inheritance, implementasyon almıyorsa ilerde sorun yaşarsın)
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        //GamerManager'ın bir bağımlılığı var. Burada doğrulama servisini kullanacağız demek.
        //Bu doğrulama servisi kimlik paylaşım sisteminin kendisi değil. Onun soyutu.
        //Burada UserValidationManager fake yapısı da olabilir. Mernis'de olabilir.
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt eklendi.");
            }
            else
            {
                Console.WriteLine("Doğrualama başarısız. Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
