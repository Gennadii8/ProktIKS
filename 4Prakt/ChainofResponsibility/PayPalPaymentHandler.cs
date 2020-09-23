using System;

namespace ChainofResponsibility
{
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("PayPal transfer in process...");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
