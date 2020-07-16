﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qatar06.Models.BaseClassesM
{
    public class GameEntityM : BaseM
    {
        #region Private attributes and public properties.

        private int _id;
        private static int _lastId;
        private string _name;
        private int _level;

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

        #region Constructors. 

        public GameEntityM()
        {
            Id = ++LastId;
            Name = "Default Game Entity";
            Level = 1;
        }

        public GameEntityM(string name, int level)
        {
            Id = ++LastId;
            Name = name;
            Level = level;
        }

        #endregion
    }
}
