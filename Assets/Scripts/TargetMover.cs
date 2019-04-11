using UnityEngine;

public class TargetMover : MonoBehaviour
{
    int direction = 1;

    [HideInInspector]
    public float speed = 5f;

    void FixedUpdate()
    {
        transform.Translate(transform.up * direction * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bound"))
        {
            direction = -direction;
        }
    }
}
