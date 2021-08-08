using TMPro;
using UnityEngine;

public class UIManager5 : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;


    private void OnEnable() // ����� ������ ����������� �� ������ ��� ������������ �� �����
    {
        MyEventManager.OnDropped += UpdateScore; //��������� ����� � �������
    }

    private void OnDisable()//������������ ��� ��������������
    {
        MyEventManager.OnDropped -= UpdateScore;
    }

    public void UpdateScore() //��������� ��� � ��������
    {
        score++;
        scoreText.text = score.ToString();
    }
}
