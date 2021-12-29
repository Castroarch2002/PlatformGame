using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamageScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int damageValue = 1;
    HealthScript theHealthScript;
    void Start()
    {
        GameObject ho = GameObject.Find("Health");
        theHealthScript = ho.GetComponent<HealthScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        theHealthScript.inflictDamage(damageValue);
    }

}
