using System;

namespace facade
{
    class Power
    {
        public event EventHandler powerevent;
        private int _power;

        public int MicrowaverPower
        {
            get { return _power; }
            set
            {
                _power = value;
                if (powerevent != null)
                    powerevent(this, new EventArgs());
            }
        }

        public override string ToString()
        {
            string s = String.Format("Enter the power {0}w ", MicrowaverPower);
            return s;
        }
    }
}
