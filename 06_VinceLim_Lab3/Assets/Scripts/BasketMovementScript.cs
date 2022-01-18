using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;


    public GameObject basket;

    int Score;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        if (Score >= 10)
        {
            SceneManager.LoadScene("WinScene");
        }


    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Healthy")
        {
            Score += 10;

            scoreText.text = "Score : " + Score;

            Destroy(collision.gameObject);
        }
    }





}
