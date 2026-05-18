using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3,4);
        Fraction fraction4 = new Fraction(1,3);

        fraction1.ReturnFractionString();
        fraction1.ReturnDecimalValue();

        fraction2.ReturnFractionString();
        fraction2.ReturnDecimalValue();

        fraction3.ReturnFractionString();
        fraction3.ReturnDecimalValue();

        fraction4.ReturnFractionString();
        fraction4.ReturnDecimalValue();

    }
}