using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class jogador : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform armaSecundaria;
    public Transform armaPrimaria;
    public GameObject tiro;
    public GameObject tiroSecundario;
    public float vel_tiro;
    public float velocidade, x, z;
    public int frente;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.anyKey){ 
         x = UnityEngine.Input.GetAxis("Horizontal");
         z = UnityEngine.Input.GetAxis("Vertical");

        Vector3 direcionamento = new Vector3(x,0,z);
        //direcionamento.Normalize();

        if (direcionamento != Vector3.zero) transform.forward = direcionamento;
        transform.Translate(direcionamento * velocidade * Time.deltaTime, Space.World);
        }

        //Arma primaria
        if (UnityEngine.Input.GetKeyUp(KeyCode.J))
        {
            var _projectile = Instantiate(tiro, armaPrimaria.position, armaPrimaria.rotation);
            _projectile.GetComponent<Rigidbody>().velocity = vel_tiro * armaPrimaria.up;
        }

        //Arma secundaria
        if (UnityEngine.Input.GetKeyUp(KeyCode.K))
        {
            var _projectile2 = Instantiate(tiroSecundario, armaSecundaria.position, armaSecundaria.rotation);
            _projectile2.GetComponent<Rigidbody>().velocity = vel_tiro * armaSecundaria.up;
        }

    }

    void anim()
    {
       /* switch (y, x)
        {
            case 1:
        }*/
    }
}
