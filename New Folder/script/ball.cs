using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Camera cam;

    public float speed;
    public manager gm;
    public scriptscene scene;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.isGameOver)
        {
            rb.velocity = Vector3.zero;
            return;
        }
        if (Input.GetKey(KeyCode.W)) 
        {
            rb.AddForce(cam.transform.forward * speed);        
        }

        if (Input.GetKey(KeyCode.S)) 
        {
            rb.AddForce(cam.transform.forward * -speed);
        }

        if (Input.GetKey(KeyCode.A)) 
        {
            rb.AddForce(cam.transform.right * -speed);
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            rb.AddForce(cam.transform.right * speed);
        }

        if (Input.GetKey(KeyCode.R))
        {
            scene.Restart();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("stars"))
        {
            Destroy(other.gameObject);
            gm.collectedStars++;
        }

        if (other.CompareTag("Bottom"))
        {
            scene.Restart();
        }
    }
}


