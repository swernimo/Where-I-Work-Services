using System;
using Microsoft.Azure.Mobile.Server;

namespace where_I_workService.DataObjects
{
    public class Address : EntityData
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string StateAbbreviation { get; set; }
        public string ZipCode { get; set; }
        public bool Active { get; set; }
        //add address type (residential / business)
        //add full state name (getter only)
        //unit full state name
    }
}
