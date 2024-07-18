using System; 
namespace get_set{
abstract public class Bankaccaunt 
{
    private string Name {get;set;} = "";
     private int Weight{get;set;}
    private byte[] Coordinate{get;set;} ={};
    private static int Count{get;set;}
    public Bankaccaunt (string name, int weight, byte[] coordinates)
    {       this.Name = name; 
            this.Weight = weight;
            this.Coordinate = coordinates;
    }
    public abstract void PrintValues();
    public Bankaccaunt(){}
   
    public string TName{get{return Name;}private set{}}
    public  byte[] Tcordinate{get{return Coordinate;}
    set{this.Coordinate= Tcordinate;}}
   
    
    public int TWeight{
        get{System.Console.WriteLine("weight :");
        return this.Weight;}
        set{}}
    private int balance ;
    public int Balance{
        get{return balance;}
        set{balance= value;}
    }
    public void bankaccwrite(){System.Console.WriteLine("test");}
}}