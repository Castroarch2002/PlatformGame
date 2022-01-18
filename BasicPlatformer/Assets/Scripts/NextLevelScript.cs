using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    // Start is called before the first frame update

    public string targetLevel;

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        SceneManager.LoadSceneAsync("Scenes/" + targetLevel);
    }

}