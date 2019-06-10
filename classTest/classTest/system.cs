using System;

public class SystemEcorp{
    public int systemLife = 100;
    public SystemEcorp(int systemLife)
    {
        this.systemLife = systemLife;
    }
    public int hackMe()
    {
        return systemLife - 10;
    }
}