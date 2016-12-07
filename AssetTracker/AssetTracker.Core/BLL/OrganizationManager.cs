using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
    public class OrganizationManager
    {
        OrganizationRepository repository = new OrganizationRepository();

        public bool Add(Organization organization)
        {
            if (organization == null)
                return false;

            if (organization.Code.Length != 3)
            {
                return false;
            }

            return repository.Add(organization);

        }

        public Organization GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}
