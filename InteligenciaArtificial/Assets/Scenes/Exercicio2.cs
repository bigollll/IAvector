using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    public float speed;
    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = transform.position;
        Vector3 b = transform.position;
        transform.position = Vector3.MoveTowards(a, b, speed);
    }
}
