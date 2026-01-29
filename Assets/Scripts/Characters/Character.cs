using System;
using UnityEngine;
using UnityEngine.AI;

public enum CharStat
{
    Idle,
    Walk,
    Attack,
    Hit,
    Die
}

public abstract class Character : MonoBehaviour
{
    protected NavMeshAgent navAgent;

    protected Animator anim;
    public Animator Anim
    {
        get { return anim; }
    }

    [SerializeField] protected CharStat state;
    public CharStat State
    {
        get { return state; }
    }

    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        
    }

    public void SetState(CharStat s)
    {
        state = s;
    }
}
