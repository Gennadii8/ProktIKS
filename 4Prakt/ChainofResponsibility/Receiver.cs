﻿

namespace ChainofResponsibility
{
    class Receiver
    {
        //bank transfer
        public bool BankTransfer { get; set; }

        //Money transfer
        public bool MoneyTransfer { get; set; }

        //PayPal transfer
        public bool PayPalTransfer { get; set; }

        public Receiver(bool bt, bool mt, bool ppt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
    }
}
