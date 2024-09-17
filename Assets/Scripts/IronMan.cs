using System;
using UnityEngine;


class IronMan : SuperHero
{
    public IronMan(string newName, int newHp, string newSuitColor)
        : base(newName, newHp, newSuitColor) 
    {
       
    }

    public void Fly()
    {
        Debug.Log($"{name} is flying");
            
    }

    public void ShootLaser()
    {
        Debug.Log($"{name} is shooting lasers");

    }

}