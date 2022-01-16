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


//������� � ��� ��������� �� �����. ��� ��������� ��� ������������� ����� ��� ���������� � ���������� ����� ��� ���������� ��� ��������� ������.
//    ����� �� ����������, �� ���������� ��� ������, ������� ��������� �� �������. �������� ����, ������� �� ����, ����� ����� ��, ��� � ������� �� ��������. 
//    ����� ����� ����������� �� ������, � ��� ����� ������������� �������� ���������� � ������ �����. 