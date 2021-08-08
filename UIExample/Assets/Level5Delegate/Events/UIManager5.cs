using TMPro;
using UnityEngine;

public class UIManager5 : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;


    private void OnEnable() // когда скрипт добавляется на обьект или активируется на сцене
    {
        MyEventManager.OnDropped += UpdateScore; //описываем метод к событию
    }

    private void OnDisable()//уничтожается или диактивируется
    {
        MyEventManager.OnDropped -= UpdateScore;
    }

    public void UpdateScore() //симантика как у делегата
    {
        score++;
        scoreText.text = score.ToString();
    }
}
