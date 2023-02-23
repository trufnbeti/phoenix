using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pheonix : MonoBehaviour {
    public int speed;
    public Fire x;
    float shot = 0;
    public float timeShot;
    public Spear ax;
    public int maxHealth = 100;
    public HealBar healthBar;
    int currentHealth;

    void Start() {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        shot = Time.realtimeSinceStartup;
    }

    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space)) {
            //thời gian phun lửa nhanh nhất là timeShot
            if (Time.realtimeSinceStartup - shot > timeShot) {
                shot = Time.realtimeSinceStartup;
                Instantiate(x, transform.position, Quaternion.identity);
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "spear") {
            currentHealth -= ax.dmg;
            healthBar.SetHealth(currentHealth);
            Debug.Log(currentHealth);
            if (currentHealth <= 0)
                Destroy(this.gameObject);
        }
    }
}
