using System;

namespace OTP_Lab2
{
    class Euro : Currency
    {
        public Euro(float value) : base(value)
        {
            cUAH = 28.25f;
            Type = "EUR";
        }

        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1.Value + e2.Value);
        }

        public static Euro operator -(Euro e1, Euro e2)
        {
            return new Euro(e1.Value - e2.Value);
        }

        public static Euro operator *(Euro e1, float e2)
        {
            return new Euro(e1.Value * e2);
        }

        public static Euro operator /(Euro e1, float e2)
        {
            return new Euro(e1.Value / e2);
        }
    }
}
