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


    public string SuitColor { get; private set; }  // ��� protected ����ç 


    private float armorStrength;


   

    public void TakeDamage(int damage)
    {
        hp -= damage;  // ���ʹŴ�����
        Debug.Log($"{name}: took {damage} damage, Hp: {hp}"); //�͡���ⴹ�����������ʹŴ


        if (IsDead())
        {
            Debug.Log($"{name} is dead!!"); //��ҢԵ����ѹ��� ����...�������
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
