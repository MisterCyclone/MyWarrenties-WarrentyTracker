using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrentyTracker1._0.Shared
{
    public class NewWarranty
    {
        string productManu;
        string productDesc;
        string warrantyCovers;
        DateTime warrantyExpiry;

        //Constructor
        public NewWarranty(string productManu, string productDesc, string warrantyCovers, DateTime warrantyExpiry)
        {
            this.productManu = productManu;
            this.productDesc = productDesc;
            this.warrantyCovers = warrantyCovers;
            this.warrantyExpiry = warrantyExpiry;
        }

        //GetSet Variables
        public string GetSetManu
        {
            get { return productManu; }
            set { value = productManu; }
        }
        public string GetSetDesc
        {
            get { return productDesc; }
            set { value = productDesc; }
        }
        public string GetSetCover
        {
            get { return warrantyCovers; }
            set { value = warrantyCovers; }
        }
        public DateTime GetSetExpiry
        {
            get { return warrantyExpiry; }
            set { value = warrantyExpiry; }
        }
    }
}
