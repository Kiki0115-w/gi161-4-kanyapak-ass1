using System;
using UnityEngine;


public class IronMan : SuperHero
{
   
    public void Fly()
    {
        Debug.Log($"{name} is flying");
            
    }

    public void ShootLaser()
    {
        Debug.Log($"{name} is shooting lasers");

    }

}