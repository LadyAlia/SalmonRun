using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public float maxHealth = 100f;
    public float curHealth = 0f;
    public GameObject healthBar;
    public Text Livetext;
    public int lives;

    void Start() {
        lives = 3;
        curHealth = maxHealth;
        //InvokeRepeating("decreasehealth", 1f, 1f);
	}

    void Update() {

        curHealth = Mathf.Min(curHealth - Time.deltaTime * 4f, maxHealth);
        float calcHealth = curHealth / maxHealth;
        SetHealthBar(calcHealth);

        if (curHealth < 0f) {
            LoseLife();
        }

    }

    public void LoseLife() {
        Livetext.text = "Lives left:" + lives; 
        //print(Livetext + lives);
        lives--;
        curHealth = maxHealth;
        if (lives < 0) {
            Destroy(gameObject);
            SceneManager.LoadScene("GameIsOver");
        }
    }

    public void SetHealthBar(float myHealth) {

        healthBar.transform.localScale = new Vector3(myHealth,healthBar.transform.localScale.y,healthBar.transform.localScale.z );
        
    }
}
