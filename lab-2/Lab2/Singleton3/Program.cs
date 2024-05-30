using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => AuthenticateUser("user1", "password1"),
                () => AuthenticateUser("user2", "password2"),
                () => AuthenticateUser("user3", "password3")
            );

            Console.ReadLine();
        }

        static void AuthenticateUser(string username, string password)
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate(username, password);
        }
    }
}