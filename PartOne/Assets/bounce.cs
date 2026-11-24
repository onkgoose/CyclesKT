using System.Collections;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public float threshold = 2f;
    private Rigidbody rb;
    private Renderer rend;
    private bool slow;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }

    void FixedUpdate()
    {
        if (!slow && rb.linearVelocity.magnitude < threshold)
            StartCoroutine(CheckSpeed());
    }

    IEnumerator CheckSpeed()
    {
        slow = true;
        rend.material.color = Color.red;
        float time = 0f;

        do
        {
            yield return new WaitForFixedUpdate();
            time += Time.fixedDeltaTime;
        }
        while (rb.linearVelocity.magnitude < threshold);

        rend.material.color = Color.white;
        slow = false;
    }
}