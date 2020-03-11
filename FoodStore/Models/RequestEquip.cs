using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class RequestEquip
    {
        public int Id { get; set; }
        public string Agency { get; set; }
        public string Who { get; set; }
        public string Section { get; set; }
        public string Subsection { get; set; }
        public int? Quantity { get; set; }
        public string Note { get; set; }
        public string Force { get; set; }
        public DateTime? DateIns { get; set; }
        public float? Price { get; set; }
    }
}
