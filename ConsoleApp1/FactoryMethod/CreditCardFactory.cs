namespace ME_FactoryMethod {
    public class CreditCardFactory : PaymentProcessorFactory
    {
        public override IPaymentProcessor CreatePaymentProcessor()
        {
            return new CreditCardPayment();
        }
    }
}