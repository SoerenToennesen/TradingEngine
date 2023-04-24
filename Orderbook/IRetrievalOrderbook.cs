using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Orderbook;
using TradingEngineServer.Orders;

namespace TradingEngineServer.Orderbook
{
    public interface IRetrievalOrderbook : IOrderEntryOrderbook
    {
        List<OrderbookEntry> GetAskOrders();
        List<OrderbookEntry> GetBidOrders();
    }
}
