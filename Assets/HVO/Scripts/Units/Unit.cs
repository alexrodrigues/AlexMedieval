using UnityEngine;

public abstract class AlexUnit: MonoBehaviour
{
    public bool IsMoving;

    protected Animator m_Animator;

    protected void Awake()
    {

        if (TryGetComponent<Animator>(out var Animator))
        {
            m_Animator = GetComponent<Animator>();
        }

        var gameManager = GameManager.Get();
        gameManager.Test();
    }
}