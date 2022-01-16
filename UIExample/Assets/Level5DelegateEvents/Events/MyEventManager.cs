//������� ������������� ������� � ���, ��� ��������� ������������ ��������.
//� ���� ��� ���� ��������� ��� ��������, �� ��� ��� �� ����� ��������� �������. ������ ��������. �������� ������ ������� ��� ���-�� ���������


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
