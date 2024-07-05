public class Solution {
    public const int M = 1000;
    public const int CM = 900;
    public const int D = 500;
    public const int CD = 400;
    public const int C = 100;
    public const int XC = 90;
    public const int L = 50;
    public const int XL = 40;
    public const int X = 10;
    public const int IX = 9;
    public const int V = 5;
    public const int IV = 4;
    public const int I = 1;

    public string IntToRoman(int num) {
        if (num >= (M*3)) return "MMM" + IntToRoman(num - (M*3));
        if (num >= (M*2)) return "MM" + IntToRoman(num - (M*2));
        if (num >= M) return "M" + IntToRoman(num - M);
        if (num >= CM) return "CM" + IntToRoman(num - CM);
        if (num >= D) return "D" + IntToRoman(num - D);
        if (num >= CD) return "CD" + IntToRoman(num - CD);
        if (num >= (C*3)) return "CCC" + IntToRoman(num - (C*3));
        if (num >= (C*2)) return "CC" + IntToRoman(num - (C*2));
        if (num >= C) return "C" + IntToRoman(num - C);
        if (num >= XC) return "XC" + IntToRoman(num - XC);
        if (num >= L) return "L" + IntToRoman(num - L);
        if (num >= XL) return "XL" + IntToRoman(num - XL);
        if (num >= (X*3)) return "XXX" + IntToRoman(num - (X*3));
        if (num >= (X*2)) return "XX" + IntToRoman(num - (X*2));
        if (num >= X) return "X" + IntToRoman(num - X);
        if (num >= IX) return "IX" + IntToRoman(num - IX);
        if (num >= V) return "V" + IntToRoman(num - V);
        if (num >= IV) return "IV" + IntToRoman(num - IV);
        if (num >= (I*3)) return "III" + IntToRoman(num - (I*3));
        if (num >= (I*2)) return "II" + IntToRoman(num - (I*2));
        if (num >= I) return "I" + IntToRoman(num - I);
        return "";
    }
}