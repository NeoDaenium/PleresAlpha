using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pleres.Classes
{
    [Serializable]
    public class Product
    {
        private int id;
        private String category;
        private String brandName;
        private String genericName;
        private String fdaRegistrationNumber;
        private String lotNumber;
        private decimal basePrice;
        private decimal sellingPrice;
        private int districtNumber;
        private decimal costPrice;

        public Product()
        {

        }
        public Product(int _id,String _category,String _brandName, String _genericName, String _fdaRegistrationNumber, String _lotNumber, Decimal _price, Decimal _cost, int _district){
        Id = _id;
        category = _category;
        brandName = _brandName;
        genericName = _genericName;
        fdaRegistrationNumber = _fdaRegistrationNumber;
        lotNumber = _lotNumber;
        BasePrice = _price;
        CostPrice = _cost;
        DistrictNumber = _district;
        }
        public override string ToString()
        {
            return id +" | " +category + " | " +brandName + " | " +genericName + " | " + fdaRegistrationNumber + " | " +lotNumber + " | " +basePrice + " | " + costPrice  +" | " +districtNumber;
        }

        public string LotNumber { get => lotNumber; set => lotNumber = value; }
        public string FdaRegistrationNumber { get => fdaRegistrationNumber; set => fdaRegistrationNumber = value; }
        public string GenericName { get => genericName; set => genericName = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public string Category { get => category; set => category = value; }
        public int Id { get => id; set => id = value; }
        public decimal BasePrice { get => basePrice; set => basePrice = value; }
        public decimal SellingPrice { get => sellingPrice; set => sellingPrice = value; }
        public decimal CostPrice { get => costPrice; set => costPrice = value; }
        public int DistrictNumber { get => districtNumber; set => districtNumber = value; }
    }
}
