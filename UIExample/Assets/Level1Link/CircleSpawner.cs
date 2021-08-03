using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject circle;
    [SerializeField] private UIManager uIManager;


    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject go = Instantiate(circle);
            go.GetComponent<Sircle>().SetUIManager(uIManager);
            yield return new WaitForSeconds(1f);
        }
    }
}
