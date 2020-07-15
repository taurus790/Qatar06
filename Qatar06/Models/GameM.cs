using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Qatar06.Models.BaseClassesM;

namespace Qatar06.Models
{
    class GameM : GameEntityM
    {
        #region Private attributes and public properties.

        private PlayerM _currentPlayer;

        public PlayerM CurrentPlayer
        {
            get { return _currentPlayer; }
            set { _currentPlayer = value; OnPropertyChanged(nameof(CurrentPlayer)); }
        }

        #endregion

        #region Constructors.

        public GameM()
            : base("New Game", 1)
        {
            CurrentPlayer = new PlayerM("New Player", 1, 1010);
        }
        public GameM(string name, int level, PlayerM currentPlayer)
            : base(name, level)
        {
            CurrentPlayer = currentPlayer;
        }

        #endregion
    }
}
