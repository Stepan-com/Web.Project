using Mondy.Domain.Entities;
using System.Collections.Generic;

namespace Mondy.Web.Models 
{
    public class HomePageView
    {
        public IEnumerable<Product> RecentlyAdded { get; set; }
    }
}
