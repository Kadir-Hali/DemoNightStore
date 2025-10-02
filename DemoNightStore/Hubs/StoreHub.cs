using DemoNightStore.Context;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace DemoNightStore.Hubs
{
    public class StoreHub : Hub
    {
        private readonly StoreContext _context;

        public StoreHub(StoreContext context)
        {
            _context = context;
        }

        public async Task GetOrders()
        {
            var values = await _context.Orders.ToListAsync();
            await Clients.Caller.SendAsync("ReceiveOrders", values);
        }

        public async Task Statistics()
        {
            var orderCount = await _context.Orders.CountAsync();
            await Clients.Caller.SendAsync("ReceiveOrderCount", orderCount);

            var orderCountByPrice = await _context.Orders.Where(x => x.Price > 1000).CountAsync();
            await Clients.Caller.SendAsync("ReceiveOrderCountByPrice", orderCountByPrice);
        }
    }
}
