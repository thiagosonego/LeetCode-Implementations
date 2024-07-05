public class Solution {

    public string IntToRoman(int num) {
        if (num >= 3000) return "MMM" + IntToRoman(num - 3000);
        if (num >= 2000) return "MM" + IntToRoman(num - 2000);
        if (num >= 1000) return "M" + IntToRoman(num - 1000);
        if (num >= 900) return "CM" + IntToRoman(num - 900);
        if (num >= 800) return "DCCC" + IntToRoman(num - 800);
        if (num >= 700) return "DCC" + IntToRoman(num - 700);
        if (num >= 600) return "DC" + IntToRoman(num - 600);
        if (num >= 500) return "D" + IntToRoman(num - 500);
        if (num >= 400) return "CD" + IntToRoman(num - 400);
        if (num >= 300) return "CCC" + IntToRoman(num - 300);
        if (num >= 200) return "CC" + IntToRoman(num - 200);
        if (num >= 100) return "C" + IntToRoman(num - 100);
        if (num >= 90) return "XC" + IntToRoman(num - 90);
        if (num >= 80) return "LXXX" + IntToRoman(num - 80);
        if (num >= 70) return "LXX" + IntToRoman(num - 70);
        if (num >= 60) return "LX" + IntToRoman(num - 60);
        if (num >= 50) return "L" + IntToRoman(num - 50);
        if (num >= 40) return "XL" + IntToRoman(num - 40);
        if (num >= 30) return "XXX" + IntToRoman(num - 30);
        if (num >= 20) return "XX" + IntToRoman(num - 20);
        if (num >= 10) return "X" + IntToRoman(num - 10);
        if (num >= 9) return "IX" + IntToRoman(num - 9);
        if (num >= 8) return "VIII" + IntToRoman(num - 8);
        if (num >= 7) return "VII" + IntToRoman(num - 7);
        if (num >= 6) return "VI" + IntToRoman(num - 6);
        if (num >= 5) return "V" + IntToRoman(num - 5);
        if (num >= 4) return "IV" + IntToRoman(num - 4);
        if (num >= 3) return "III" + IntToRoman(num - 3);
        if (num >= 2) return "II" + IntToRoman(num - 2);
        if (num >= 1) return "I" + IntToRoman(num - 1);
        return "";
    }
}