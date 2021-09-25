
using UnityEngine;
using UnityEngine.Events;

public enum Colors { Red, Green }
public class HexagonCollision : MonoBehaviour
{
    

    [SerializeField] private Colors colors;

    public static UnityAction<int, Colors> OnPlayerTookDamage;

  
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        HexagonCollision hexagon = collision.transform.GetComponent<HexagonCollision>();


        if (hexagon != null)
        {
            if (colors != hexagon.colors && colors == Colors.Green) //разные цвета
            {
                OnPlayerTookDamage?.Invoke(0, colors);
            }
            if (colors == hexagon.colors && colors == Colors.Red) //2 кр
            {
                OnPlayerTookDamage?.Invoke(10, colors);
            }
            if (colors == hexagon.colors && colors == Colors.Green) //2 зел
            {
                OnPlayerTookDamage?.Invoke(10, colors);
            }
        }
    }
}
