using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public float maxHealth = 100f;
    public float curHealth = 0f;
    public GameObject healthBar;
    public int lives;
    GameObject[] lifeBubbles;


    void Start() {
        lives = 3;
        curHealth = maxHealth;
        lifeBubbles = new GameObject[3] { GameObject.FindGameObjectWithTag("Life1"), GameObject.FindGameObjectWithTag("Life2"), GameObject.FindGameObjectWithTag("Life3") };
        //InvokeRepeating("decreasehealth", 1f, 1f);
	}

    void Update() {

        curHealth = Mathf.Min(curHealth - Time.deltaTime * 2f, maxHealth);
        float calcHealth = curHealth / maxHealth;
        SetHealthBar(calcHealth);

        if (curHealth < 0f) {
            LoseLife();
        }

    }

    public void LoseLife() {
        lives--;
        curHealth = maxHealth;
        if (lives < 0) {
            Destroy(gameObject);
            SceneManager.LoadScene("GameIsOver");
        } else {
            Destroy(lifeBubbles[lives]);
        }
    }

    public void SetHealthBar(float myHealth) {

        healthBar.transform.localScale = new Vector3(myHealth,healthBar.transform.localScale.y,healthBar.transform.localScale.z );
        
    }
}
