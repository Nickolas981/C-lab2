namespace OTP_Lab2
{
    interface ICurrency
    {
        float ToUAH();
        float FromUAH(float UAH);
        string Type { get; }

        float Value { get; set; }
    }
}
