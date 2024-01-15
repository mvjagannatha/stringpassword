using System;
class program
{
    static void Main()
    {
        const string loginid = "Admin";
        const string password= "password";
        int maxattempts = 3;
        int attempts = 0;
        while(attempts<maxattempts)
        {
            Console.WriteLine("enter loginid");
            string enteredlogin = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string enteredpassword=Console.ReadLine();
            if(enteredlogin==loginid && enteredpassword==password)
            {
                Console.WriteLine("login successful");
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine(" incorrect credentials:,no of attempts left={0}", (maxattempts-attempts));
            }

        }
        if(attempts==maxattempts)
        {
            Console.WriteLine("max attempts reached: your account is blocked");
        }
    }
}