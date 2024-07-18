using System;
using System.Collections.Concurrent;

namespace get_set{

internal class Programm{
    
        static  void Main(string[] args){

        Bot bot = new Bot ("Bot", 800, new byte[] {0, 0, 0});
        bot.PrintValues();



             Bot bankaccaunt = new Bot();




             bankaccaunt.Balance = 155;
            System.Console.WriteLine( bankaccaunt.Balance);
             bankaccaunt.Balance += 155; 
             System.Console.WriteLine($"New bank amount:{bankaccaunt.Balance}");

             Killer killer  = new Killer("killer", 15,new byte[]{15,20,33}, 100);
             killer.Heealth= 100 ; 
             killer.lazer();

            Bot robot = new Bot();
             robot.TWeight= 15; 
             robot.Balance= 100;
             robot.Tcordinate= new byte[]{14,11,1}; 

            robot.PrintValues();
            System.Console.WriteLine("killer class: ");
            killer.PrintValues();


        //     List<Killer> robots = new List<Killer>();
        // robots.Add(new Killer("Alex", 88, new byte[]{0,1,1},99));
        // robots.Add(new Killer("Bob", 848, new byte[]{0,2,1},100));
        // robots.Add(new Killer("John", 28, new byte[]{0,4,1},100));
        // robots.Add(new Killer("Josh", 800, new byte[]{0,5,1},100));
        // Bankaccaunt? newUser = null; 
        // foreach(Killer obj in robots){
        //    if(obj.TName == "John"){newUser = obj as Bankaccaunt; }
        // }
        // foreach(Bankaccaunt objw in robots){
        //     System.Console.WriteLine(objw.TWeight );
        // }
    }
}
}

