namespace ME_FactoryMethod {
    public abstract class PaymentProcessorFactory {
        public abstract IPaymentProcessor CreatePaymentProcessor();
        public void ProcessPayment(decimal amount) {
            var paymentProcessor = CreatePaymentProcessor();
            paymentProcessor.ProcessPayment(amount);
        }
    }
}