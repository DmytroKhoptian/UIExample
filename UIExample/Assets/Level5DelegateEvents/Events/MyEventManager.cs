//События сигнализируют системе о том, что произошло определенное действие.
//И если нам надо отследить эти действия, то как раз мы можем применять события. Подвид делегата. Сообщает другим классам что что-то случилось


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEventManager : MonoBehaviour
{

    public delegate void DropedAction(int score);
    public static event DropedAction OnDropped;

    [SerializeField] private int score;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        score++;
        OnDropped?.Invoke(score);

        //if (OnDropped != null)
        //    OnDropped();
    }
}
