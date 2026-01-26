using System;

public class AppConfig
{
    public string AppName { get; set; }
    public double Version { get; set; }
    public bool IsPro { get; set; }

    public AppConfig(string appName, double appVersion, bool isPro)
    {
        AppName = appName;
        Version = appVersion;
        IsPro = isPro;
    }
    
    public AppConfig()
    {
        AppName = "";
        Version = 0;
        IsPro = false;
    }
}