using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMeshAgent : MonoBehaviour
{
    [SerializeField] private Transform movPosition;
    private NavMeshAgent playerNavMesh;
    Vector3 destination;
    void Start()
    {
        playerNavMesh = GetComponent<NavMeshAgent>();
        destination = playerNavMesh.destination;
       

    }

 
    void Update()
    {
        playerNavMesh.SetDestination(movPosition.position);

    }
}
