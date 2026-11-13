using UnityEngine;

public class CollideFloor : MonoBehaviour
{

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision detectada con: " + other.gameObject.name);

        if (other.gameObject.CompareTag("ObjectCollision"))
        {
            Debug.Log("Choco el: " + other.gameObject.tag);
        }
    }


}
