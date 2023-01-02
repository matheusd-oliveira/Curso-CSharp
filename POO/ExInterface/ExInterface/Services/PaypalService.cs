namespace ExInterface.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return 0.0;
        }

        public double Interest(double amount, int months)
        {
            return 0.0;
        }

    }
}
