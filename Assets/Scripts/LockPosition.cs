using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockPosition : ButtonBase {
    public Text mText;
    public bool isLocked;
    public DragDemo mDragDemo;
	
	void Start () {
        isLocked = false;
        mText = this.gameObject.GetComponentInChildren<Text>();
        mDragDemo = this.gameObject.GetComponentInParent<DragDemo>();
	}
	
	
	void Update () {
		
	}

    public override void OnClickBtn()
    {
        if(isLocked==false)
        {
            mDragDemo.enabled = false;
            mText.text = "已锁定位置";
            isLocked = true;
        }
        else if(isLocked==true)
        {
            mDragDemo.enabled = true;
            mText.text = "锁定位置";
            isLocked = false;
        }
        
    }
}
