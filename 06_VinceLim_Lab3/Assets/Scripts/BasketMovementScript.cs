using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;

    float minusXLimit = -9.0f;
    float plusXLimit = 9.0f;

    public GameObject basket;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        //To Check basket limit of X to ensure it stay on screen.
        if (basket.transform.position.x > -10.0f || basket.transform.position.x < 10.0f)
        {
            transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
        }
        else
        {
            speed = 0.0f;
        }
/*        if (basket.transform.position.x < -10.0f & Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed = 5.0f;
        }
        if (basket.transform.position.x < 10.0f & Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed = 5.0f;
        }*/


       // transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        
       

    }



    

}
