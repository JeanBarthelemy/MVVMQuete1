using System.Windows.Input;
using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace MVVMQuete1
{
    class ShopViewModel
    {
        private IList<Shop> _ShopsList;

        public ShopViewModel()
        {
            _ShopsList = new List<Shop>
                {
                    new Shop{ShopId = 1, Name="Toys Shop", City="Strasbourg", Country="FRANCE"},
                    new Shop{ShopId = 2, Name="Animal Shop", City="San Francisco", Country="USA"},
                    new Shop{ShopId = 3, Name="Candy Shop", City="Antigua", Country="GUATEMALA"},
                    new Shop{ShopId = 4, Name="Coffee Shop", City="Amsterdam", Country="HOLLAND"},
                    new Shop{ShopId = 5, Name="Music Shop", City="Barcelona", Country="SPAIN"},
                    new Shop{ShopId = 6, Name="Furniture Shop", City="Berlin", Country="GERMANY"},
                    new Shop{ShopId = 7, Name="Tool Shop", City="Moscow", Country="RUSSIA"},
                    new Shop{ShopId = 8, Name="Food Shop", City="Delhi", Country="INDIA"},
                    new Shop{ShopId = 9, Name="Design Shop", City="Paris", Country="FRANCE"},
                    new Shop{ShopId = 10, Name="Clothes Shop", City="London", Country="UNITED-KINGDOM"}
                };
        }

        public IList<Shop> Shops
        {
            get { return _ShopsList; }
            set { _ShopsList = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        { 
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }
        }
    }
}
