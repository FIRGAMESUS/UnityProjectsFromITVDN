using UnityEngine;
using System.Collections;

public class NavMeshMoveHelper : MonoBehaviour
{

    public Transform EndPoint;

    UnityEngine.AI.NavMeshAgent _navMeshAgent;
    // Use this for initialization
    void Start()
    {
        _navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        // if (_navMeshAgent.isOnOffMeshLink)
        GetComponent<Animator>().SetBool("OffMeshLink", _navMeshAgent.isOnOffMeshLink);
        _navMeshAgent.SetDestination(EndPoint.position);
    }
}
