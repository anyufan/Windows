using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeArrange : ButtonBase {
    public GameObject[] mforms2;
    public bool flag;
	void Start () {
        mforms2 = GameObject.FindGameObjectsWithTag("forms");
        for (int i = 0; i < mforms2.Length; i++)
        {
            //Debug.Log(i);
        }
        flag = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnClickBtn()
    {
        if(flag==true)
        {
            for (int i = 0; i < mforms2.Length; i++)
            {
                mforms2[i].GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
                mforms2[i].transform.Rotate(new Vector3(0, 0, -90));
                mforms2[i].GetComponent<RectTransform>().pivot = new Vector2(0f, 0f);
            }
            PositionControl.Red.pivot = new Vector2(0.5f, 0.5f);
            PositionControl.Red.Rotate(new Vector3(0, 0, -90));
            PositionControl.Red.pivot = new Vector2(0f, 0f);
            flag = false;
            Debug.Log(flag);
        }

        else if(flag==false)
        {
            for (int i = 0; i < mforms2.Length; i++)
            {

                mforms2[i].GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
                mforms2[i].transform.Rotate(new Vector3(0, 0, 90));
                mforms2[i].GetComponent<RectTransform>().pivot = new Vector2(0f, 1f);
            }
            PositionControl.Red.pivot = new Vector2(0.5f, 0.5f);
            PositionControl.Red.Rotate(new Vector3(0, 0, 90));
            PositionControl.Red.pivot = new Vector2(0f, 1f);
            flag = true;
            Debug.Log(flag);
        }
        
    }
}
