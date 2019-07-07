using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Events
{
    public class UserCreated :IEvent
    {
        public string Email { get; set; }
        
        public string Name { get; set; }

        public UserCreated(string email , string name)
        {
            Email = email;
            Name = name;
        }


        protected UserCreated()
        {

        }
    }
}
