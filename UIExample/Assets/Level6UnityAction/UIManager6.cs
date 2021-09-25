using TMPro;
using UnityEngine;

public class UIManager6 : MonoBehaviour
{
    private int gscore;
    [SerializeField] private TextMeshProUGUI gscoreText;
    private int rscore;
    [SerializeField] private TextMeshProUGUI rscoreText;

    private void OnEnable()
    {
        HexagonCollision.OnPlayerTookDamage += UpdateScore;
    }

    private void OnDisable()
    {
        HexagonCollision.OnPlayerTookDamage -= UpdateScore;
    }


    public void UpdateScore(int amount, Colors color)
    {
        if(color== Colors.Green)
        {
            gscore += amount;
            gscoreText.text = gscore.ToString();
        }
        else if (color == Colors.Red)
        {
            rscore += amount;
            rscoreText.text = rscore.ToString();
        }
    }
    
}
