using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourWithDelegate : MonoBehaviour
{
    delegate void MyDelegate(Color32 mycolor);
    MyDelegate myDelegate;

    [SerializeField] GameObject ground;
    [SerializeField] GameObject player;

    void Start()
    {
        myDelegate = SetPlayerColor;
        myDelegate(Color.black);

        myDelegate = SetGroundColor;
        myDelegate(Color.red);
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


//ƒелегат Ч это указатель на метод. Ёто позвол€ет нам рассматривать метод как переменную и передавать метод как переменную дл€ обратного вызова.
//     огда он вызываетс€, он уведомл€ет все методы, которые ссылаютс€ на делегат. ќсновна€ иде€, сто€ща€ за ними, точно така€ же, как у журнала по подписке. 
//    Ћюбой может подписатьс€ на услугу, и они будут автоматически получать обновлени€ в нужное врем€. 