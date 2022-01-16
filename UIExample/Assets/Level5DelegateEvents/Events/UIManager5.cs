using TMPro;
using UnityEngine;

public class UIManager5 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;


    private void OnEnable() // когда скрипт добавляется на обьект или активируется на сцене
    {
        MyEventManager.OnDropped += UpdateScore; //описываем метод к событию
        MyEventManager.OnDropped += CheckWin;
    }

    private void OnDisable()//уничтожается или диактивируется
    {
        MyEventManager.OnDropped -= UpdateScore;
        MyEventManager.OnDropped -= CheckWin;
    }

    public void UpdateScore(int score) //симантика как у делегата
    {
        scoreText.text = score.ToString();
    }

    public void CheckWin(int score) //симантика как у делегата
    {
        if(score == 20)
        {
            Time.timeScale = 0f;
        }
    }

}
