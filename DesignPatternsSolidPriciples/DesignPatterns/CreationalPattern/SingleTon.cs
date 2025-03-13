

namespace DesignPatternsSolidPriciples.DesignPatterns.CreationalPattern
{
public sealed class SingleTon{

private static SingleTon stdemo;
private static readonly object obj =new object();

private SingleTon()
{
    
}
public static SingleTon GetSinobj(){
    
   if(stdemo==null)
    {  
    lock(obj){

    if(stdemo==null)
    {
       return stdemo =new SingleTon();
    }
    }
    }
    return stdemo;

}

public void  PrintDetails(string message)
{
    Console.WriteLine(message);
}



}




}