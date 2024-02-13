using UnityEngine;
using System.Collections.Generic;


public class UIContext {

    public Canvas canvas;
    public AssetsContext assetsContext;

    public Panel_Cell panel_Cell;

    public UIContext() {
    }

    public void Inject(Canvas canvas, AssetsContext assetsContext) {
        this.canvas = canvas;
        this.assetsContext = assetsContext;
    }    
}