using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    //น.ส.1กัญญาภ้ค วงษ์ต่าย Section 229B เลขที่ 4

    // Start is called before the first frame update
    void Start()
    {
        IronMan ironMan = new IronMan("Tony", 100, "Red");
        Debug.Log($"IronMan name: {ironMan.Name}, Hp: {ironMan.Hp}, Color: {ironMan.SuitColor} ");

        ironMan.Fly();
        ironMan.ShootLaser();
        ironMan.UpdateAromorStrength(5.25f);


        CaptainAmerica captainAmerica = new CaptainAmerica("Stave", 100, "Blue");
        Debug.Log($"CaptainAmerica name: {captainAmerica.Name}, Hp: {captainAmerica.Hp}, Color: {captainAmerica.SuitColor}");

        captainAmerica.LeapAndJump();
        captainAmerica.ThrowShield();
        captainAmerica.UpdateAromorStrength(5.25f);



        System.Random rand = new System.Random(); //ใช้ในการรัน
        for (int i = 0; i < 5; i++)
        {
            // IronMan โจมตี
            ironMan.ShootLaser();
            int damageToCaptainAmerica = rand.Next(10, 21);
            captainAmerica.TakeDamage(damageToCaptainAmerica);
            //เช็คว่ากัปตันขิตยัง
            if (captainAmerica.IsDead())
            {
                break;
            }



            // กัปตันต่อยไอรอนแมน
            captainAmerica.ThrowShield();
            int damageToironMan = rand.Next(10, 21);
            ironMan.TakeDamage(damageToironMan);
            //เช็คว่าไอรอนแมนขิตยัง
            if (ironMan.IsDead())
            {
                break;
            }


        }

        
    }// ใส่ class Random ยังไงหรอคะ TT
}
