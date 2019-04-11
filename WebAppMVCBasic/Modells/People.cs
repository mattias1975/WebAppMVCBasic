using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace WebAppMVCBasic.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string age { get; set; }
        public string City { get; set; }
    }
}