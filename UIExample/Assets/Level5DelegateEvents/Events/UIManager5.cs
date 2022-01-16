using TMPro;
using UnityEngine;

public class UIManager5 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;


    private void OnEnable() // ����� ������ ����������� �� ������ ��� ������������ �� �����
    {
        MyEventManager.OnDropped += UpdateScore; //��������� ����� � �������
        MyEventManager.OnDropped += CheckWin;
    }

    private void OnDisable()//������������ ��� ��������������
    {
        MyEventManager.OnDropped -= UpdateScore;
        MyEventManager.OnDropped -= CheckWin;
    }

    public void UpdateScore(int score) //��������� ��� � ��������
    {
        scoreText.text = score.ToString();
    }

    public void CheckWin(int score) //��������� ��� � ��������
    {
        if(score == 20)
        {
            Time.timeScale = 0f;
        }
    }

}
