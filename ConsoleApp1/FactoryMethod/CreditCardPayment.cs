namespace ME_FactoryMethod {
    public class CreditCardPayment : IPaymentProcessor {
        public void ProcessPayment(decimal amount) {
            Console.WriteLine($"Credit Card Amount Is: {amount}");
        }
    }
}