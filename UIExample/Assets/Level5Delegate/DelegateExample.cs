
// �������� ������������ ����� �������, ������� ��������� �� ������.�� ���� �������� - ��� ��������� �� ������ � � ������� ��������� �� ����� ������� ������ ������.
//��� ���������� �������� ������������ �������� ����� delegate, ����� �������� ���� ������������ ���, �������� � ���������
//������� �������� ��������
//1 ���������� - ��� �������� ��� ��������� ������(������� ��������� � �������� ������ ��������� �� �����)
//2 ������ ���� ���� �� ���� ����� �������������� �� ���������
//3 ������ ��� ������ ��������� ��������


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{

    delegate void Message();// 1. ��������� ������� //������� Message � �������� ������������� ���� ����� ��� void (�� ���� ������ �� ����������) � �� ��������� ������� ����������. 

    Message myMessage1; // 2. ������� ���������� ��������
    Message myMessage2;

    private void Awake()
    {
        myMessage1 = PrintGoodMorning; // 3. ����������� ���� ���������� ����� ������
        myMessage2 = PrintGoodEvening;
    }

    private void Start()
    {
        myMessage1();// 4. �������� ����� -  myMessage2.Invoke();
        myMessage2?.Invoke(); // ���� �� null
    }

    void PrintGoodMorning()
    {
        Debug.Log("������ ����");
    }
    void PrintGoodEvening()
    {
        Debug.Log("������ �����");
    }

}
