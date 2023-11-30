using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class Ship
    {
        public int Size { get; set; }
        public bool IsVertical { get; set; } = false;
        public bool IsSunk { get; set; } = false;
    }
}
