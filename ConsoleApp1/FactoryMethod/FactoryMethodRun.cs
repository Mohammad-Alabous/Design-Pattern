namespace ME_FactoryMethod {
    public static class FactoryMethodRun {
        public static void Run() {
            PaymentProcessorFactory paymentProcessorFactory;

            paymentProcessorFactory = new CreditCardFactory();
            paymentProcessorFactory.ProcessPayment(20m);

            paymentProcessorFactory = new PayPalFactory();
            paymentProcessorFactory.ProcessPayment(30m);
        }
    }
}