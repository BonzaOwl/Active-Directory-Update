using System;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace UpdateActiveDirectory
{
    class GetDomainController
    {
        public static string DomainController;

        public static string GetDC()
        {

            try
            {
                Domain domain = Domain.GetCurrentDomain();

                DirectoryEntry de = domain.GetDirectoryEntry();

                string DCParts = de.Properties["DistinguishedName"].Value.ToString();

                DomainController = domain.FindDomainController().ToString();

            }
            catch (Exception ex)
            {
                string ErrorThrown = ex.Message.ToString();

            }

            return DomainController;

        }
    }
}
