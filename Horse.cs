using System;

public class Horse
{
    int _legs;
    string _tail;
    string _shortneck;
    string _largebody;

    public int Legs
    {
        get
        { return _legs; }
        set
        { _legs = value; }
    }

    public string Tail
    {
        get
        { return _tail; }
        set
        { _tail = value; }
    }

    public string Shortneck
    {
        get
        { return _shortneck; }
        set
        { _shortneck = value; }
    }

    public string Largebody
    {
        get
        { return _largebody; }
        set
        { _largebody = value; }
    }
    public virtual void Racing()
    {
        Console.WriteLine("Horse Goes Racing");
    } // end method racing

    public void Racing(string HorseGoesRacing)
    {
    
    }

} // end class horse


