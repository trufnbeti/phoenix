using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devil : MonoBehaviour {
    public float speed;
    public Spear spear;
    float shot = 0;

    // Use this for initialization
    void Start() {
        shot = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update() {
        if (Time.realtimeSinceStartup - shot > speed) {
            shot = Time.realtimeSinceStartup;
            Instantiate(spear, transform.position, Quaternion.identity);
        }
    }

}
