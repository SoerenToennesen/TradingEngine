using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Orders;

namespace TradingEngineServer.Orders
{
    public class Order : IOrderCore
    {
        public Order(IOrderCore orderCore, long price, uint quanity, bool isBuySide) 
        {
            // Properties
            Price = price;
            InitialQuantity = quanity;
            CurrentQuantity = quanity;
            IsBuySide = isBuySide;

            // Fields
            _orderCore = orderCore;
        }
        public Order(ModifyOrder modifyOrder) : this(modifyOrder, modifyOrder.Price, modifyOrder.Quantity, modifyOrder.IsBuySide)
        {

        }

        // Properties
        public long Price { get; private set; }
        public uint InitialQuantity { get; private set; }
        public uint CurrentQuantity { get; private set; }
        public bool IsBuySide { get; private set; }
        public long OrderId => _orderCore.OrderId;
        public string Username => _orderCore.Username;
        public int SecurityId => _orderCore.SecurityId;

        // Methods
        public void IncreaseQuantity(uint quantityDelta)
        {
            CurrentQuantity += quantityDelta;
        }
        public void DecreaseQuantity(uint quantityDelta)
        {
            if (quantityDelta > CurrentQuantity)
            {
                throw new InvalidOperationException($"Quantity Delta > Current Quantity for OrderId={OrderId}");
            }
            CurrentQuantity -= quantityDelta;
        }

        // Fields
        private readonly IOrderCore _orderCore;

    }
}
