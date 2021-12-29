using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int pointValue = 1;
    ScoreScript theScoreScript;
    void Start()
    {
        GameObject sc = GameObject.Find("Score");
        theScoreScript = sc.GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        print("collected");
        theScoreScript.score += pointValue;
        Destroy(gameObject);
    }

}
