using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] Transform target;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        if (!agent.pathPending && agent.remainingDistance <= 1.5f)
        {
            agent.destination = target.position;
            Debug.Log("CanShot");
        }
    }
}
