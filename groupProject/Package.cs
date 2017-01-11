using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace groupProject
{
    public class package
    
  
    {
        public string PackageId { get; set; }
        public string PkgName { get; set; }
        public override string ToString()
        {

            return PackageId ;
        }
        public string CSVstring()
        {
            return PackageId;
        }

    }

}