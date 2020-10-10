using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClasses
{
    public class PartsList
    {
        public List<Parts> PartsInventory { get; set; }
        
        public PartsList()
        {
            PartsInventory = new List<Parts>();
            PartsInventory.Add(new Parts("CR-7214", "Car Repair Ramps", 339.99, 29));
            PartsInventory.Add(new Parts("RWL-01", "Rechargeable Work Light", 29.99, 44));
            PartsInventory.Add(new Parts("BW-WD-2", "Wheel Dollies", 59.99, 20));
            PartsInventory.Add(new Parts("RLB-54", "Roof Crossbars", 29.99, 19));
            PartsInventory.Add(new Parts("RHBM-2", "2 Ball Trailer Mount", 24.99, 5));
        }

        public List<string> GetPartName()
        {
            List<string> names = new List<string>();
            foreach (Parts pt in PartsInventory)
            {
                names.Add(pt.Name);
            }
            return names;
        }

        public Parts GetParts(string partsName)
        {
            Parts part = null;
            foreach(Parts pt in PartsInventory)
            {
                if (partsName == pt.Name)
                {
                    part = pt;
                }
            }
            return part;
        }

        public double UpdatePrice(string partsName,double price)
        {
            foreach (Parts pt in PartsInventory)
            {
                if (partsName == pt.Name)
                {
                    pt.Price = price;
                }
            }
            return price;
        }

        public int UpdateStock(string partsName, int stock)
        {
            foreach (Parts pt in PartsInventory)
            {
                if (partsName == pt.Name)
                {
                    pt.Stock = stock;
                }
            }
            return stock;
        }
    }
}
