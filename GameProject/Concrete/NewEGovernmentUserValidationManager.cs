using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewEGovernmentUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
