using System;
using UnityEngine;
using UnityEngine.EventSystems;


public static class UIApp {
    // 上面的格子打开
    public static void Panel_Cell_Open(UIContext ctx, int count) {


        Panel_Cell panel_Cell = ctx.panel_Cell;
        if (panel_Cell == null) {

            ctx.assetsContext.Panel_TryGetPrefab("Panel_Cell", out GameObject prefab);

            panel_Cell = GameObject.Instantiate(prefab, ctx.canvas.transform).GetComponent<Panel_Cell>();

            panel_Cell.Ctor();
            ctx.panel_Cell = panel_Cell;
        }
        panel_Cell.Init(count);
        panel_Cell.Show();
    }
}
