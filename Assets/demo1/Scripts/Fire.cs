using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    public int speed;
    float line = 0;

    // Use this for initialization
    void Start() {
        line = GameObject.Find("boss").transform.position.y;
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < line)
            Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D obj) {
        if (obj.gameObject.tag == "quaivat") {
            Destroy(obj.gameObject);
            Destroy(this.gameObject);
        }
    }

}
