using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject platformTarget;
    public float speed = 5.0f;

    void Start()
    {
        
    }


    void Awake()
    {
        platformTarget = GameObject.FindWithTag("Island Target");
    }

    void Update()
    {
        Vector3 goal = new Vector3(gameObject.transform.position.x, platformTarget.transform.position.y, gameObject.transform.position.z);
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, goal, 0.5f * Time.deltaTime * speed);
    }
}
