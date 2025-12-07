using System;

public struct RGBColor
{
    public int R;
    public int G;
    public int B;
    
    public RGBColor(int r, int g, int b)
    {
        R = Limit(r);
        G = Limit(g);
        B = Limit(b);
    }
    private static int Limit(int value)
    {
        if (value < 0) 
            return 0;
        if (value > 255) 
            return 255;
        return value;
    }
    
    public void Show()
    {
        Console.WriteLine($"RGB({R}, {G}, {B})");
    }
    
    public void ToHEX()
    {
        Console.WriteLine($"From RGB to HEX: #{R:X2}{G:X2}{B:X2}");
    }
    
    public void ToHSL()
    {
        double r = R / 255.0;
        double g = G / 255.0;
        double b = B / 255.0;

        double max = Math.Max(r, Math.Max(g, b));
        double min = Math.Min(r, Math.Min(g, b));
        double h = 0, s, l = (max + min) / 2.0;

        if (max == min)
        {
            h = s = 0;
        }
        else
        {
            double d = max - min;
            s = l > 0.5 ? d / (2 - max - min) : d / (max + min);

            if (max == r)
                h = (g - b) / d + (g < b ? 6 : 0);
            else if (max == g)
                h = (b - r) / d + 2;
            else if (max == b)
                h = (r - g) / d + 4;

            h *= 60;
        }
        Console.WriteLine($"From RGB to HSL: {Math.Round(h, 2)}°, S: {Math.Round(s * 100, 2)}%, L: {Math.Round(l * 100, 2)}%");
    }
    
    public void ToCMYK()
    {
        double r = R / 255.0;
        double g = G / 255.0;
        double b = B / 255.0;

        double k = 1 - Math.Max(r, Math.Max(g, b));
        double c, m, y;

        if (k == 1)
        {
            c = m = y = 0;
            k = 100;
        }
        else
        {
            c = (1 - r - k) / (1 - k);
            m = (1 - g - k) / (1 - k);
            y = (1 - b - k) / (1 - k);
            k *= 100;
        }

        Console.WriteLine($"From RGB to CMYK: {Math.Round(c * 100, 2)}%, M: {Math.Round(m * 100, 2)}%, Y: {Math.Round(y * 100, 2)}%, K: {Math.Round(k, 2)}%");
    }


}