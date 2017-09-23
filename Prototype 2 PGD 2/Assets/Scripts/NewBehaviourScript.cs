using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float speed;

    private Rigidbody rb;
    float moveHorizontal = 0;

    void Start()
    {
        transform.position = new Vector3(0, 10, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveHorizontal++;
            if (moveHorizontal > 4)
            {
                moveHorizontal = 4;
            }
        }

        /* if (moveHorizontal < 5 || moveHorizontal > -5)
        {
            moveHorizontal = 0;
        } */

        if (Input.GetKeyDown(KeyCode.A))
        {
            moveHorizontal--;
            if (moveHorizontal < -4)
            {
                moveHorizontal = -4;
            }
        }

        transform.position = new Vector3(0.0f, 10f, (float)moveHorizontal);
    }
}
