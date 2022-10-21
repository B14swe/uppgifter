using System;
using Inputchecker;
Username user = new Username();

static void Userinfo(Username user)
{
    Console.WriteLine("Vad vill du heta?");
    string name = Console.ReadLine();
    bool bo1 = string.IsNullOrEmpty(name);

    if (bo1)
    {
        Console.WriteLine("No empty username");
        Userinfo(user);

    }
    else
        passwinfo(user);

    user.Setuser(name);


}
static void passwinfo(Username user)
{
    Console.WriteLine("Vad ska ditt lösenord vara?");
    string pass = Console.ReadLine();
    if (pass.Length > 2 && (pass.Length < 8))
    {
        Console.WriteLine("har du dyslexi?");
    }
    user.SetPassword(pass);

}


Userinfo(user);


user.Getuser();
user.GetPassword();











/*string username;
string password;


static void Input(string[] args)
{
    string input = Console.ReadLine(); 
}


static void usernames(string username)
{
    Console.WriteLine("Vad vill du heta?");
    username = Console.ReadLine();

    bool bo1 = string.IsNullOrEmpty(username);

    if (bo1)
    {
        Console.WriteLine("No empty password");

    }
    else
        passwords();


}
    static void passwords()
    {
        string password;
        password = Console.ReadLine();
        Console.WriteLine("skriv ditt lösenord");
        if (password.Length > 2 && (password.Length < 8))
        {
            Console.WriteLine("har du dyslexi?");
        }
    }

       

*/