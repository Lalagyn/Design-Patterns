namespace SubscriptionFactory
{
    public class ManagerCall
    {
        public Subscription CreateSubscription(string type)
        {
            switch (type)
            {
                case "Domestic":
                    return new DomesticSubscription("ManagerCall");
                case "Educational":
                    return new EducationalSubscription("ManagerCall");
                case "Premium":
                    return new PremiumSubscription("ManagerCall");
                default:
                    throw new ArgumentException("Невідомий тип підписки");
            }
        }
    }
}