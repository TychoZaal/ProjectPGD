using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{

    public float speed;

    float moveHorizontal = 0;
    float moveVertical = -20;

    void Start()
    {
        transform.position = new Vector3(-20, 0f, 0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveHorizontal++;
        }

          if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveHorizontal--;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveVertical--;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveVertical++;
        }

        transform.position = new Vector3(moveVertical, 0f, moveHorizontal);
    }
}
