using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class player :  NetworkBehaviour
{
    public float speed = 5f;
    private Vector3 direction;
    public Camera PlayerCamera;
    // Start is called before the first frame update
    void Start()
    {
         if (!isLocalPlayer) {
            PlayerCamera.enabled = false;
        }
    }

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
    }
    // Update is called once per frame
    void Update()
    {
       
        if (!isLocalPlayer)
            return;
        
        if (Input.GetKey("up")) {
            direction = speed * Vector3.up;
            transform.position += direction* Time.deltaTime;
            Debug.Log("up move");
        }
        if (Input.GetKey("down")) {
            direction = speed * Vector3.down;
            transform.position += direction* Time.deltaTime;
            Debug.Log("down move");
        }
        if (Input.GetKey("right")) {
            direction = speed * Vector3.right;
            transform.position += direction* Time.deltaTime;
            Debug.Log("right move");
        }
        if (Input.GetKey("left")) {
            direction = speed * Vector3.left;
            transform.position += direction* Time.deltaTime;
            Debug.Log("left move");
        }
    }
}
