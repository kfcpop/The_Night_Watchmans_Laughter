using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoveAI : MonoBehaviour
{
    private Transform graveStone;
    private NavMeshAgent agent;

    [SerializeField] private float graveDistance = 1.0f;

     
    // Start is called before the first frame update
    void Start()
    {
        graveStone = GameObject.FindWithTag("Grave").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //look at the grave stone
        transform.LookAt(graveStone);

        agent.SetDestination(graveStone.transform.position);

        if (Vector3.Distance(transform.position, graveStone.position) < graveDistance)
        {
            //add digging animation later
        }
    }
}
