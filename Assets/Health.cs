using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    int hp = 10;   //startar figuren med 10 hp
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject); //n�r health �r mindre eller lika med 0 s� f�rst�rs objektet med denna kod
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       

    }
}
