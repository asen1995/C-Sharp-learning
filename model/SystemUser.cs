using System;

namespace FirstTimeExperience_C_Sharp.model
{
    class SystemUser : User
    {
        public string typeOfUserAsString()
        {
            return nameof(SystemUser);
        }
    }
}
