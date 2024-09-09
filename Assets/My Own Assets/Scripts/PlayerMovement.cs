using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float upwardforce;
    public float horizontalforce;
    public GameObject pfish;
    [SerializeField] GameObject sphere;
    public GameObject ps;
    AudioSource aud1;
    [SerializeField]AudioSource aud2;

    
    void Start()
    {
        aud1=GetComponent<AudioSource>();  
        
    }

    
    void Update()
    {
       

        if (gameObject == null) return;
       
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pfish.transform.rotation = Quaternion.Euler(0, 240, 0);
            rb.velocity = Vector3.left * horizontalforce;
            rb.AddForce(Vector3.up*upwardforce);
            aud1.Play();

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pfish.transform.rotation = Quaternion.Euler(0, 140, 0);
            rb.velocity = Vector3.right * horizontalforce;
            rb.AddForce(Vector3.up * upwardforce);
            aud1.Play();
        }

    }


    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag== "obstacles")
        {
            aud2.Play();
            PlayParticle();
            Destroy(gameObject);
         


        }
    
    }

    

    public void PlayParticle()
    {
        
        ps.transform.position = transform.position;
        ps.GetComponent<ParticleSystem>().Play();
        

    }

   
 


}
