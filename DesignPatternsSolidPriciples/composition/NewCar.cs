
namespace DesignPatternsSolidPriciples.compoition
{

public class NewCar{

private Engine engine= new Engine();
private Wheels wheels= new Wheels();

private Chasis chasis= new Chasis();


public void StartCar(){

    engine.StartEngine();
    wheels.WheelsRotating();
    chasis.ChasisSupport();
}



}



}