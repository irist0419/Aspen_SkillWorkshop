using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    [SerializeField] private float distance;
    
    private Vector3 startpos;
    private Vector3 endpos;
    
    // Start is called before the first frame update

    private void Start()
    {

        startpos=transform.position;

        endpos = startpos + new Vector3(distance, 0, 0);

    }

    // Update is called once per frame

    private void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);
        
        transform.position = Vector3.Lerp(startpos, endpos, movement / distance);
    }
}
