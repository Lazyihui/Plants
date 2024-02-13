using UnityEngine;
using System;

public class UIContext {

    public Panel_Cell panel_Cell;

    public Canvas canvas;

    public AssetsContext assetsContext;

    public void Inject(Canvas canvas,AssetsContext assetsContext){
        this.canvas = canvas;
        this.assetsContext = assetsContext;
    }

}