using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWindow : ButtonBase {
    public GameObject go;
    public Transform parent;
	void Start () {
        parent = this.gameObject.transform.parent;
       // gameObject.transform.parent.gameObject
	}

    public override void OnClickBtn()
    {
        go = GameObject.Instantiate(Resources.Load<GameObject>("Image"), parent);
        PositionControl.windowList.Add(go);
    }
}
