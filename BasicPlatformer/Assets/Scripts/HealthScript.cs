using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    Text myText;
    public int health = 100;

    void Start()
    {
        //Text sets your text to say this message
        myText = GetComponent<Text>();
        myText.text = "Health: " + health;
    }

    public void inflictDamage(int damage)
    {
        // see if the game is already over
        if (health == 0) return;

        // if not inflict damage and limit health minimum to zero
        health = health - damage;
        if (health <= 0)
        {
            health = 0;
            GameObject bobby = GameObject.Find("Bobby");
            BobbyScript bobbyScript = bobby.GetComponent<BobbyScript>();
            bobbyScript.killBobby();
        }
    }

    void Update()
    {
        myText.text = "Health: " + health;

    }
}
