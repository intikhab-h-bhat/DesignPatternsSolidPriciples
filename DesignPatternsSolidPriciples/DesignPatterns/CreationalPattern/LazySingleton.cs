namespace DesignPatternsSolidPriciples.DesignPatterns.CreationalPattern
{
public sealed class LazySingleton{

private static LazySingleton stdemo;  //lazy loading
private static readonly object obj =new object();



private LazySingleton()
{
    
}
public static LazySingleton GetSinobj(){
    
   if(stdemo==null)
    {  
    lock(obj){

    if(stdemo==null)
    {
       return stdemo =new LazySingleton();
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