



var e = new Eagle();
Animal a = e;   // emplicit        // upcasting : creates a base class ref from a subclass ref
//Eagle e2 = (Eagle)a; // expicit   // downcasting : creates a subclass ref from a base class ref
//Falcon f =(Falcon)a;  //to convert it must use as
Falcon f = a as Falcon; // null value





//==================================================


Eagle eagle = new Eagle();
eagle.move();
a.move();   // cannot use fly method
//e2.move();  // can use fly method

Console.WriteLine( a.ToString());
eagle.name = "Eagle";
Console.WriteLine( eagle.ToString());
Console.WriteLine(a.GetType());
Console.WriteLine(typeof(Eagle));

//abstract class Animal{}  //make class using only for inherutence aim and cannot call this class
//sealed class Eagle{}     //class cannot be inheritence to another , u can call this class




subclass sc = new subclass(123);







class Animal
{
    public virtual void move()
    {
        Console.WriteLine("moving");
    }
    //public override string ToString()        // its inherited from object class
    //{                                        // object class is the ultimate base class for all .net types
    //    return base.ToString();
    //}
   
}

class Eagle : Animal
{
   // public sealed override void move();   ====>  sealed member can not be overriden in the derived class

    public string name { set; get; }
    public override void move()
    {
        base.move();
        Console.WriteLine("the eagle");
    }
    public void fly()
    {
        Console.WriteLine("flying");
    }
    public override string ToString()        
    {
        return $"animal : {name}";
    }
}
class Falcon : Animal
{
    public void flyfalc()   
    {
        Console.WriteLine("flying like a falcon");
    }
}




//==============================================




class baseclass
{
    public int x;

    public baseclass() { }

    public baseclass(int value)
    {
        this.x = value;
    }

}

class subclass : baseclass
{
    public subclass(int scvalue) : base(scvalue) // we use constructor of baseclass by the way of subclass
    {
        
    }
}