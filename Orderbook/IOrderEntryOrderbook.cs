using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Orderbook;
using TradingEngineServer.Orders;

namespace TradingEngineServer.Orderbook
{
    public interface IOrderEntryOrderbook : IReadOnlyOrderbook
    {
        void AddOrder(Order order);
        void ChangeOrder(ModifyOrder modifyOrder);
        void RemoveOrder(CancelOrder cancelCrder);
    }
}
