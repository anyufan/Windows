using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoArrange : ButtonBase {
    public GameObject[] mforms;
	// Use this for initialization
	void Start () {
        mforms = GameObject.FindGameObjectsWithTag("forms");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnClickBtn()
    {
        for (int i = 0; i < mforms.Length; i++) 
        {
            mforms[i].GetComponent<Transform>().localPosition = Grids.mlist[i];
        }
    }
}
