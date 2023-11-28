using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float originalSpeed;
    private float boostSpeed = 3.5f;
    private float timeBoost = 0f;
    private float boostDuration = 5f;
    private bool isBoosted = false;

    [SerializeField] float moveSpeed = 1.5f;
    [SerializeField] float rotationSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        originalSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -rotationAmount);
        transform.Translate(0, moveAmount, 0);

        if(isBoosted)
        {
            timeBoost += Time.deltaTime;

            if(timeBoost >= boostDuration)
            {
                isBoosted = false;
                moveSpeed = originalSpeed;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            isBoosted = true;
            timeBoost = 0f;
        }    
    }
}
