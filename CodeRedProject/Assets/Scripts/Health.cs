using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public int maxHealth;
    public int minHealth;
    public int currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = 1000;
	}
	
	// Update is called once per frame
	void Update () {

        if(currentHealth>maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(currentHealth<minHealth)
        {
            currentHealth = minHealth;
            Destroy(this);
            //TODO make the game end
        }
	
	}

    public void Damage(int damage)
    {
        currentHealth -= damage;
    }

}
