using System;
using UnityEngine;
using UnityEngine.EventSystems;


public static class UIApp {
    // 上面的格子打开
    public static void Panel_Cell_Open(UIContext ctx, int count) {

        
        Panel_Cell panel_Cell = ctx.panel_Cell;
        if (panel_Cell == null) {

            panel_Cell = GameObject.Instantiate(ctx.assetsContext.panel_Cell, ctx.canvas.transform);

            panel_Cell.Ctor();
            ctx.panel_Cell = panel_Cell;
        }
        panel_Cell.Init(count);
        panel_Cell.Show();
    }
}
