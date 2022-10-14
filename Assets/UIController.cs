using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private GameObject gameoverText;
    private GameObject runLengthText;

    private float len = 0;
    private float speed = 5f;
    private bool isGameover = false;


    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");

    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameover)
        {
            this.len += this.speed * Time.deltaTime;
            this.runLengthText.GetComponent<Text>().text = "Distance:" + len.ToString("F2") + "m";
        }

        if (isGameover)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Samplescene");
            }
        }
    }

    public void GameOver()
    {
        this.gameoverText.GetComponent<Text>().text = "GAME OVER";
        this.isGameover = true;
    }
}
