
using System;

[Serializable]
public class StarData
{
    public string name;
    public float rightAscension;
    public float declination;
//these are the only fields i'm using at the minute to spawn the stars
    
    public float magnitude;
    public string constellation;
    public string spectralType;
    //i might implement these eventually to make different looking stars
}