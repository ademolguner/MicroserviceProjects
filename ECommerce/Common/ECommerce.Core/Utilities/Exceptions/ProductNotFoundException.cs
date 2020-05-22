using System;

namespace ECommerce.Core.Utilities.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base(@"Product Nesnenin bir örneğine rastlanamadı")
        {
        }
    }
}