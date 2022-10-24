using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField, Range(1, 10)]
    private float speed = 4;

    private Vector3 direction = new Vector3(1, 1, 0);

    // Update is called once per frame
    void Update()
    {

        transform.position += speed * direction * Time.deltaTime; //Gör så att bollen rör på sig. -Tobias
    }

    public void Reset() //Sätter tillbaka bollen på start platsen. -Tobias
    {
        transform.position = new Vector3(0, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player") //Om bollen nuddar en paddel. Studsar den och ökar fart. - Tobias
        {
            speed += 0.25f;
            direction.x = -direction.x;
            direction.y = -Random.Range(-1, 2);
            print("träff");
        }
        else //Om den träffar något annat så byter den riktning i Y-axlen. -Tobias
        {
            direction.y = -direction.y;
        }
    }
