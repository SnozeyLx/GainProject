using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    public float angleBetween = 0.0f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    void Update()
    {
        Vector3 targetDir = target.position - transform.position;
        angleBetween = Vector3.Angle(transform.forward, targetDir);
    }
}
