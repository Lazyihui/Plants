public  class GameContext {
    public AssetsContext assetsContext;

public UIContext  uiContext;
    public GameContext() {

        assetsContext = new AssetsContext();
        uiContext = new UIContext();
    }

    public void Inject(UIContext uiContext,AssetsContext assetsContext) {
        this.uiContext = uiContext;
        this.assetsContext = assetsContext;
    }
}