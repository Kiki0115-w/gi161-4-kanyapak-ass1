using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero : MonoBehaviour
{
    // Attributes
    protected string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value == null || value == "")
            {
                value = "N/A";

                name = value;

            }
        }

    }
    public string Names;


    protected int hp;
    public int Hp { get { return hp; } set { hp = value; } }


    public string SuitColor { get; private set; }  // ใส่ protected ก็ได้ตรง 


    private float armorStrength;


   

    public void TakeDamage(int damage)
    {
        hp -= damage;  // เลือดลดดาเมท
        Debug.Log($"{name}: took {damage} damage, Hp: {hp}"); //บอกว่าโดนต่อยแล้วเลือดลด


        if (IsDead())
        {
            Debug.Log($"{name} is dead!!"); //ถ้าขิตให้รันขึ้น ชื่อ...ตายแล้ว
        }
    }

    public bool IsDead()
    {
        if (hp <= 0)
        {
            return true;
        }
        return false;
    }

    public void UpdateArmorStrength(float strength)
    {

        armorStrength += strength;
        Debug.Log($"{name} updated their armor to {armorStrength}");

    }

    
}
