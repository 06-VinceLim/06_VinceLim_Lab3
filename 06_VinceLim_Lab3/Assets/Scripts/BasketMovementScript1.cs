using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketMovementScript1 : MonoBehaviour
{
    public float speed;


    public GameObject basket;

    int Score;

    public Text scoreText;

    public AudioSource FruitSource;

    public AudioClip Fruitclip;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        if (Score >= 100)
        {
            SceneManager.LoadScene("WinScene");
        }


    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Healthy")
        {
            FruitSource.PlayOneShot(Fruitclip);

            Score += 10;

            scoreText.text = "Score : " + Score;

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Unhealthy")
        {
            SceneManager.LoadScene("LoseScene");
        }
    }





}
