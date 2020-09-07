using Skollklass.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skollklass.models
{
    class Teachers : Person
    {
        public string FirstName { get ; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

        public string Class { get; set; }
    }
}
