using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

    public float offsetX;

    Material material;
    Vector2 offset;


    // Use this for initialization
    void Awake () {
        material = GetComponent<Renderer>().material;
	}

    private void Start()
    {
        offset = new Vector2(offsetX, 0.0f);
    }

    // Update is called once per frame
    void Update () {
        material.mainTextureOffset += offset * Time.deltaTime;
	}
}
