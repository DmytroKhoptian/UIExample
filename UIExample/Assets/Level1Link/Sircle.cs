using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sircle : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayer;

    private UIManager uIManager;
    private bool isTouch;

    public void SetUIManager(UIManager uIManager)
    {
        this.uIManager = uIManager;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            if (!isTouch)
            {
                uIManager.UpdateScore();
                isTouch = true;
            }
        }
    }
}
