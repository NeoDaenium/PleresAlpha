using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pleres.Classes
{
    class Batch
    {
        private String id;
        private int productID;
        private String expiry;
        private String manufactured;
        private String status;
        private String owner;
        private String actionDate;
        private int quantity;
        private String health;
        public Batch(String _id,int _productID,String _expiry,String _manufactured,String _status, String _owner, String _actionDate, int _quantity, String _health)
        {
        id = _id;
        productID = _productID;
        expiry = _expiry;
        manufactured = _manufactured;
        status = _status;
        owner = _owner;
        actionDate = _actionDate;
        quantity = _quantity;
        health = _health;
        }
        public string Id { get => id; set => id = value; }
        public int ProductID { get => productID; set => productID = value; }
        public string Expiry { get => expiry; set => expiry = value; }
        public string Manufactured { get => manufactured; set => manufactured = value; }
        public string Status { get => status; set => status = value; }
        public string Owner1 { get => owner; set => owner = value; }
        public string ActionDate1 { get => actionDate; set => actionDate = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Health { get => health; set => health = value; }
    }
}
