using System;

namespace OTP_Lab2
{
    class Pound : Currency
    {
        public Pound(float value) : base(value)
        {
            cUAH = 30.25f;
            Type = "GBP";
        }

        public static Pound operator +(Pound p1, Pound p2)
        {
            return new Pound(p1.Value + p2.Value);
        }

        public static Pound operator -(Pound p1, Pound p2)
        {
            return new Pound(p1.Value - p2.Value);
        }

        public static Pound operator *(Pound p1, float p2)
        {
            return new Pound(p1.Value * p2);
        }

        public static Pound operator /(Pound p1, float p2)
        {
            return new Pound(p1.Value / p2);
        }
    }
}
