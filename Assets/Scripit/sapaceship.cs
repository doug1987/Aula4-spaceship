
using UnityEngine;

public class sapaceship : MonoBehaviour
{
    public Project projectPrefab;
    public float speed = 5f;
    void Update()

    {
        ApplyMovement();
        FireProjecttile();
        
    }

    void ApplyMovement()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        {

            transform.Translate(Time.deltaTime * speed * new Vector3(horizontal, vertical, 0));

        }

    }

    void FireProjecttile()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectPrefab, transform.position, Quaternion.identity);
        }
    }

        
        

       
}
