using UnityEngine;

public class Velocity3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    Rigidbody rb = GetComponent<Rigidbody>(); 
    rb.linearVelocity = new Vector3(-0.3f, 0f, 0f);

    }
}
