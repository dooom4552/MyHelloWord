using System;
using System.Collections.Generic;

namespace FoodStore.Models
{
    public partial class Position
    {
        public int Id { get; set; }
        public string PositionMain { get; set; }
        public int? Position1 { get; set; }
    }
}
