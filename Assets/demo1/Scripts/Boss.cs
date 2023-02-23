using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
    public float genSpeed;
    public float spearSpeed;
    public Devil x;
    float minx = 0, maxx = 0;

    // Use this for initialization
    void Start() {
        minx = transform.position.x;
        maxx = -minx;
        InvokeRepeating("GenDevil", 2.0f, genSpeed);
    }

    void GenDevil() {
        var pos = transform.position;
        pos.x = (Random.value * (maxx - minx)) + minx;
        x.speed = spearSpeed;
        Instantiate(x, pos, Quaternion.identity);
    }
}
