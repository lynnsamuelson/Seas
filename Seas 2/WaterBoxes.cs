using System;

namespace Seas
{
    public class WaterBoxes
    {
        public decimal WaterBox(decimal length, decimal width, decimal height)
        {
           
            //calc volume in liters
            decimal liters = CalcLiters( length,  width, height);

            //calc next full liter
            decimal nextLiter = Math.Ceiling(liters);

            //calc difference between volume and next full leader 
            decimal diffMililiters = (nextLiter - liters)*1000;
           
            //mililiters = Math.Round(mililiters, 4);
            return Math.Round(diffMililiters, 4); //multiply by 1000 to convert to mililiters 
        }

        public decimal CalcLiters(decimal length, decimal width, decimal height)
        {
            decimal lengthCM = ConvertToCentimeters(length);
            decimal widthCM = ConvertToCentimeters(width);
            decimal heightCM = ConvertToCentimeters(height);

            decimal volume = Decimal.Multiply(lengthCM, Decimal.Multiply(widthCM, heightCM)); //this is in cm3

            return volume/1000; //this converts to liters
        }

        public decimal ConvertToCentimeters(decimal inches)
        {
            return Decimal.Multiply(inches, new decimal(2.54));
        }

    }
}
