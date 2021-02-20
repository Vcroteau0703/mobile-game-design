using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickups : MonoBehaviour
{
    public Transform player;

    List<float> lanes;
    List<GameObject> pickUps;

    const float leftLane = -1.5f, middleLane = 0f, rightLane = 1.5f;
    public float spawnWait;
    public GameObject waterPickup;
    public GameObject sunPickup;
    public GameObject insect;
    public int spawnCount;
    public bool gameActive = true;
    public Vector2 spawnPos;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(StartSpawning());
        lanes = new List<float>();
        pickUps = new List<GameObject>();

        lanes.Add(leftLane);
        lanes.Add(middleLane);
        lanes.Add(rightLane);

        pickUps.Add(waterPickup);
        pickUps.Add(sunPickup);
        pickUps.Add(insect);
    }

    private void LateUpdate()
    {
        spawnPos.y = player.position.y + 9f;
    }

    public IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(2f);
        while (gameActive)
        {
            for(int i = 0; i < spawnCount; i++)
            {
                //picks a random index from the pickups list
                int randomPickup = Random.Range(0, pickUps.Count);
                GameObject spawnPickup = pickUps[randomPickup];

                // picks a random index in the lanes list
                int randomLane = Random.Range(0, lanes.Count);
                float spawnLane = lanes[randomLane];
                Vector2 spawnPosition = new Vector2(spawnLane, spawnPos.y);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(spawnPickup, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
        }
    }



}
