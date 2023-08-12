using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            inputVector = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            inputVector = Vector2.down;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            inputVector = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            inputVector = Vector2.right;
        }

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
}
