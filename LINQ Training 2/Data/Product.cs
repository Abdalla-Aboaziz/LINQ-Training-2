using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoG01.Data
{
	internal class Product:IComparable<Product>
    {
		public long ProductID { get; set; }
		public string? ProductName { get; set; }
		public string? Category { get; set; }
		public decimal UnitPrice { get; set; }
		public int UnitsInStock { get; set; }

        public int CompareTo(Product? other)
        {
			if(ReferenceEquals(this,other))return 0;
			if(other==null)return 1;
            return this.UnitPrice.CompareTo(other?.UnitPrice);
        }

        public override string ToString()
			=> $"ProductID:{ProductID},ProductName:{ProductName},Category{Category},UnitPrice:{UnitPrice},UnitsInStock:{UnitsInStock}";
	
	}
	class Product02: Product
	{
		public int SerialNumber { get; set; }
	}
}
