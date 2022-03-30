using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 1f;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        // get the user's vertical input
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(new Vector3(1, 0, 0) * -verticalInput * rotationSpeed * Time.deltaTime);
    }
}
