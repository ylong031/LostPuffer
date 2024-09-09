using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.UI;

public class BossAttack : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject player;
    public GameObject ps2;
    [SerializeField] Image hpbar;
    float time = 0;
    bool hit;
    [SerializeField]Animator anim;
    [SerializeField] AudioSource aud2;
    [SerializeField] AudioSource aud3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;

        if (time > 5)
        {
         
            for(int i=0;i<8;i++) 
            {
                Instantiate(projectile, transform);
                projectile.transform.rotation = Quaternion.Euler(new Vector3(0, 45 * i, 0));
            }
            time = 0;
        }
    }

    private IEnumerator Animationplaying()
    {
        time = 0;
        yield return new WaitForSeconds(3f);
        hit = false;
        anim.SetBool("gethit", false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            if (!sphere.activeSelf)
            {
                player.GetComponent<PlayerMovement>().PlayParticle();
                aud2.Play();
                Destroy(player);
            }
            else
            {
                    if (!hit) 
                    {
                     
                        hpbar.fillAmount = hpbar.fillAmount - 0.25f;
                        if (hpbar.fillAmount == 0)
                        {
                            ps2.transform.position = transform.position;
                            ps2.GetComponent<ParticleSystem>().Play();
                            Destroy(gameObject);
                            aud3.Play();
                        }
                        else 
                        {
                            hit = true;
                            anim.SetBool("gethit", true);
                            StartCoroutine(Animationplaying());
                            aud3.Play();
                    }
                }
  

            }

        }
    }
}
