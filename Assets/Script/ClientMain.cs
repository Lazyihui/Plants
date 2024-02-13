using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientMain : MonoBehaviour {
    MainContext ctx;
    // Start is called before the first frame update
    void Start() {

        Canvas worldCanvas = gameObject.transform.Find("Canvas").GetComponentInChildren<Canvas>();
        Camera mainCamera = gameObject.GetComponentInChildren<Camera>();
        Debug.Assert(worldCanvas != null);

        ctx = new MainContext();
        ctx.Inject(worldCanvas);

        GameBusiness.Enter(ctx.gameBusiness);


    }

    // Update is called once per frame
    void Update() {
    }
}
