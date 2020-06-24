using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroLevel : MonoBehaviour
{
    private int[] expToLvlUp = { 100, 1_000, 3_000, 5_000, 8_000, 12_000, 17_000, 23_000, 30_000, 40_000 };
    private void Update()
    { 
        if (HeroStats.experience >= expToLvlUp[HeroStats.level] && HeroStats.level <expToLvlUp.Length)
        {
            LevelUp();
        }
    }
    private void LevelUp()
    {
        HeroStats.experience -= expToLvlUp[HeroStats.level];
        HeroStats.level++;
        HeroStats.hero_damage++; HeroStats.local_hero_damage++;
        HeroStats.hero_hitpoints += 10; HeroStats.local_hero_hitpoints += 10;
        HeroStats.hero_armor += 1;
        HeroStats.hero_reduce_dps += 0.1f;
        HeroStats.heal += 1;
        // hero.gameObject.transform.localScale += new Vector3(0.3f, 0.3f, 0f) ;
    }
}   
