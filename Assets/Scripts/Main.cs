using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    IronMan ironMan = new IronMan("Tony", 100, "Red");
    CaptainAmeriac captainAmerica = new CaptainAmeriac("Stave", 100, "Blue");
    
    

    // Start is called before the first frame update
    void Start()
    {
        ironMan.Name = "KiKi";


        Debug.Log($"IronMan name: {ironMan.Name}, Hp: {ironMan.Hp}, Color: {ironMan.SuitColor} ");
        Debug.Log($"CaptainAmerica name: {captainAmerica.Name}, Hp: {captainAmerica.Hp}, Color: {captainAmerica.SuitColor}");

        
        ironMan.UpdateArmorStrength(5.25f);
        captainAmerica.UpdateArmorStrength(5.25f);

        
    }// ใส่ class Random ยังไงหรอคะ TT

    private void Update()
    {

        if (ironMan.IsDead() || captainAmerica.IsDead())
        {
            return;
        }

        System.Random rand = new System.Random();   
        int randomDamage = rand.Next(10, 21);
        ironMan.ShootLaser();
        captainAmerica.TakeDamage(randomDamage);

        int randomDamag = rand.Next(10, 21);
        captainAmerica.ThrowShield();
        ironMan.TakeDamage(randomDamage);



    }
}
