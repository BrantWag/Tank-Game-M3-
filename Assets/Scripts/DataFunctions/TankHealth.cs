using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour
{
    [HideInInspector] public TankData data;

	// Use this for initialization
	void Start ()
    {
        data = GetComponent<TankData>();
	}
    // reduce current health 
    public void reduceCurrentHealth(float damage)
    {
        data.healthCurrent -= damage;
        checkDeath();
    }

    // check if player has died
    public void checkDeath()
    {
        if (data.healthCurrent <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    // Reset current health 
    public void resetHealth()
    {
        data.healthCurrent = data.healthMax;
    }

}
