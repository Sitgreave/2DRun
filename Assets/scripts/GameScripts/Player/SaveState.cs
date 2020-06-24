using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveState : MonoBehaviour
{
    public void savePPrefs()
    {
        PlayerPrefs.SetInt("hp", HeroStats.hero_hitpoints);
        PlayerPrefs.SetInt("exp", HeroStats.experience);
        PlayerPrefs.SetInt("dmg", HeroStats.hero_damage);
        PlayerPrefs.SetInt("coins", HeroStats.coins);
        PlayerPrefs.SetInt("lvl", HeroStats.level);
        PlayerPrefs.SetInt("armor", HeroStats.hero_armor);
        PlayerPrefs.SetInt("heal", HeroStats.heal);
        PlayerPrefs.SetFloat("reduce", HeroStats.hero_reduce_dps);
    }
    public void loadSave()
    {
        HeroStats.coins = PlayerPrefs.GetInt("coins");
        HeroStats.hero_hitpoints = PlayerPrefs.GetInt("hp");
        HeroStats.hero_damage = PlayerPrefs.GetInt("dmg");
        HeroStats.experience = PlayerPrefs.GetInt("exp");
        HeroStats.level = PlayerPrefs.GetInt("lvl");
        HeroStats.hero_armor = PlayerPrefs.GetInt("armor");
        HeroStats.hero_reduce_dps = PlayerPrefs.GetFloat("reduce");
        HeroStats.heal = PlayerPrefs.GetInt("heal");
    }

    public void resetStats()
    {
        PlayerPrefs.SetInt("hp", 100);
        PlayerPrefs.SetInt("exp", 0);
        PlayerPrefs.SetInt("dmg", 1);
        PlayerPrefs.SetInt("coins", 0);
        PlayerPrefs.SetInt("lvl", 0);
        PlayerPrefs.SetInt("armor", 0);
        PlayerPrefs.SetInt("heal", 0);
        PlayerPrefs.SetFloat("reduce", 0);
    }
}
