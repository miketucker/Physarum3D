using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAutoDolly : MonoBehaviour
{

    public float speed = 1f;
    public float amp = 10f;

    public Transform targetPos;

    Vector3 startPos; 

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPos + new Vector3(Mathf.Cos(Time.time * speed) * amp, 0f, 0f );

        transform.LookAt(targetPos);
    }
}
