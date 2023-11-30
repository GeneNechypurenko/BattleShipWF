using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public abstract class Competitive
    {
        protected Board _board;
        protected bool _isEndGame;
        public virtual bool GetIsEndGameConditions(Board board)
        {
            if (board.Ships.Count == 0)
            {
                _isEndGame = true;
            }
            return _isEndGame;
        }
        public abstract void SetBoard();
        public abstract void Shoot();
    }
}