using UnityEngine;

public class AIPawn : MonoBehaviour
{
    private Vector3? m_Destination;

    public Vector3? Destination => m_Destination;

    [SerializeField]
    private float m_Speed = 1.0f;

    public void SetDestination(Vector3 destination)
    {
        m_Destination = destination;
    }

    void Start()
    {
        // Initialize the destination to null
        SetDestination(new Vector3(-1.15f, -5.19f, 0));
    }

    void Update()
    {
        // Check if the destination is set
        if (m_Destination.HasValue)
        {
            // Move towards the destination
            Vector3 direction = (m_Destination.Value - transform.position).normalized;
            transform.position += direction * Time.deltaTime * m_Speed;

            var distanceToDestination = Vector3.Distance(transform.position, m_Destination.Value);

            if (distanceToDestination < 0.1f)
            {
                m_Destination = null;
            }
        }
    }
}