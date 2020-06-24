using UnityEngine;


public class CameraFollow : HeroStats
{
    public GameObject target;
    private Transform targetTransform;
    Vector3 temp;
    public GameObject startPos;
    private void Start()
    {
        target.transform.position = startPos.transform.position;
        targetTransform = target.transform;
    }
    void LateUpdate()
    {
         followToPlayer();
       
    }
    private void followToPlayer()
    {
        if (live == true)
        {
            transform.position = new Vector3(targetTransform.position.x + 4f, transform.position.y, transform.position.z);
        }
    }
}

