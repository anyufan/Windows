using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDemo : ButtonBase, IPointerDownHandler, IPointerUpHandler
{
    Transform parent;
    bool allowMove = false;
    public float distance;
    public Vector3 minVector;
    void Start()
    {

        parent = this.transform.parent;
        //Red = GameObject.Find("Canvas").transform.Find("Panel").transform.Find("Red");
        //Red = this.transform.Find("Red").GetComponent<Transform>();
        //PositionControl.Red.gameObject.SetActive(false);
        //this.transform.SetParent(Red);

    }



    // Update is called once per frame
    public Vector3 dir;
    void Update()
    {

        if (allowMove == true)
        {

            this.transform.position = Input.mousePosition - new Vector3(100, -50, 0);

            dir = Vector3.Normalize(this.GetComponent<RectTransform>().localPosition - new Vector3());
            dir = new Vector3(dir.x, 0, dir.y);
            
            distance = 65536f;
            for (int i = 0; i < Grids.mlist.Count; i++)
            {
                if (distance > System.Math.Abs(Vector3.Distance(Grids.mlist[i], this.transform.localPosition)))
                {
                    distance = System.Math.Abs(Vector3.Distance(Grids.mlist[i], this.transform.localPosition));
                    minVector = Grids.mlist[i];
                    
                }
            }
            PositionControl.Red.localPosition = minVector;
            PositionControl.Red.gameObject.SetActive(true);
            
           
        }
        
        
       


    }

    public override void OnClickBtn()
    {

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        allowMove = true;
        PositionControl.Red.gameObject.SetActive(true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        allowMove = false;
        this.transform.localPosition = minVector;

        PositionControl.Red.gameObject.SetActive(false);
    }

}
