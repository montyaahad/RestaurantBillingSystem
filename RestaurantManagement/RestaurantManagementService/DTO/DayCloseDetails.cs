using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.DTO
{
    public class DayCloseDetails
    {
        public int Id { get; set; }

        public DateTime ClosingDate { get; set; }

        public DateTime NewDate { get; set; }

        public DateTime EntryDateTime { get; set; }

        public int UserId { get; set; }
    }
}
