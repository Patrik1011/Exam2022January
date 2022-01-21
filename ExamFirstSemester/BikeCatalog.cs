using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamFirstSemester
{
    public class BikeCatalog
    {
        
        private List<Bike> _bikes;
        private List<Bike> _bikesSearched;
        
        public BikeCatalog()
        {
            _bikes = new List<Bike>();
            _bikesSearched = new List<Bike>();
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
                if (aBike.ChasisNumber == a.ChasisNumber)
                {
                    throw new ArgumentException("Does not exist");
                    
                }

                else
                {
                    _bikes.Add(aBike); 
                   
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
        
        
        public void DeleteBike(int chasisNumber)
        {
            try
            {
                _bikes.Remove(SearchBike(chasisNumber));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        
        public List<Bike> SearchBikesOfModel(string model)
        {
            foreach (var bike in _bikes)
            {
                if (bike.Model == model)
                {
                    _bikesSearched.Add(bike);
                }

                
            }

            return _bikesSearched;
        }

        public void deleteAllBikesOfModel(string model)
        {
            _bikes.RemoveAll(bike => bike.Model == model);
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