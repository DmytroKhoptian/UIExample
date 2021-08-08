//В примерах выше переменная делегата указывала на один метод. 
//    В реальности же делегат может указывать на множество методов, которые имеют ту же сигнатуру и возвращаемые тип. 
//    Все методы в делегате попадают в специальный список - список вызова или invocation list.
//    И при вызове делегата все методы из этого списка последовательно вызываются.
//    И мы можем добавлять в этот спиок не один, а несколько методов



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample2 : MonoBehaviour
{
    private delegate string ToMyString(float a, float b); // 1. Объявляем делегат 
    ToMyString toMyString; // 2. Создаем переменную делегата


    private void Awake()
    {
        toMyString += Sum; // 3. Присваиваем этой переменной адрес метода
        toMyString += Min; // 4 Добавление методов в делегат
        toMyString += Sum; // 6. Можно добавить дважды
        string stringRez = toMyString(2f, 5f);// 5 вызываются оба метода сразу
        Debug.Log(stringRez);

        //Подобным образом мы можем удалять методы из делегата с помощью операции -=
        toMyString -= Sum;
        //При удалении методов из делегата фактически будет создаватья новый делегат,
        //который в списке вызова методов будет содержать на один метод меньше.


        //7.Лучше через Invoke
        Debug.Log("Invoke");
        string stringRez111 = toMyString?.Invoke(2f, 5f);// 5 вызываются оба метода сразу
        Debug.Log(stringRez111);
    }



    private string Sum(float num1, float num2)
    {
        Debug.Log("Выполняется Sum");
        float rez = num1 + num2;
        return rez.ToString();
    }
    private string Min(float num1, float num2)
    {
        Debug.Log("Выполняется Min");
        float rez = num1 - num2;
        return rez.ToString();
    }
}
