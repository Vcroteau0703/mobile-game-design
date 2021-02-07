using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveByTouch : MonoBehaviour
{
    float screenWidth = Screen.width;
    public float moveSpeed;
    private Touch touch;
    private Vector2 touchPosition;
    //public Vector2 destination;

    private void Awake()
    {
        //destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.position.x > (screenWidth / 2))
            {
                //right
                //destination += Vector2.right * moveSpeed;
                //transform.position = Vector2.Lerp(transform.position, destination, 0.5f * Time.deltaTime);
                transform.Translate(moveSpeed, moveSpeed, 0);
            }
            else
            {
                //left
                transform.Translate(-moveSpeed, moveSpeed, 0);
            }
        }
        else
        {
            transform.Translate(0, moveSpeed, 0);
        }

        
        //if (Input.touchCount > 0)
        //{


        //    if (theTouch.phase == TouchPhase.Began)
        //    {
        //        touchPosition = theTouch.position;
        //        float x = touchPosition.x;
        //        if (Mathf.Abs(x) < 0)
        //        {
        //            //left
        //            transform.Translate(-moveSpeed, 0, 0);
        //        }
        //        else if (Mathf.Abs(x) > 0)
        //        {
        //            //right
        //            transform.Translate(moveSpeed, 0, 0);
        //        }
        //    }
        //}
    }

    //private void FixedUpdate()
    //{
    //    TouchMove();
    //}

    //void TouchMove()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    //        if(mousePos.x > 1)
    //        {
    //            //move right
    //            transform.Translate(moveSpeed, 0, 0);
    //        }
    //        if(mousePos.x < -1)
    //        {
    //            //move left
    //            transform.Translate(-moveSpeed, 0, 0);
    //        }

    //    }


    //}
}
