using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public bool isGameOver;

    public GameObject[] stars;

    public int collectedStars;

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        isGameOver = false;
        collectedStars = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(collectedStars == stars.Length)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        isGameOver = true;
        panel.SetActive(true);
    }
}
