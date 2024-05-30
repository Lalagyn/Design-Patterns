using System;

namespace SingletonPattern
{
    public sealed class Authenticator
    {
        private static Authenticator instance = null;
        private static readonly object padlock = new object();

        private Authenticator()
        {
            // Приватний конструктор для запобігання створенню екземплярів ззовні
        }

        public static Authenticator Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Authenticator();
                    }
                    return instance;
                }
            }
        }

        public void Authenticate(string username, string password)
        {
            // Логіка аутентифікації
            Console.WriteLine($"Authenticating user {username}");
        }
    }
}