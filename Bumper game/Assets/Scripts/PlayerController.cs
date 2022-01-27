using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public float speed = 5.0f;
  //  private GameObject focalPoint;
    public bool gameover = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
      
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRB.AddForce(Vector3.forward * speed * forwardInput);
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRB.AddForce(Vector3.forward * speed * horizontalInput);

    }
}
