public class HeroDeath : SaveState
{
    private void Start()
    {
        HeroStats.local_hero_hitpoints = 100;
    }
    void Update()
    {
        if (HeroStats.local_hero_hitpoints <= 0)
        {
            heroDie();
        }
    }

    private void heroDie()
    {
        if (HeroStats.live == true)
        {
            HeroStats.local_hero_hitpoints = 0;
            //Destroy(hero);
            //  diePanel.SetActive(true);
            HeroStats.coins += HeroStats.local_coins;
            savePPrefs();
            //Time.timeScale = 0;
            HeroStats.live = false;
        }

    }
}
