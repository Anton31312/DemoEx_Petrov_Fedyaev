using System;

namespace WSUniversalLib
{
    public class Calculation
    {
       public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if ((productType == 1 || productType == 2 || productType == 3) && (materialType == 1 || materialType == 2))
            {
                double n = 0;
                if (materialType == 1)
                {
                    n = 0.003;
                }
                else if (materialType == 2)
                {
                    n = 0.0012;
                }

                double result = 0;
                switch (productType)
                {
                    case 1:
                        result = (width * length * 1.1 * count * n) + (width * length * 1.1 * count);
                        break;
                    case 2:
                        result = (width * length * 2.5 * count * n) + (width * length * 2.5 * count);
                        break;
                    case 3:
                        result = (width * length * 8.43 * count * n) + (width * length * 8.43 * count);
                        break;
                }
                return Convert.ToInt32(result);
            }
            else
            {
                return -1;
            }
        }
    }
}
