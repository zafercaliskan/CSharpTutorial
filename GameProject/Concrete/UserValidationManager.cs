using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 &&
                gamer.FirstName == "Zafer" &&
                gamer.LastName == "Çalışkan" &&
                gamer.IdentityNumber == 123456789)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
