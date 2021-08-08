//������� ������������� ������� � ���, ��� ��������� ������������ ��������.
//� ���� ��� ���� ��������� ��� ��������, �� ��� ��� �� ����� ��������� �������. ������ ��������. �������� ������ ������� ��� ���-�� ���������


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEventManager : MonoBehaviour
{

    public delegate void DropedAction();
    public static event DropedAction OnDropped;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnDropped?.Invoke();

        //if (OnDropped != null)
        //    OnDropped();
    }
}
