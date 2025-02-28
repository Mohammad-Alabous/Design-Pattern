namespace ME_FactoryMethod {
    public class PayPalPayment : IPaymentProcessor {
        public void ProcessPayment(decimal amount) {
            Console.WriteLine($"PayPal Amount Is: {amount}");
        }
    }
}