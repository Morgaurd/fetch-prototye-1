using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject[] dogPrefab;
    private float count = 0.0f;
    public float maxSpawn = 0.5f;

    // Update is called once per frame
    private void Start()
    {
        count = maxSpawn;
    }
    void Update()
    {
        // On spacebar press, send dog
        count += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && count >= maxSpawn )
        {
            Instantiate(dogPrefab[0], transform.position, dogPrefab[0].transform.rotation);
            count = 0;
        }


    }
}
