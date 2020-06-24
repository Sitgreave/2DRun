using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public GameObject shopPan;
    public void show_ShopPan()
    {
        shopPan.SetActive(!shopPan.activeSelf);
    }
}
