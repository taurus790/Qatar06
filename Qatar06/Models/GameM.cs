using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Qatar06.Models.BaseClassesM;

namespace Qatar06.Models
{
    public class GameM : GameEntityM
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

        // Constructor with no data.
        public GameM()
            : base()
        {
        }
        // Constructor with default datas.
        public GameM(int design)
            : base(design)
        {
            Name = "Default Game";
            CurrentPlayer = new PlayerM(design);
        }
        // Constructor with given data.
        public GameM(string name, int level, PlayerM currentPlayer)
            : base(name, level)
        {
            CurrentPlayer = currentPlayer;
        }

        #endregion
    }
}
