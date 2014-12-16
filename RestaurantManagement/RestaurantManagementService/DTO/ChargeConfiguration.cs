using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.DTO
{
    public class ChargeConfiguration
    {
        public int Id { get; set; }

        public int DiscountPercent { get; set; }

        public int ServiceChargePercent { get; set; }

        public int VatPercent { get; set; }
    }
}
