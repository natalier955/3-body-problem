using UnityEngine;
//implements newtons law of of universal gravitation (F = G * (m1 * m2) / r^2) for n bodies in a system

public class NBodyGravity : MonoBehaviour
{

    public float mass = 1f;
    public static float G = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        NBodyGravity[] bodies = FindObjectsOfType<NBodyGravity>();
        foreach(NBodyGravity other in bodies)
        {
            if (other == this) continue;
            Vector3 direction = other.transform.position - transform.position;
            float distance = direction.magnitude;
            float forceMagnitude = G * (mass * other.mass) / (distance * distance);
            Vector3 force = direction.normalized * forceMagnitude;
            rb.AddForce(force);
        }
    }
}
