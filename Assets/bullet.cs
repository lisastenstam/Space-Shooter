using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_bullet : MonoBehaviour
{
    [SerializeField]
    private KeyCode shoot;
    [SerializeField]
    private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(shoot)) //när vi klickar ned space så skjuts en bullet 
        {
            Instantiate(bullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity); //skapar kloner av bullets och får de att åka upp
        }
    }
}