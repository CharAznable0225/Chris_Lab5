using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTransformAgent : MonoBehaviour
{
    [SerializeField] private Transform MoveToPoint;
    [SerializeField] private NavMeshAgent NavMeshAgent;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(0, 0, 0);
        NavMeshAgent.destination = PlayerLocatorSingleton.Instance.transform.position;
    }
}
