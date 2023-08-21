using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeStart;
    private float timeSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timeStart = Time.time;
            float timeDif = timeStart - timeSpawn;
            if (timeDif > 1.5f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeSpawn = Time.time;
            }
        }
    }
}
