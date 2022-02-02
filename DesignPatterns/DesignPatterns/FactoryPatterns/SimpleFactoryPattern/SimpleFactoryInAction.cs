using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPatterns.SimpleFactoryPattern
{
    public  class SimpleFactoryInAction
    {

        public void PurchaseDuck(Senario senario)
        {
            ShoppingCart _shoppingCart = new ShoppingCart();
            _shoppingCart.BuyDuck(senario);
        }

        public void PurchaseDuckUsingFactory(Senario senario)
        {
            ShoppingCart_WithFactory _shoppingCart = new ShoppingCart_WithFactory();
            _shoppingCart.BuyDuck(senario);
        }
    }
}
