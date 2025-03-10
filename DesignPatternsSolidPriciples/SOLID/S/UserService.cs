


namespace DesignPatternsSolidPriciples.SOLID
{


public class UserService{



public void Register(User user){

 
 UserEmailSender email = new UserEmailSender();
 email.SendUserEmail(user.UserEmail,"Welcome to Our Company");


}


}

}