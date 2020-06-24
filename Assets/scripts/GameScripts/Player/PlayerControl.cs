using UnityEngine;

public class PlayerControl : HeroPosition
{
    public Transform targetBox;
    public float base_speed;
    private bool _goToBox = false;
    Rigidbody2D m_Rigidbody;
    float speedOfTurn;
    float speed;

    private void Start()
    {
        speed = 1;
        m_Rigidbody = GetComponent<Rigidbody2D>();
        speedOfTurn = 4f;
        
    }
   
    void FixedUpdate()
    {
        moveToObject();
    }
     public void onClickStart()
    {
        leftTurn(speedOfTurn);
    }
    public void onClickEnd()
    {
        rightTurn(speedOfTurn);
    }




    private void leftTurn(float speedOfTurn)
    {
        if (HeroStats.live == true)
        {
            m_Rigidbody.velocity = transform.up * speedOfTurn;
            m_Rigidbody.gravityScale = -1;
        }
    }
    private void rightTurn(float speedOfTurn)
    {
        if (HeroStats.live == true)
        {
            m_Rigidbody.gravityScale = 0.6f;
            m_Rigidbody.velocity = transform.up * (-speedOfTurn);
        }
    }
    private void moveToObject()
    {
        if (HeroStats.live == true)
        {
            if (_goToBox == false)
            {
                if ((targetBox.position - transform.position).sqrMagnitude < 0.01f) _goToBox = true;

                transform.position += (targetBox.position - transform.position).normalized * (speed * HeroStats.speed_multiply) * Time.fixedDeltaTime;
            }
        }
        else m_Rigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

}
