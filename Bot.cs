using System; 
using System.Collections.Concurrent;
namespace get_set;

    class Bot : Bankaccaunt{
       public  Bot (){}
        
        public Bot(string name, int weight, byte[] coordinates) :
         base(name,weight,coordinates)
        {
        
        
        }

    public override void PrintValues()
    {System.Console.WriteLine(this.TName + " weight: " + this.TWeight + ", Coordinates: ");
    foreach(byte el in this.Tcordinate)
    System.Console. WriteLine(el);}
}
