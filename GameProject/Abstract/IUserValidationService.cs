using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    public interface IUserValidationService
    {
        //Burada IUser parametresi alan gamer ve personelleri doğrulayan bir sistemde yapılabilir.
        //İlk önce interface ile şablonu oluşturmalıyız.
        public bool Validate(Gamer gamer);
    }
}
