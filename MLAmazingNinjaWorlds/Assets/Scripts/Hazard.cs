using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{       
    public GameObject background;
    public GameObject HealthBar;

    private void OnTriggerEnter(Collider other)
    {
        background.GetComponent<GameManager>().moveToCheckPoint();

        //game doesn't complie when this line is added so skip to step 17b then it will work
        HealthBar.GetComponent<LifeHUD>().HurtPlayer();
    }
}
