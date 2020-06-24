
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Enemy : MonoBehaviour
{

    //stats
    [Header("Enemy stats")]
    public int damage;
    public int hp;
    public int reward;
    public int healAfterDeath;
    public int exp;
    [Space]
    
    //states
    public bool live;
    //
    //public List<int> damageList = new List<int> { 5, 10, 3 };
    //public List<int> hpList = new List<int> { 2, 3, 5 };
    //public List<int> rewardList = new List<int> { 10, 10, 30 };
    //public List<int> healList = new List<int> { 5, 10, 30 };
    //public List<int> expList = new List<int> { 10, 15, 40 };

    //public int EnemyTypes;
 
    private Transform transformEnemy;

    private Animator animator;
    //private void dealDamage()
    //{
    //    GameManager.local_hero_hitpoints -= damage*2;
    //    hp -= GameManager.local_hero_damage/2;
    //    animator.Play("hurt");
    //}
    //private void EnemyDeath()
    //{
    //    GameManager.local_hero_hitpoints += healAfterDeath;
    //    GameManager.experience += exp;
    //    GameManager.local_coins += reward;
    //    live = false;
    //    animator.Play("die");
    //}
    //private void autoAttack()
    //{
      
    //        //if (GameManager.heroPosition.position.x > transformEnemy.position.x - 0.3f && (GameManager.heroPosition.transform.position.x - transformEnemy.position.x) < 0)
    //        //{
    //        //    animator.Play("attack");
    //        //    Debug.Log(GameManager.heroPosition.position.x);
    //        //}
        
    //}
    private void Awake()
    {
        animator=GetComponent<Animator>();
        transformEnemy = GetComponent<Transform>();
    }
    private void Update()
    {
        //if(live == true) autoAttack();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("weapon"))
        {
          //  dealDamage();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(hp <= 0)
        {
           // EnemyDeath();
        }
    }

   
}