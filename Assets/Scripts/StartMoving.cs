using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
public class StartMoving : MonoBehaviour
{
    public GameObject car;
    public float speed;
    private Rigidbody rigidbody;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        transform.Translate(new Vector3(1f,0f,0f) * Time.deltaTime);

    }
    // Update is called once per frame
    public void StartMovingPlease()
    {
       
       
 
    }
    public void StopMovingPlease()
    {
        //speed = 0f;
       // car.transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            audioSource.Play();
        }
    }


}
