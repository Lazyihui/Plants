using System.Collections.Generic;

using UnityEngine;

public class AssetsContext {

    public Panel_Cell panel_Cell;



    public Dictionary<string, GameObject> Panenls;

    public Dictionary<string, GameObject> Entities;

    public AssetsContext() {
        Panenls = new Dictionary<string, GameObject>();
    }


    public bool Panel_TryGetPrefab(string name, out GameObject prefab) {
        return Panenls.TryGetValue(name, out prefab);
    }
    public bool Entities_TryGetPrefab(string name, out GameObject prefab) {
        return Entities.TryGetValue(name, out prefab);
    }

}