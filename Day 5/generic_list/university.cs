using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_list
{
    class university
    {
        public string UniversityName { get; set; }
        public string Location { get; set; }

        public university(string universityName, string location)
        {
            UniversityName = universityName;
            Location = location;
        }

        public override string ToString()
        {
            return $"University: {UniversityName}, Location: {Location}";
        }
    }
}
