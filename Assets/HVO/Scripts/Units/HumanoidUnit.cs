using UnityEngine;

public class HumanoidUnit : AlexUnit
{
    public bool isMoving;
    protected Vector2 m_Velocity;
    protected Vector3 m_lastPosition;

    public float CurrentSpeed => m_Velocity.magnitude;

    protected void Update() {
        m_Velocity = new Vector2(transform.position.x - m_lastPosition.x, transform.position.y - m_lastPosition.y) / Time.deltaTime;
        m_lastPosition = transform.position;
        isMoving = m_Velocity.magnitude > 0f;

        m_Animator.SetFloat("speed", Mathf.Clamp01(CurrentSpeed));
    }
}