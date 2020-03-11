using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class EventSubsection
    {
        public int Id { get; set; }
        public int? Position { get; set; }
        public string Subsection { get; set; }
        public string Section { get; set; }
    }
}
