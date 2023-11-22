using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaCam : MonoBehaviour
{
    public GameObject jogador;

    public Vector3 CameraPos; 

    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.Find("Player");
        CameraPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CameraPos.z = jogador.transform.position.z - 16;
        transform.position = CameraPos;
    }
}
