using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockUp
{
    class Job
    {
        public int JobNumber { get; }
        public string Location { get; }
        public string Address { get; }
        public string Details { get; }

        public Job(int jobNumber, string location, string address, string details)
        {
            JobNumber = jobNumber;
            Location = location;
            Address = address;
            Details = details;
        }

    }
}
