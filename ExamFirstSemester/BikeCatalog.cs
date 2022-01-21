using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamFirstSemester
{
    public class BikeCatalog
    {
        
        private List<Bike> _bikes;
        
        public BikeCatalog()
        {
            _bikes = new List<Bike>();
        }
        
        public BikeCatalog(List<Bike> bikes)
        {
            if (bikes == null) 
                _bikes = new List<Bike>();
            else 
            {
                bikes.RemoveAll(customer => customer == null);
                _bikes = bikes;
            }
        }

        public void AddBike(Bike aBike)
        {
            if (aBike == null) return;
            _bikes.Add(aBike); 
            /*
            foreach (var a in _bikes)
            {
                if (a.ChasisNumber != aBike.ChasisNumber)
                {
                    _bikes.Add(aBike); 
                }

                else
                {
                    
                    throw new ArgumentException("Cannot add bike");
                }
            }*/
        }
        
        
        public void PrintBikeList()
        {
            int count = _bikes.Count;
            DateTime time = DateTime.Now;
            Helpers.PrintHelp("ALL BIKES FROM LIST" , ToString(), count , time);
            
        }

        public Bike SearchBike(int chassisNumber)
        {
            Bike item = _bikes.FirstOrDefault(obj => obj.ChasisNumber == chassisNumber);

            if (item == null) throw new ArgumentNullException("Item does not exist");

            return item;
        }

        public override string ToString()
        {
            string items = "";

            foreach (var a in _bikes)
            {
                items += a.ToString() + "\n";
            }
            return items;
        }


    }
}