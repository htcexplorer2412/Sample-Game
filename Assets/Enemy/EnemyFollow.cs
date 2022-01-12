using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] Transform targetPos;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    
    void Update()
    {
        agent.SetDestination(targetPos.position);
    }
}
