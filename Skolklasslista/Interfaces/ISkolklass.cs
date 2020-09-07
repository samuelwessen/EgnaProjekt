using System;
using System.Collections.Generic;
using System.Text;

namespace Skolklasslista.Interfaces
{
    interface ISkolklass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Gender { get; set; }                

        public string City { get; set; }


    }
}
