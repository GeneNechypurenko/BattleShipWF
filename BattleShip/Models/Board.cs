using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class Board
    {
        public ObservableCollection<Ship> Ships { get; set; }
        public int[,] Board2d { get; set; }
        public bool[,] IsOccupiedCell { get; set; }
        public Board()
        {
            Ships = new ObservableCollection<Ship>
            {
                new Ship (){Size = 1 },
                new Ship (){Size = 1 },
                new Ship (){Size = 1 },
                new Ship (){Size = 1 },
                new Ship (){Size = 2 },
                new Ship (){Size = 2 },
                new Ship (){Size = 2 },
                new Ship (){Size = 3 },
                new Ship (){Size = 3 },
                new Ship (){Size = 4 },
            };

            Board2d = new int[10, 10];
            IsOccupiedCell = new bool[10, 10];
            for (int i = 0; i < Board2d.GetLength(0); i++)
            {
                for (int j = 0; j < Board2d.GetLength(1); j++)
                {
                    Board2d[i, j] = 0;
                    IsOccupiedCell[i, j] = false;
                }
            }
        }
    }
}