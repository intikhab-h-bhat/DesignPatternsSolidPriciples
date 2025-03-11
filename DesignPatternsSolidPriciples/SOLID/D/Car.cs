


namespace DesignPatternsSolidPriciples.SOLID.D
{


public class Car{

private IEngineType carEngine;

public Car(IEngineType engine)
{
    this.carEngine= engine;
    
}

public void Start(){

    carEngine.StartCar();
}



}


}