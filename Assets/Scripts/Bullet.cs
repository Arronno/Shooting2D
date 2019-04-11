using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;

    Shooter shooter;

    public float bulletSpeed = 30f;

    int targetSpeedMultiplier = 1;

    void Start()
    {
        rb.velocity = - transform.up * bulletSpeed;

        shooter = FindObjectOfType<Shooter>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            //Debug.Log("Miss");
            Destroy(gameObject);

            if (shooter.i < 3)
            {
                shooter.ReduceHealthOnMiss();
            }
            
            if (shooter.i == 3)
            {
                shooter.EndGame();
            }    
        }

        if (other.CompareTag("Target"))
        {
            //Debug.Log("Hit");
            SoundManagerScript.PlaySound("Hit");
            Destroy(gameObject);
            shooter.score++;

            targetSpeedMultiplier = (shooter.score / 5) + 1;

            if (targetSpeedMultiplier <= 3)
            {
                FindObjectOfType<TargetMover>().speed = 5f * targetSpeedMultiplier;
            }

            else
            {
                FindObjectOfType<TargetMover>().speed = 15f;
            }
            //Debug.Log(shooter.score);
        }
    }
}
