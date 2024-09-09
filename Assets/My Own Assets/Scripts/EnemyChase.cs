using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] GameObject player;
    [SerializeField] GameObject sphere;
    float dis = 0;
    Vector3 startingposition;
    public GameObject ps2;
    [SerializeField] AudioSource aud2;
    [SerializeField] AudioSource aud3;
    private void Start()
    {
        startingposition = agent.transform.position;

    }

    void Update()
    {
        if (player == null) return;




        dis = Vector3.Distance(agent.transform.position, player.transform.position);
        if (dis > 1.8f)
        {
            if (dis < 18)
            {
                agent.SetDestination(player.transform.position);
            }
            else
            {
                agent.SetDestination(startingposition);
            }

        }

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
                agent.ResetPath();
            }
            else
            {
                aud3.Play();
                ps2.transform.position = transform.position;
                ps2.GetComponent<ParticleSystem>().Play();
                Destroy(gameObject);

            }

        }
    }

}



