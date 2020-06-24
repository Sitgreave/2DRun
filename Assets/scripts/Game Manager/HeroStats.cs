using System.Collections.Generic;
using UnityEditor.U2D.Sprites;
using UnityEngine;
using UnityEngine.UI;

public class HeroStats : MonoBehaviour
{
    //global variable
    public static bool live;
    public static int coins;
    public static float speed_multiply;
    public static int hero_hitpoints = 100;
    public static int hero_hitpoints_Decrease;
    public static int hero_armor;
    public static int hero_damage, local_hero_damage;
    public static int experience; //summary exp
    public static int level;
    public static int heal;
    public static float hero_reduce_dps = 0;
    // private Vector3 hero_growth;
   

    //hp and exp in the game;
   public static int local_hero_hitpoints,  local_coins;
    
   
}

