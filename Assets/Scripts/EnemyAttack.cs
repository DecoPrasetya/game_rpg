using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float damage = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<PlayerHealt>().ChangeHealth(-damage);
    }
}
