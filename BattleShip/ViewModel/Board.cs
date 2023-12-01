using BattleShip.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.ViewModel
{
    public class Board : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private ObservableCollection<Ship> _ships;
        public ObservableCollection<Ship> Ships
        {
            get => _ships ?? (_ships = new ObservableCollection<Ship>());
            set
            {
                _ships = value;
                OnPropertyChanged(nameof(Ship));
            }
        }
        private int _lincoreSet = 1;
        public int LincoreSet
        {
            get => _lincoreSet;
            set
            {
                _lincoreSet = value;
                OnPropertyChanged(nameof(LincoreSet));
            }
        }
        private int _fregateSet = 2;
        public int FregateSet
        {
            get => _fregateSet;
            set
            {
                _fregateSet = value;
                OnPropertyChanged(nameof(FregateSet));
            }
        }
        private int _corvetteSet = 3;
        public int CorvetteSet
        {
            get => _corvetteSet;
            set
            {
                _corvetteSet = value;
                OnPropertyChanged(nameof(CorvetteSet));
            }
        }
        private int _briggSet = 4;
        public int BriggSet
        {
            get => _briggSet;
            set
            {
                _briggSet = value;
                OnPropertyChanged(nameof(BriggSet));
            }
        }

        private int[,] _board2d;
        public int[,] Board2d
        {
            get => _board2d;
            set
            {
                _board2d = value;
                OnPropertyChanged(nameof(Board2d));
            }
        }
        private bool[,] _isOccupiedCell;
        public bool[,] IsOccupiedCell
        {
            get => _isOccupiedCell;
            set
            {
                _isOccupiedCell = value;
                OnPropertyChanged(nameof(IsOccupiedCell));
            }
        }
        public Board()
        {
            Ships = new ObservableCollection<Ship>();

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
