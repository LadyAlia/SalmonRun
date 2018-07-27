using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float maxHealth = 100f;
    public float curHealth = 0f;
    public GameObject healthBar;

    void Start() {

        curHealth = maxHealth;
        //InvokeRepeating("decreasehealth", 1f, 1f);
	}

    void Update() {

        curHealth = Mathf.Min(curHealth - Time.deltaTime * 2f, maxHealth);
        float calcHealth = curHealth / maxHealth;
        SetHealthBar(calcHealth);
    }

    public void SetHealthBar(float myHealth) {

        healthBar.transform.localScale = new Vector3(myHealth,healthBar.transform.localScale.y,healthBar.transform.localScale.z );
        
    }
}
