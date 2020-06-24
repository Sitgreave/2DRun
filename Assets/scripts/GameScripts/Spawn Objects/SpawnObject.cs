using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : HeroPosition
{


    public GameObject[] platforms;
    public GameObject coin;
   // GameObject[] coins;
    int i=0;
    int j = 0;
    public List<GameObject>  enemies;
  //  public GameObject[] hedgehogs;
    int countCoiuns, count_enemy;
    
        private void OnTriggerEnter2D(Collider2D collision)
       {
        if (collision.gameObject.CompareTag("endOfPlatform"))
        {  
            AllGenerate();
            deleteUselessObjects();
            Destroy(collision.gameObject);
        }
    }
    private void coinGenerate(int index_array_platforms)
    {
        countCoiuns = Random.Range(3, 8);
        for (int i = 0; i < countCoiuns; i++)
        {
            Instantiate(coin, platforms[index_array_platforms].transform);
            coin.transform.position = Vector3.up * Random.Range(-8f, 6f);
            coin.transform.position += Vector3.right * Random.Range(-7, 3);
        }
    }
    private void EnemyGenerate (int index_array_platforms, GameObject enemy, int min_enemy, int max_enemy)
    {

       count_enemy = Random.Range(min_enemy, max_enemy);
        for (int i = 0; i < count_enemy; i++)
        {
            Instantiate(enemy, platforms[index_array_platforms].transform);
            enemy.transform.position = Vector2.up * Random.Range(-5, 7);
            enemy.transform.position += Vector3.right * Random.Range(4+i*2, 10);
            enemy.transform.position +=Vector3.forward * Random.Range(0.001f,0.1f);
        }
    }
    private void deleteUselessObjects()
    {
        if (j < platforms.Length&&Vector2.Distance(platforms[j].transform.position, heroPosition.transform.position) > 25f)
        { Destroy(platforms[j]); j++; }
    }
    void AllGenerate()
    {
            if (i < platforms.Length)
            {           
               coinGenerate(i);
                EnemyGenerate(i, enemies[0], 1, 3);
                i++;
            }
    }
}
