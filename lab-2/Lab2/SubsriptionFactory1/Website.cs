namespace SubscriptionFactory
{
    public class WebSite
    {
        public Subscription CreateSubscription(string type)
        {
            switch (type)
            {
                case "Domestic":
                    return new DomesticSubscription("WebSite");
                case "Educational":
                    return new EducationalSubscription("WebSite");
                case "Premium":
                    return new PremiumSubscription("WebSite");
                default:
                    throw new ArgumentException("Невідомий тип підписки");
            }
        }
    }
}