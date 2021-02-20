using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPickup : MonoBehaviour
{
    private PickUp pickUp;
    public float timer = 10f;

    private void Awake()
    {
        if (gameObject.tag == "swarm")
        {
            pickUp = GetComponentInParent<PickUp>();
        }
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0.0f)
        {
            if (gameObject.tag == "swarm")
            {
                pickUp.insectCount--;
                Destroy(gameObject);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
