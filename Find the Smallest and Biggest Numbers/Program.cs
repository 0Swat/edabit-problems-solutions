using System;
using System.Linq;
public class Program 
{
    public static double[] FindMinMax(double[] values)
    {
        double min = values[0];
        double max = values[0];
        foreach (var value in values)
        {
            if (value > max) max = value;
            if (value < min) min = value;
        }
        return new double[] { min, max };
    }
}