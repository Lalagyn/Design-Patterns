namespace SubscriptionFactory
{
    public class MobileApp
    {
        public Subscription CreateSubscription(string type)
        {
            switch (type)
            {
                case "Domestic":
                    return new DomesticSubscription("MobileApp");
                case "Educational":
                    return new EducationalSubscription("MobileApp");
                case "Premium":
                    return new PremiumSubscription("MobileApp");
                default:
                    throw new ArgumentException("Невідомий тип підписки");
            }
        }
    }
}