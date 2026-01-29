using UnityEngine;

public class TestScene : MonoBehaviour
{

    [SerializeField] private Character[] character;

    public void SetIdle()
    {
        for (int i = 0; i < character.Length; i++)
        {
            character[i].SetState(CharStat.Idle);
        }
    }
    public void SetWalk()
    {
        for (int i = 0; i < character.Length; i++)
        {
            character[i].SetState(CharStat.Walk);
        }
    }

    public void SetAttack()
    {
        for (int i = 0; i < character.Length; i++)
        {
            character[i].SetState(CharStat.Attack);
            character[i].Anim.SetTrigger("Attack");
        }
    }
    public void SetDie()
    {
        for (int i = 0; i < character.Length; i++)
        {
            character[i].SetState(CharStat.Die);
            character[i].Anim.SetTrigger("Die");
        }
    }
}
