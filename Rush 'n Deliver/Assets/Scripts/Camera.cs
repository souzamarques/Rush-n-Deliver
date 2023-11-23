using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject Player;
    
    void LateUpdate()
    {
    	transform.position = Player.transform.position + new Vector3(0, 0, -0.3f);
    }
}

