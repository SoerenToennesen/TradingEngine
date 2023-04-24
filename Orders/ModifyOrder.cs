using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TradingEngineServer.Orders
{
    public class ModifyOrder : IOrderCore
    {
        public ModifyOrder(IOrderCore orderCore, long price, uint quantity, bool isBuySide)
        {

            // Properties
            Price = price;
            Quantity = quantity;
            IsBuySide = isBuySide;
            
            // Fields
            _orderCore = orderCore;
        }

        // Properties
        public long Price { get; private set; }
        public uint Quantity { get; private set; }
        public bool IsBuySide { get; private set; }
        public long OrderId => _orderCore.OrderId;
        public string Username => _orderCore.Username;
        public int SecurityId => _orderCore.SecurityId;

        // Methods
        public CancelOrder ToCancelOrder()
        {
            return new CancelOrder(this);
        }
        public Order ToNewOrder()
        {
            return new Order(this);
        }

        // Fields
        private readonly IOrderCore _orderCore;
    }
}
