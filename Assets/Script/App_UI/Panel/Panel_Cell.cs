using UnityEngine;
using UnityEngine.UI;

public class Panel_Cell : MonoBehaviour {
    [SerializeField] Image elePrefab;

    public void Ctor() { }

    public void Init(int count) {

    }
    public void Show() {
        Debug.Log("Panel_Cell Show");
        gameObject.SetActive(true);
    }
    public void Close() {
        gameObject.SetActive(false);
    }
}