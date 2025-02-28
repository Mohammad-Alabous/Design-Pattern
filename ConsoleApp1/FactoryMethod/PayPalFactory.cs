namespace ME_FactoryMethod {
    public class PayPalFactory : PaymentProcessorFactory
    {
        public override IPaymentProcessor CreatePaymentProcessor()
        {
            return new PayPalPayment();
        }
    }
}