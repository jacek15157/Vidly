using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; } //byte because we have few membership types 
        public String Name { get; set; }    
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 0;

    }
}