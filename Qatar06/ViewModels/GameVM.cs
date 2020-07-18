using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qatar06.Models;
using Qatar06.ViewModels.BaseClassesVM;

namespace Qatar06.ViewModels
{
     public class GameVM : GameEntityVM
    {
        #region Private attributes and public properties.

        //private GameM _model; // Not needed. Redeclared the property from base.
        private PlayerVM _currentPlayer;
        
        public new GameM Model
        {
            get { return (GameM)base.Model; }
            set { base.Model = value; OnPropertyChanged(nameof(Model)); }
        }
        public PlayerVM CurrentPlayer
        {
            get { return _currentPlayer; }
            set { _currentPlayer = value; OnPropertyChanged(nameof(CurrentPlayer)); }
        }

        #endregion

        #region Relay commands. 



        #endregion

        #region Constructor. 

        // Constructor with no data.
        public GameVM()
        {
        }
        // Constructor with default datas.
        public GameVM(int design)
        {
             Model = new GameM(design);
            //Model.CurrentPlayer = new PlayerM(design);
            LoadData();
        }
        // Constructor with given data.
        public GameVM(GameM model)
        {
            Model = model;

            LoadData();
        }

        #endregion

        #region Methods. 

        public override void LoadData()
        {
            base.LoadData();

            CurrentPlayer = new PlayerVM(Model.CurrentPlayer);
        }

        #endregion
    }
}
