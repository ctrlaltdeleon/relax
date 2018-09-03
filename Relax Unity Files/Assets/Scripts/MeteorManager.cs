using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Andrew De Leon
 * */

public class MeteorManager : MonoBehaviour {

    public int range = 50;

	void Start ()
    {
        InvokeRepeating("createMeteors", 0.0f, 4.0f);
    }

    // Creates meteors high on the y-axis, far from the character (z-axis), at random x-axis spots still visible
    void createMeteors()
    {
        int randomNumber = Random.Range(-60, 120);

        for (int y = 50; y < 55; y++)
        {
            for (int x = randomNumber; x < randomNumber + 5; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.AddComponent<Rigidbody>();
                cube.transform.position = new Vector3(x, y, range);
                // Destroy cubes after 10 seconds to avoid memory overlord
                Destroy(cube, 10);
            }
        }
    }
}
