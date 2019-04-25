using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 窗口，红色底格生成器
/// </summary>
public class PositionControl : MonoBehaviour {
    public RectTransform panel;
    //public  static List<Vector3> mlist = new List<Vector3>();
    public static RectTransform Red;
    public static List<GameObject> windowList = new List<GameObject>();
    public GameObject g;

	void Start () {
        panel = gameObject.GetComponent<RectTransform>();
        //child = this.transform.Find("Image").GetComponent<RectTransform>();
        //Red = GameObject.Find("Canvas").transform.Find("Panel").transform.Find("Red").gameObject.GetComponent<RectTransform>();

        g = Resources.Load<GameObject>("Red");

        //CreateMesh(panel.rect.width, panel.rect.height, g.GetComponent<RectTransform>().rect.width, g.GetComponent<RectTransform>().rect.height);
        //生成红色基准底格
        g=GameObject.Instantiate(Resources.Load<GameObject>("Red"), this.transform);
        Red = g.GetComponent<RectTransform>();
        PositionControl.Red.gameObject.SetActive(false);
        
        g=GameObject.Instantiate(Resources.Load<GameObject>("Image"), this.transform);
        windowList.Add(g);
        
    }
	

	void Update () {

            
	}

    //生成网格和各个锚点，并将锚点存储起来,返回所有锚点的坐标，参数为父物体长宽，以及放入的窗体长宽
    //public void CreateMesh(float length, float width, float x, float y)
    //{

    //    Vector3 v;
    //    int a, b;
    //    a = (int)(length / x);
    //    b = (int)(width / y);
    //    for (int i = 0; i < a; i++)
    //    {
    //        for (int j = 0; j < b; j++)
    //        {
    //            v = new Vector3(i * x, -j * y, 0);
    //            mlist.Add(v);
    //            //g = Resources.Load<GameObject>("Grid");
    //            g = GameObject.Instantiate(Resources.Load<GameObject>("Grid"), this.transform);
    //            g.transform.localPosition = v;

    //        }


    //    }
    //}
    
}
