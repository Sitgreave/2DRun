using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroOnStart : SaveState
{
    private void Awake()
    {
        resetStats();
        loadSave();
        HeroStats.live = true;
    }
    private void Start()
    {
        HeroStats.local_coins = 0;
        HeroStats.local_hero_hitpoints = HeroStats.hero_hitpoints;
        HeroStats.local_hero_damage = HeroStats.hero_damage;
        HeroStats.speed_multiply = 2.5f;
        Time.timeScale = 1;
    }
    private void Update()
    {
        HeroStats.local_hero_hitpoints += 1;
    }
}
