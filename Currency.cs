using System;

namespace OTP_Lab2
{
    abstract class Currency : ICurrency
    {
        public string Type { get; protected set; }

        private float val;

        public float Value
        {
            get { return (float)Math.Round(val, 2); }
            set { val = (float)Math.Round(value, 2); }
        }
        protected float cUAH;


        public Currency(float value)
        {
            Value = value;
        }

        public float ToUAH()
        {
            return Value * cUAH;
        }

        public float FromUAH(float UAH)
        {
            if (cUAH == 0)
                return 0;
            return Value = UAH / cUAH;
        }

        public int ToCent()
        {
            return (int)Value * 100;
        }

        public override bool Equals(object obj)
        {
            Currency c = obj as Currency;
            if ((object)c == null)
                return false;
            return this.ToUAH() == c.ToUAH();
        }


        public override string ToString()
        {
            return $"{Value} {Type}";
        }

        public override int GetHashCode()
        {
            return (int)(Math.Round(Value, 2) * 100) ^ (int)(Math.Round(cUAH, 3) * 1000);
        }

        public static bool operator ==(Currency c1, Currency c2)
        {
            if ((object)c1 == null)
                if ((object)c2 == null)
                    return true;
                else return false;
            return c1.Equals(c2);
        }

        public static bool operator !=(Currency c1, Currency c2)
        {
            if ((object)c1 == null)
                if ((object)c2 == null)
                    return false;
                else return true;
            return !c1.Equals(c2);
        }
    }
}
