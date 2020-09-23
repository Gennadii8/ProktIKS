using System;

namespace facade
{
    class Notification
    {
        public event EventHandler notificationevent;

        private string mess;

        public string MessageFin
        {
            get { return mess; }
            set
            {
                mess = value;
                if (notificationevent != null)
                    notificationevent(this, new EventArgs());
            }
        }

        public void StartNotification()
        {
            MessageFin = "Operation started";
        }

        public void StopNotification()
        {
            MessageFin = "Operation finished";
        }

        public override string ToString()
        {
            string s = String.Format("Information: {0}", MessageFin);
            return s;
        }

    }
}
