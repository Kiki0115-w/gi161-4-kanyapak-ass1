using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public IronMan ironMan;
    public CaptainAmeriac captainAmerica;

    // Start is called before the first frame update
    void Start()
    {
        


        Debug.Log($"IronMan name: {ironMan.Name}, Hp: {ironMan.Hp}, Color: {ironMan.SuitColor} ");
        Debug.Log($"CaptainAmerica name: {captainAmerica.Name}, Hp: {captainAmerica.Hp}, Color: {captainAmerica.SuitColor}");

        
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
