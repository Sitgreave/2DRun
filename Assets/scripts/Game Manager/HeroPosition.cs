using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPosition : MonoBehaviour
{
    public Transform heroPosition;
    private void Awake()
    {
        heroPosition= GetComponent<Transform>();
    }
}
