using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int LossyAbs(int value)
        {
            if(value >= 0) return value;
            if(value == int.MinValue) return int.MaxValue;
            return -value;
        }

        public static int Divide(int dividend, int divisor) {
            int qt = 0;
        int sign = 1;
        if((dividend < 0 || divisor <0) && !(dividend < 0 && divisor <0))
            sign = -1;
        if (LossyAbs(dividend) < LossyAbs(divisor)) return 0;
        if(dividend == int.MaxValue && divisor == int.MinValue ) return 0;
        if (LossyAbs(divisor) <= 5){
            if(LossyAbs(dividend) == int.MaxValue)
            {
                if((dividend < 0 && divisor <0)||(dividend > 0 && divisor >0)){
                    return int.MaxValue / LossyAbs(divisor);
                } 
                
                return int.MinValue / LossyAbs(divisor);
            }
            if(LossyAbs(dividend) == int.MinValue){
                return sign * LossyAbs(dividend);
            }
        } 
        var temp = dividend;
        do{
            temp = LossyAbs(temp) - LossyAbs(divisor);
            qt++; 
        }while(LossyAbs(temp) > LossyAbs(divisor));

        return sign * qt;
        }
    }
}