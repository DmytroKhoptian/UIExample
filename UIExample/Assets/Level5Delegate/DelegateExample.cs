
// Делегаты представляют такие объекты, которые указывают на методы.То есть делегаты - это указатели на методы и с помощью делегатов мы можем вызвать данные методы.
//Для объявления делегата используется ключевое слово delegate, после которого идет возвращаемый тип, название и параметры
//Условия создания делегата
//1 обьявление - Тип делегата это сигнатура метода(Входные параметры и выходные должны совпадать по типам)
//2 Должен быть хотя бы один метод соответсвующий по семантике
//3 Должен біть создан экземпляр делегата


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{

    delegate void Message();// 1. Объявляем делегат //Делегат Message в качестве возвращаемого типа имеет тип void (то есть ничего не возвращает) и не принимает никаких параметров. 

    Message myMessage1; // 2. Создаем переменную делегата
    Message myMessage2;

    private void Awake()
    {
        myMessage1 = PrintGoodMorning; // 3. Присваиваем этой переменной адрес метода
        myMessage2 = PrintGoodEvening;
    }

    private void Start()
    {
        myMessage1();// 4. Вызываем метод -  myMessage2.Invoke();
        myMessage2?.Invoke(); // если не null
    }

    void PrintGoodMorning()
    {
        Debug.Log("Доброе утро");
    }
    void PrintGoodEvening()
    {
        Debug.Log("Добрый вечер");
    }

}
