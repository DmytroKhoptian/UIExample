using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorMulticastDelegate : MonoBehaviour
{
    delegate void MyDelegate(Color32 mycolor);
    MyDelegate myMultiDelegate;

    [SerializeField] GameObject ground;
    [SerializeField] GameObject player;

    void Start()
    {
        myMultiDelegate += SetPlayerColor; //добавить в стек
        myMultiDelegate += SetGroundColor;

        myMultiDelegate -= SetPlayerColor; //убрать из стека
        myMultiDelegate -= SetGroundColor;

        if (myMultiDelegate != null)
        {
            myMultiDelegate(Color.green);
        }
    }


    void SetPlayerColor(Color32 color)
    {
        ground.GetComponent<SpriteRenderer>().color = color;
    }

    void SetGroundColor(Color32 color)
    {
        player.GetComponent<SpriteRenderer>().color = color;
    }
}
