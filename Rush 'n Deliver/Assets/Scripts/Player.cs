using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.5f;
    [SerializeField] float rotationSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -rotationAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
