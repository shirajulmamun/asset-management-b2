using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class Organization
    {
        //public Organization()
        //{
            
        //}
        //public Organization(string name, string code):this()
        //{
        //    this.Name = name;
        //    this.Code = code;
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }

        public ICollection<OrganizationBranch> OrganizationBranches { get; set; } 
    }
}
