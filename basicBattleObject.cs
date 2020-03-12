using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicBattleObject : MonoBehaviour
{
    public string Name { get; set; }
    public string description { get; set; }
    public int maxhp { get; set; }
    public int currenthp = 0;

    public int accuracy { get; set; }
    public int speed { get; set; }
    public int defense { get; set; }
    public int strength { get; set; }
    public int lvl { get; set; }

    public List<Attacks> moveSet = new List<Attacks>();

    //Private Stats
    public int remainingCharges = 0;
    public bool isCharging = false;

    public void TakeDamage(int takenDamage)
    {
        currenthp -= takenDamage;
        if (currenthp <= 0)
        {
            //Die
        }
    }
}
