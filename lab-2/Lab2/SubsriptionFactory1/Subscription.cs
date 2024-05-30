using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionFactory
{
    public abstract class Subscription
    {
        public double MonthlyFee { get; protected set; }
        public int MinimumPeriod { get; protected set; }
        public List<string> Channels { get; protected set; }
        public List<string> Features { get; protected set; }
        public string PurchasedThrough { get; protected set; }

        protected Subscription()
        {
            Channels = new List<string>();
            Features = new List<string>();
        }

        public override string ToString()
        {
            return $"Місячна плата: {MonthlyFee}, Мінімальний період: {MinimumPeriod} місяців, Канали: {string.Join(", ", Channels)}, Можливості: {string.Join(", ", Features)}, Куплено через: {PurchasedThrough}";
        }
    }

    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription(string purchasedThrough)
        {
            MonthlyFee = 10.0;
            MinimumPeriod = 6;
            Channels.AddRange(new List<string> { "Місцеві новини", "Спорт", "Розваги" });
            Features.Add("HD Якість");
            PurchasedThrough = purchasedThrough;
        }
    }

    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription(string purchasedThrough)
        {
            MonthlyFee = 8.0;
            MinimumPeriod = 3;
            Channels.AddRange(new List<string> { "Освітні", "Документальні", "Наука" });
            Features.AddRange(new List<string> { "HD Якість", "Офлайн доступ" });
            PurchasedThrough = purchasedThrough;
        }
    }

    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription(string purchasedThrough)
        {
            MonthlyFee = 20.0;
            MinimumPeriod = 12;
            Channels.Add("Всі канали");
            Features.AddRange(new List<string> { "4K Якість", "Кілька екранів", "Без реклами" });
            PurchasedThrough = purchasedThrough;
        }
    }
}
