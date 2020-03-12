using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standard : MonoBehaviour
{
    public List<Enemy> enemies = new List<Enemy>();
    public List<Stats> heroes = new List<Stats>();

    int currentTurn = 0;
    public List<basicBattleObject> turnOrder = new List<basicBattleObject>();

    void Start()
    {
        for(int i = 0; i < enemies.Count; i++)
        {
            turnOrder.Add(enemies[i]);
        }
        for (int i = 0; i < heroes.Count; i++)
        {
            turnOrder.Add(heroes[i]);
        }

        getOrder();
        attackTurn();
    }

    public void attackTurn()
    {

    }

    public void getOrder()
    {
        turnOrder = turnOrder.OrderBy(o => o.speed).ToList();
    }
}
