/*
 * WCF Service
 * lufer & Oscar
 * 2024-2025
 * */

using System;

public class CalcService : ICalcService
{

	public int Sum(int x, int y)
    {
		return x + y;
    }
 

    public int Sub(int x, int y)
    {
        return x - y;
    }

    public float Div(int x, int y)
    {
       
        return (x / y);
    }
    public int Mult(int x, int y)
    {
        return x * y;
    }


}
