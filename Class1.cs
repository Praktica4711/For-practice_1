using System;

public class CalClass
{
	public static double CalClassOp(double a, double b, string oper)
	{
		double res = double.NaN;
		switch (oper)
		{
			case "plus":
				res = a + b;
				break;
			case "minus":
				res = a - b;
				break;
			case "sum":
				res = a * b;
				break;
			case "dif":
				if (b != 0)
				{
					res = a / b;
				}
				break;
			case "grade":
                {
					int i = 0;
					do
					{
						i++;
						res = a * a;
					}
					while (i <= b);
                }
                break;

		break;
        }
        return res;
	}
	
}
