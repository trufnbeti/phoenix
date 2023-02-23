using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour {
    public float speed;
    public int dmg;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y > 6)
            DestroyImmediate(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D obj) {
        if (obj.gameObject.tag == "phuonghoang") {
            Destroy(this.gameObject);
        }
    }

}
