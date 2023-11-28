using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class inimigo1 : MonoBehaviour
{
    // Start is called before the first frame update


    public Vector3 scoutPosition;
    float maxScoutX  = 10;
    float maxScoutZ = 10;
    NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetNewScoutPos();
    }

    void SetNewScoutPos()
    {
        Vector3 position = new Vector3(Random.Range(-(maxScoutX), maxScoutX), 0, Random.Range(-(maxScoutZ), maxScoutZ));
        scoutPosition = position;
    }

    void Update()
    {
        if (agent.isOnNavMesh) {
            Debug.Log("TA NA MALHA");
        agent.destination = scoutPosition;

        if (transform.position.x == scoutPosition.x || transform.position.z == scoutPosition.z)
        {
            SetNewScoutPos();
        }
        }
    }
}
