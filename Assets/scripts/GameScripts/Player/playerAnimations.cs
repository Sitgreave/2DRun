using UnityEngine;


public class playerAnimations : HeroStats
{
    public Animator animator;
    public GameObject sword;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap") && sword.active == false)
        {
         //   animator.SetBool("hurt", true);
            animator.Play("hurt");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap") )
        {
           // animator.SetBool("hurt", false);
        }
    }

    private void Update()
    {
        if (live == false)
        {
            animator.Play("die");
        }

    }

}
