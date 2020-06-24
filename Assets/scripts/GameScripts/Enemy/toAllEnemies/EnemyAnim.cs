
using System.Net.NetworkInformation;
using UnityEngine;

public class EnemyAnim : MonoBehaviour
{
    public Animator animator;
    public bool live = true;

   public Transform transformEnemy;
   

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("weapon"))
        {
            //   animator.SetBool("hurt", true);
            animator.Play("hurt");
        }
    }
   
}
