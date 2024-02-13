using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientMain : MonoBehaviour {
    MainContext mainContext;
    // Start is called before the first frame update
    void Start() {
        Canvas worldCanvas = gameObject.transform.Find("Canvas").GetComponentInChildren<Canvas>();

    }

    // Update is called once per frame
    void Update() {

    }
}
