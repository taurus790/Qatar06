using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Qatar06.Models.BaseClassesM;

namespace Qatar06.ViewModels.BaseClassesVM
{
    public class GameEntityVM : BaseVM
    {
        #region Private attributes and public properties.

        private GameEntityM _model;
        private int _id;
        private static int _lastId;
        private string _name;
        private int _level;

        public GameEntityM Model
        {
            get { return _model; }
            set { _model = value; OnPropertyChanged(nameof(Model)); }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }
        public static int LastId
        {
            get { return _lastId; }
            set { _lastId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        public int Level
        {
            get { return _level; }
            set { _level = value; OnPropertyChanged(nameof(Level)); }
        }

        #endregion

        #region Relay commands. 



        #endregion

        #region Constructor. 
        /*
        public GameEntityVM()
        {
        }
        public GameEntityVM(int design)
        {
            Model = new GameEntityM(design);

            LoadData();
        }
        public GameEntityVM(GameEntityM model)
        {
            Model = model;

            LoadData();
        }
        */
        #endregion

        #region Methods. 

        public virtual void LoadData()
        {
            Id = Model.Id;
            Name = Model.Name;
            Level = Model.Level;
        }

        #endregion
    }
}
