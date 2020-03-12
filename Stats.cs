using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : basicBattleObject
{
    public int maxMana { get; set; }
    public int currentMana;

    public Stats(int MaxHp, string EName, string Description, int Accuracy, int Speed, int Defense, int Strength, int Lvl, Attacks[] MoveSet, int MaxMana)
    {
        Name = EName;
        description = Description;

        maxhp = MaxHp;
        accuracy = Accuracy;
        speed = Speed;
        defense = Defense;
        strength = Strength;
        lvl = Lvl;
        maxMana = MaxMana;

        currentMana = maxMana;
        currenthp = maxhp;

        for (int i = 0; i < MoveSet.Length; i++)
        {
            moveSet.Add(MoveSet[i]);
        }
    }
}
