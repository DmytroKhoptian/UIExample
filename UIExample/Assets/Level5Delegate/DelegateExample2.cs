//� �������� ���� ���������� �������� ��������� �� ���� �����. 
//    � ���������� �� ������� ����� ��������� �� ��������� �������, ������� ����� �� �� ��������� � ������������ ���. 
//    ��� ������ � �������� �������� � ����������� ������ - ������ ������ ��� invocation list.
//    � ��� ������ �������� ��� ������ �� ����� ������ ��������������� ����������.
//    � �� ����� ��������� � ���� ����� �� ����, � ��������� �������



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample2 : MonoBehaviour
{
    private delegate string ToMyString(float a, float b); // 1. ��������� ������� 
    ToMyString toMyString; // 2. ������� ���������� ��������


    private void Awake()
    {
        toMyString += Sum; // 3. ����������� ���� ���������� ����� ������
        toMyString += Min; // 4 ���������� ������� � �������
        toMyString += Sum; // 6. ����� �������� ������
        string stringRez = toMyString(2f, 5f);// 5 ���������� ��� ������ �����
        Debug.Log(stringRez);

        //�������� ������� �� ����� ������� ������ �� �������� � ������� �������� -=
        toMyString -= Sum;
        //��� �������� ������� �� �������� ���������� ����� ���������� ����� �������,
        //������� � ������ ������ ������� ����� ��������� �� ���� ����� ������.


        //7.����� ����� Invoke
        Debug.Log("Invoke");
        string stringRez111 = toMyString?.Invoke(2f, 5f);// 5 ���������� ��� ������ �����
        Debug.Log(stringRez111);
    }



    private string Sum(float num1, float num2)
    {
        Debug.Log("����������� Sum");
        float rez = num1 + num2;
        return rez.ToString();
    }
    private string Min(float num1, float num2)
    {
        Debug.Log("����������� Min");
        float rez = num1 - num2;
        return rez.ToString();
    }
}
