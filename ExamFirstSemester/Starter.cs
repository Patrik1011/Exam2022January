using System;

namespace ExamFirstSemester
{
    
    public class Starter
    {
        public BikeCatalog customerCatalog = new BikeCatalog();
        public void Start(){
            
            //creating objects and displaying them
        Bike b1 = new Bike("Royal Enfield Classic 350", 2021, "blue" , 321);
        Bike b2 = new Bike("Hero", 2019, "black" , 943);
        Bike b3 = new Bike("Hero", 2022, "green" , 12);
        Bike e1 = new EBike("750W", "Hero Splendor Plus", 2022, "green" , 10);
        Bike e2 = new EBike("600W", "Hero Plus", 2012, "White" , 70);
        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine(b3);
        Console.WriteLine(e1);
        Console.WriteLine(e2);
        Console.WriteLine();
        
        
        //adding items to the list
        customerCatalog.AddBike(b1);
        customerCatalog.AddBike(b2);
        customerCatalog.AddBike(b3);
        customerCatalog.AddBike(e1);
        customerCatalog.AddBike(e2);
        
        
        //printing all list
        customerCatalog.PrintBikeList();
        
        //search method
        Console.WriteLine(""); 
        Console.WriteLine("----------------SEARCH METHOD---------------");
        Console.WriteLine(customerCatalog.SearchBike(12));
        
        //delete method
        Console.WriteLine("");
        Console.WriteLine("----------------DELETE METHOD----------------");
        customerCatalog.DeleteBike(10);
        Console.WriteLine("");
        customerCatalog.PrintBikeList();
        
        //search List of bikes
        Console.WriteLine("");
        Console.WriteLine("----------------SEARCH LIST OF BIKES----------------");
        foreach (var a in customerCatalog.SearchBikesOfModel("Hero"))
        {
            Console.WriteLine(a);
        }
        
        //Delete bikes with the same model
        Console.WriteLine("");
        Console.WriteLine("----------------DELETE BIKES WITH THE SAME MODEL----------------");
        customerCatalog.deleteAllBikesOfModel("Hero");
        customerCatalog.PrintBikeList();



        }
    }
}