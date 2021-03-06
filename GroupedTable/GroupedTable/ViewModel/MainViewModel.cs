﻿using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GroupedTable.Model;

namespace GroupedTable.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            var toyotaCars = new GroupList 
            {
                new Car {Model = "Vitz", EngineCapacity = "100cc"},
                new Car {Model = "Aqua", EngineCapacity = "1500cc"},
                new Car {Model = "Primio", EngineCapacity = "2000cc"},
                new Car {Model = "Alion", EngineCapacity = "2000cc"},
                new Car {Model = "Wigo", EngineCapacity = "1000cc"}
            };
            toyotaCars.Header = "Toyota";
            toyotaCars.GroupId = "1";

            var nissanCars = new GroupList
            {
                new Car {Model = "Sunny", EngineCapacity = "1500cc"},
                new Car {Model = "March", EngineCapacity = "1000cc"},
                new Car {Model = "Leaf", EngineCapacity = "1500cc"}
            };
            nissanCars.Header = "Nissan";
            nissanCars.GroupId = "2";

            PersonCollection.Add(toyotaCars);
            PersonCollection.Add(nissanCars);
        }
        
        public ObservableCollection<GroupList> PersonCollection { get; } =
            new ObservableCollection<GroupList>();
    }
}