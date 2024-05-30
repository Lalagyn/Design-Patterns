using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            WebSite webSite = new WebSite();
            MobileApp mobileApp = new MobileApp();
            ManagerCall managerCall = new ManagerCall();

            Subscription domesticSubscription = webSite.CreateSubscription("Domestic");
            Subscription educationalSubscription = mobileApp.CreateSubscription("Educational");
            Subscription premiumSubscription = managerCall.CreateSubscription("Premium");

            Console.WriteLine("Домашня підписка (куплено через WebSite):");
            DisplaySubscription(domesticSubscription);

            Console.WriteLine("\nОсвітня підписка (куплено через MobileApp):");
            DisplaySubscription(educationalSubscription);

            Console.WriteLine("\nПреміум підписка (куплено через ManagerCall):");
            DisplaySubscription(premiumSubscription);
        }

        static void DisplaySubscription(Subscription subscription)
        {
            Console.WriteLine($"Місячна плата: {subscription.MonthlyFee}");
            Console.WriteLine($"Мінімальний період: {subscription.MinimumPeriod} місяців");
            Console.WriteLine($"Канали: {string.Join(", ", subscription.Channels)}");
            Console.WriteLine($"Можливості: {string.Join(", ", subscription.Features)}");
            Console.WriteLine($"Куплено через: {subscription.PurchasedThrough}");
        }
    }
}
