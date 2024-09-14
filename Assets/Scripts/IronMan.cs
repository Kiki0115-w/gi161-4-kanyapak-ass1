using System;
using UnityEngine;


class IronMan
{
    //น.ส.1กัญญาภ้ค วงษ์ต่าย Section 229B เลขที่ 4



    // Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrength;


    // Contructor
    public IronMan(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;

        armorStrength = 10;
    }

    public void Fly()
    {
        Debug.Log($"------ {Name} is flying");
            
    }

    public void ShootLaser()
    {
        Debug.Log($"====== {Name} is shooting lasers");

    }

    public void UpdateAromorStrength( float strength)
    {

        armorStrength += strength; 
        Debug.Log($"{Name} updated their armor to {armorStrength}");

    }

    public bool IsDead()
    {
        if (Hp <= 0)
        {
            return true;
        }
        return false;
    }  


    public void TakeDamage(int damage)
    {
        Hp -= damage;  // เลือดลดดาเมท
        Debug.Log($"{Name}: took {damage} damage, Hp: {Hp}"); //บอกว่าโดนต่อยแล้วเลือดลด


        if (IsDead())
        {
            Debug.Log($"{Name} is dead!!"); //ถ้าขิตให้รันขึ้น ชื่อ...ตายแล้ว
        }
    }

    


}