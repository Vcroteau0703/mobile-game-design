using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerBoundary
{
    public float xMin, xMax;
}

public class MoveByTouch : MonoBehaviour
{

    public PlayerBoundary boundary;
    public float screenWidth = Screen.width;
    public float moveSpeed;
    public float upSpeed;
    private Touch touch;
    private Vector2 touchPosition;
    private Rigidbody2D rb;
    public bool gameActive = true;
    //public Vector2 destination;

    private void Awake()
    {
        //destination = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameActive)
        {
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
                if (touch.position.x > (screenWidth / 2))
                {
                    //right
                    moveSpeed = 5;
                    //transform.Translate(moveSpeed, upSpeed, 0);
                }
                else
                {
                    //left
                    moveSpeed = -5;
                    //transform.Translate(-moveSpeed, upSpeed, 0);
                }
            }
            else
            {
                moveSpeed = 0;
                //transform.Translate(0, upSpeed, 0);
            }

            rb.velocity = new Vector3(moveSpeed, upSpeed, 0);

            rb.position = new Vector3
                (
                 Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
                 this.transform.position.y,
                 this.transform.position.z
                );
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }


    }

}
