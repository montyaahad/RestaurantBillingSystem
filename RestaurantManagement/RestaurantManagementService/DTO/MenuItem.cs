using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.DTO
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }

        public string MenuItemName { get; set; }

        public decimal Price { get; set; }

        public string MenuItemCode { get; set; }
        
        public int MenuCategoryId { get; set; }

        public string MenuCategoryName { get; set; }
        
        public string Description { get; set; }

        public string FoodOrBeverage { get; set; }
    }
}
