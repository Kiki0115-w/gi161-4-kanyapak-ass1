using System;
using UnityEngine;


class CaptainAmeriac : SuperHero
{
    public CaptainAmeriac(string newName, int newHp, string newSuitColor)
        : base(newName, newHp, newSuitColor)
    {

    }

    public void LeapAndJump()
    {
        Debug.Log($"{name} is Leap and jump");

    }


    public void ThrowShield()
    {
        Debug.Log($"{name} is Throws a shield");

    }

}