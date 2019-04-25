using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 网格生成器
/// </summary>
public class Grids : MonoBehaviour {
    public static List<Vector3> mlist = new List<Vector3>();
    public GameObject g;
    public RectTransform panel;
	void Start () {
        panel = this.transform.parent.gameObject.GetComponent<RectTransform>();
        g = Resources.Load<GameObject>("Red");

        CreateMesh(panel.rect.width, panel.rect.height, g.GetComponent<RectTransform>().rect.width, g.GetComponent<RectTransform>().rect.height);
	}
	

	void Update () {
		
	}
    public void CreateMesh(float length, float width, float x, float y)
    {

        Vector3 v;
        int a, b;
        a = (int)(length / x);
        b = (int)(width / y);
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                v = new Vector3(i * x, -j * y, 0);
                mlist.Add(v);
                
                g = GameObject.Instantiate(Resources.Load<GameObject>("Grid"), this.transform);
                g.transform.localPosition = v;

            }
        }
    }


}
