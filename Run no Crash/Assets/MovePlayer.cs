using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody rb;
    public float jumbForce = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(transform.position.y <= 0)
            {
                rb.AddForce(Vector3.up * jumbForce, ForceMode.Impulse);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x < 7.5f)
            {
                transform.position = transform.position + new Vector3(7.5f, 0, 0);
            }
            //transform.position = transform.position +
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x > -7.5f)
            {
                transform.position = transform.position + new Vector3(-7.5f, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemie")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
