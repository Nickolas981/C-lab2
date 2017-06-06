using System;


namespace OTP_Lab2
{
    class Dollar : Currency
    {
        public Dollar(float value) : base(value)
        {
            cUAH = 25.25f;
            Type = "USD";
        }


        public static Dollar operator +(Dollar d1, Dollar d2)
        {
            return new Dollar(d1.Value + d2.Value);
        }

        public static Dollar operator -(Dollar d1, Dollar d2)
        {
            return new Dollar(d1.Value - d2.Value);
        }

        public static Dollar operator *(Dollar d1, float d2)
        {
            return new Dollar(d1.Value * d2);
        }

        public static Dollar operator /(Dollar d1, float d2)
        {
            return new Dollar(d1.Value / d2);
        }
    }
}
