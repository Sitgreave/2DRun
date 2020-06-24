using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowState : HeroStats
{
    [Header("Global Stats")]
    public Text coins_text;
    public Text level_text;
    public Text hp_text;
    public Text damage_text;
    public Text armor_text;
    [Header("Local Stats")]
    public Text gameLevelText;
    public Text gameCoinsText;
    public Text gameHpText;
    public Text gameTotalExpirienceText;
    private void showStateInGame()
    {
        gameCoinsText.text = "Coins: " + local_coins;
        gameHpText.text = "HP: " + local_hero_hitpoints;
        gameTotalExpirienceText.text = "Total exp: " + experience;
        gameLevelText.text = "HeroLvl: " + level;
    }
    private void showStateInMenu()
    {
        level_text.text = "level: " + level;
        coins_text.text = "coins: " + coins;
        damage_text.text = "damage: " + hero_damage;
        hp_text.text = "hp: " + hero_hitpoints;
        armor_text.text = "armor: " + hero_armor;
    }
    private void Update()
    {
        if (SceneManager.sceneCount != 0) showStateInGame();
        else showStateInMenu();
    }
}
