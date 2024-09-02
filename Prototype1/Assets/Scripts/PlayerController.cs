using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float horsePower = 0;
    [SerializeField] private float turnSpeed = 25f;
    [SerializeField] private float rpm;
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] TextMeshProUGUI speedoMeterText;
    [SerializeField] TextMeshProUGUI rpmText;

    private Rigidbody playerRb;

    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //This is player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        // Move the vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //playerRb.AddForce(Vector3.forward * horsePower * forwardInput);
        playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
        // Rotate the vehicle 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

		speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 3.6f);
        speedoMeterText.SetText("Speed : " + speed + "Kmh");

        rpm = (speed % 30) * 40;
        rpmText.SetText("RPM : " + rpm);

        
    }
}
