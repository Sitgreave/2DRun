using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : playerAnimations
{
    public void Attack(){
        animator.Play("attack");
        }
    
}
