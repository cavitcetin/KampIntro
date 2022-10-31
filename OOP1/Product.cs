using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1 
{
    //BU bir özellik class'ı. Bu tür classlarda sadece özellik bulunur.
    
    // *1. aşama özellik classımızı oluşturduk.
    class Product 
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
