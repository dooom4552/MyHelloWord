using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class EventWork
    {
        public int Id { get; set; }
        public int? Position { get; set; }
        public string EventW { get; set; }
        public string EvSection { get; set; }
    }
}
