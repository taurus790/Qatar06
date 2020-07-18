using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qatar06.Models;
using Qatar06.ViewModels.BaseClassesVM;

namespace Qatar06.ViewModels
{
    public class PlayerVM : GameEntityVM
    {
        #region Private attributes and public properties.

        // private PlayerM _model; // Not needed. Redeclared the property from base.
        private double _money;

        public new PlayerM Model
        {
            get { return (PlayerM)base.Model; }
            set { base.Model = value; OnPropertyChanged(nameof(Model)); }
        }
        public double Money
        {
            get { return _money; }
            set { _money = value; OnPropertyChanged(nameof(Money)); }
        }

        #endregion

        #region Relay commands. 



        #endregion

        #region Constructor. 

        // Constructor with no data.
        public PlayerVM()
        {
        }
        // Constructor with default datas.
        public PlayerVM(int design)
        {
            //Model = new PlayerM(design);
            Model.Money = 1010;
            LoadData();
        }
        // Constructor with given data.
        public PlayerVM(PlayerM model)
        {
            Model = model;

            LoadData();
        }

        #endregion

        #region Methods. 

        public override void LoadData()
        {
            base.LoadData();

            Money = Model.Money;
        }

        #endregion
    }
}
