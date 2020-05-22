using Remotion.Linq.Parsing.Structure.ExpressionTreeProcessors;
 
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Utilities.Exceptions
{
    public class ProductNotFoundException : Exception
    {

        public ProductNotFoundException() : base(@"Product Nesnenin bir örneğine rastlanamadı")
        {

        }


    }
}
