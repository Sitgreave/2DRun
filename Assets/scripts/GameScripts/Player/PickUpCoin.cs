using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(Collider2D))]
public class PickUpCoin : HeroStats
{ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            Destroy(collision.gameObject);
            local_coins++;
        }
    }
}