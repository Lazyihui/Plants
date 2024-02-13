using UnityEngine;

public static class GameBusiness {
    public static void Enter(GameContext gameContext) {


        UIApp.Panel_Cell_Open(gameContext.uiContext, 9);
    }

    //每帧调用
    public static void PreTick(GameContext gameContext, float dt) {

    }

    //可能多次调用
    public static void FixedTick(GameContext gameContext, float fixdt) {

    }
}