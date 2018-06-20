using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePrototypeEnjo.Core
{
    public class Customer : AuditableEntity
    {
        private ICollection<ShoppingCartItem> _shoppingCartItems;

        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<ShoppingCartItem> ShoppingCartItems
        {
            get { return _shoppingCartItems ?? (_shoppingCartItems = new List<ShoppingCartItem>()); }
            protected set { _shoppingCartItems = value; }
        }
    }
}
