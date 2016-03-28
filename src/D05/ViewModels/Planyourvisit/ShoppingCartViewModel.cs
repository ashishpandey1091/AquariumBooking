using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D05.Models;

namespace D05.ViewModels.Planyourvisit
{
    public class ShoppingCartViewModel
    {
        public OrderDetail OrderDetail { get; set; }

        public Price Price { get; set; }

        public List<Event> Event { get; set; }

        public ApplicationUser User { get; set; }
    }
}
