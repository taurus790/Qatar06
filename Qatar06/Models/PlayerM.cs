using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Qatar06.Models.BaseClassesM;

namespace Qatar06.Models
{
    public class PlayerM : GameEntityM
    {
        #region Private attributes and public properties.

        private double _money;

        public double Money
        {
            get { return _money; }
            set { _money = value; OnPropertyChanged(nameof(Money)); }
        }

        #endregion

        #region Constructors.

        public PlayerM()
            :base()
        {
            Name = "Default Player";
            Money = 1010;
        }

        public PlayerM(string name, int level, double money)
            : base(name, level)
        {
            Money = money;
        }

        #endregion
    }
}
