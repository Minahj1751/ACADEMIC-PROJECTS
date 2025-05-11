package classes;
import java.util.Scanner;
public class Login
{
 public  void Login()
	 {
        Scanner sc = new Scanner(System.in);
        String sp=" ";
        System.out.println("Enter the Username");
        String uname = sc.nextLine();
        if((uname.contains(sp)) || uname.length()<4)
	{
            System.out.println("Invalid Username");
                  Login login=new Login();
	login.Login();
	}

        System.out.println("Enter the Password");
        String upass = sc.nextLine();
        if((upass.contains(sp)) || upass.length()<6)
	{
            System.out.println("Invalid Password");
                  Login login=new Login();
	login.Login();
	}

        System.out.println(uname+" you are Registered Successfully");

	
        System.out.println("Again Enter the Username");
        String lname = sc.nextLine();
        System.out.println("Again Enter the Password");
        String lpass = sc.nextLine();



           if(uname.equals(lname) && upass.equals(lpass))
            {
            System.out.println("Welcome "+lname+" you have Logged-in Successfully");
            }

           else
           {
	System.out.println("Username or Password Mismatch");
	System.out.println("Please Try Again");
                   Login login=new Login();
	login.Login();
	 
           }    

	
    }
}