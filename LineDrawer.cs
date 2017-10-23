using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour {
    public LineRenderer linerender;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
    public void DrawLine(float x, float y, float z/*, float x1, float y1, float z1,*/,int pos)
      {
       // linerender.positionCount = linerender.positionCount + 2;
        Vector3 v = new Vector3(x,y,z);
     //   Vector3 v4 = new Vector3(x1, y1, z1);
        linerender.SetPosition(pos, v);
      //  linerender.SetPosition( pos +1, position: v4);

    }
    public void Clear()
         {
        for (int i = 0; i < linerender.positionCount ; i++) { 
            Vector3 v = new Vector3(0, 0, 0);
        linerender.SetPosition(i, v);
        }
    }

 

    public void Close()
    {
        Application.Quit();
    }
  
    }
