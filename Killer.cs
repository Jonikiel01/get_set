using System; 
using System.Collections.Concurrent;

namespace get_set{
    class Killer : Bankaccaunt{
        Killer  (){}
        public int Heealth {get;set;}
        public Killer(string name, int weight, byte[] coordinates, int health) :
         base(name,weight,coordinates)
        {
        
        this.Heealth = health;
        }
        public override void PrintValues()
        {
            System.Console.WriteLine("Health:"+ this.Heealth);
        }
        
        public void lazer() { System.Console.WriteLine("Pyu pyu ");}
    }
}