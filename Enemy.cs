using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : basicBattleObject
{
    public Enemy(int MaxHp, string EName, string Description, int Accuracy, int Speed, int Defense, int Strength, int Lvl, Attacks[] MoveSet)
    {
        Name = EName;
        description = Description;

        maxhp = MaxHp;
        accuracy = Accuracy;
        speed = Speed;
        defense = Defense;
        strength = Strength;
        lvl = Lvl;

        currenthp = maxhp;

        for (int i = 0; i < MoveSet.Length; i++)
        {
            moveSet.Add(MoveSet[i]);
        }
    }

    public void pickMove()
    {
        Attacks attack = null;

        if(isCharging == false)
        {
            attack = moveSet[Random.Range(0, 4)];

            if (attack.backFire >= currenthp)
            {
                pickMove();
            }
            else
            {
                remainingCharges = attack.neededCharges;
                isCharging = true;
            }
        }
        else
        {
            remainingCharges -= 1;

            if(remainingCharges <= 0)
            {
                Attack(attack);
            }
        }
    }

    public void Attack(Attacks attack)
    {
        if(Random.Range(0, 100) <= accuracy / attack.accuracy * 2)
        {
            //Attack hits
        }
        else
        {
            //AttackMisses
        }
    }
}
