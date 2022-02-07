using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Models
{
    public struct Status
    {
        public const string Pending = "PENDING";
        public const string Processing = "PROCESSING";
        public const string Failed = "FAILED";
        public const string Done = "DONE";
    }
}
