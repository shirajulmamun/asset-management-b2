using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;

namespace AssetTracker.Web.Controllers
{
    public class OrganizationController : Controller
    {
        OrganizationManager organizationManager = new OrganizationManager();
        public string Entry(Organization organization)
        {
           bool isAdded =  organizationManager.Add(organization);

            if (isAdded)
            {
                return "Organization Saved Successfully!";
            }
            else
                return "Organization Insertion Failed!";
        }

        public string Search(int? id)
        {

            if (id == null)
            {
                return "Id must be provided!";
            }
            var organization = organizationManager.GetById((int)id);

            return "Organization Name: " + organization.Name;
        }
    }
}