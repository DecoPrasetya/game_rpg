using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float damage = 1;
    private Rigidbody2D rb;
    public GameObject player;
    private EnemyMovement self;
    private bool isAttacking = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        self = GetComponent<EnemyMovement>();
    }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.tag == "Player")
    //     {
    //         collision.gameObject.GetComponent<PlayerHealt>().ChangeHealth(-damage);
    //     }
    // }

    public void Attack()
    {
        if (self.Chase())
        {
            if (isAttacking)
            {
                AttackCooldown();
                return;
            }
            isAttacking = true;
            Debug.Log("attack");
            player.GetComponent<PlayerHealt>().ChangeHealth(-damage);
        }
    }

    void AttackCooldown()
    {
        isAttacking = false;
    }
}
