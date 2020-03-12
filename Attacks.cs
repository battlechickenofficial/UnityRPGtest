using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Attacks : ScriptableObject
{
    public string attackName;
    public string description;
    public int minDamage;
    public int maxDamage;
    public int accuracy;

    public int manaCost;
    public int backFire;
    public int neededCharges;

    public Attacks(string AttackName, string Description, int MinDamage, int MaxDamage, int Accuracy, int ManaCost, int BackFire, int NeededCharges)
    {
        attackName = AttackName;
        description = Description;
        minDamage = MinDamage;
        maxDamage = MaxDamage;
        accuracy = Accuracy;

        manaCost = ManaCost;
        backFire = BackFire;
        neededCharges = NeededCharges;
    }

}
