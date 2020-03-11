using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class EventSections
    {
        public int Id { get; set; }
        public int? Position { get; set; }
        public string SectionEvent { get; set; }
    }
}
