using DemoNightStore.Context;
using Microsoft.AspNetCore.SignalR;

namespace DemoNightStore.Hubs
{
    public class StoreHub : Hub
    {
        private readonly StoreContext _context;

        public StoreHub(StoreContext context)
        {
            _context = context;
        }


    }
}
