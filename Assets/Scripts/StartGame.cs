using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ExampleClass : MonoBehaviour
{

    bool aremoving;
    float randomNumber;

    public float timerRock;
    public GameObject perso;


    void Start()
    {
        //StartCoroutine(coroutine());

        timerRock = 0.0f;

    }

    void Update()
    {

        timerRock += Time.deltaTime;

        if (timerRock > 0.2f)  // nombre de seconde
        {

            Collider[] hitColliders = Physics.OverlapSphere(perso.transform.position, 10);  // le nombre 5 : taille de la sphere en metre
            foreach (var hitCollider in hitColliders)
            {
                GameObject rock = hitCollider.gameObject;

                if (rock.tag == "Rock")
                {
                    if (rock.GetComponent<Rigidbody>() != null)
                    {

                        if (rock.GetComponent<Rigidbody>().velocity.magnitude > 0.01) // vitesse
                        {
                            randomNumber = Random.Range(0.0f, 2.0f);  // random

                            if (randomNumber <= 1.5f)
                            {
                                Destroy(rock);
                            }
                            else if (randomNumber > 1.5f)
                            {
                                Debug.Log("randomNumber est au dessus de 1 ");
                            }
                        }

                    }
                }
            }

            timerRock = 0.0f;

        }

    }
                  
}
