using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BalaScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        Destroy(this.gameObject, 1.3f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider) //collision. 
        {
            Destroy(this.gameObject);
        }
    }

}
