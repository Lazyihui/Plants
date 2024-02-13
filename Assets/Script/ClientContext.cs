using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainContext : MonoBehaviour {

    public GameContext gameBusiness;
    public UIContext uiContext;

    public AssetsContext assetsContext;


    public MainContext() {
        gameBusiness = new GameContext();
        uiContext = new UIContext();
        assetsContext = new AssetsContext();
    }

    public void Inject(Canvas canvas) {
        gameBusiness.Inject(uiContext, assetsContext);
        uiContext.Inject(canvas, assetsContext);
    }
}