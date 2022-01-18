using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timer;

    public float timeLimit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= Time.deltaTime;

        timer.text = "Timer : " + timeLimit;

        if (timeLimit <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }


}
