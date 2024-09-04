
using UnityEngine;

public class Project: MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        ApplyMoviment();
    }

    void ApplyMoviment()
    {
        transform.Translate(Time.deltaTime * speed *  Vector3.up);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
