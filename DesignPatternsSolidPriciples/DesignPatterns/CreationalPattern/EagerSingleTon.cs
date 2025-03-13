

namespace DesignPatternsSolidPriciples.DesignPatterns.CreationalPattern
{
public sealed class SingleTon{


//private static readonly SingleTon stdemo=new SingleTon();  //Eager loading

// Make the eagerloading to alzy loading by using the lazy keyword
private static readonly Lazy<SingleTon> stdemo=new Lazy<SingleTon>(()=> new SingleTon());


private SingleTon()
{
    
}
public static SingleTon GetSinobj(){
    

    //return stdemo;
    return stdemo.Value;

}

public void  PrintDetails(string message)
{
    Console.WriteLine(message);
}



}




}