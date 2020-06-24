using System.Collections;
using UnityEngine;

public class dpsToHero : HeroStats
{
    float time;
    
    IEnumerator damageInSeconds()
    {
            while (live == true)
            {
                local_hero_hitpoints -= 1;
                yield return new WaitForSeconds(1+hero_reduce_dps);
            }
    }

    private void Start()
    {
       StartCoroutine(damageInSeconds());
       
    }
}
