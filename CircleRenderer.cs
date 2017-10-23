using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class CircleRenderer : LineDrawer {
    
   // public LineRenderer linerender;
    public int LinesCount;
    private float xi, yi,x=0,y=0;
    // Use this for initialization
    void Start () {
        
  
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    /*   public void DrawCircle() {
           float x = 0, y=0;
           LinesCount = linerender.positionCount;
           linerender.positionCount = LinesCount + 1;
                xi = 0;yi = 0;
           Vector3 v = new Vector3(xi, yi, 0);
           linerender.SetPosition(LinesCount, v);
            for(int i=0;i<LinesCount+1;i++)
              {
               xi = x + 200 * Mathf.Cos(Mathf.PI * (2 * i + 1) / LinesCount );
               yi = y + 200 * Mathf.Sin(Mathf.PI * (2 * i + 1) / LinesCount );
               Vector3 v1 = new Vector3(xi, yi, 0);
               linerender.SetPosition(i,v1);
               }*/

    public void DrawCircle()
    {
        xi = 0;yi = 0;
          Clear();
        LinesCount++;
        linerender.positionCount = LinesCount+1;
        for (int i = 0; i < LinesCount + 1; i++)
        {
            xi = x + 200 * Mathf.Cos(Mathf.PI * (2 * i + 1) / LinesCount);
            yi = y + 200 * Mathf.Sin(Mathf.PI * (2 * i + 1) / LinesCount);
            DrawLine(xi, yi, 0, i);
        }

    }

    public void drawstar()
    {
        float a = 0;
        xi = 0; yi = 0;
        Clear();
        LinesCount++;
        linerender.positionCount = LinesCount + 1;
              for (int i = 0; i < LinesCount-1 ; i++)
        {
            if (i % 2 == 0)
            {
                xi = x + 200 / 2 * Mathf.Cos(a );
                yi = y - 200 / 2 * Mathf.Sin(a );
            }
            else
            {
                xi = x + 150 * Mathf.Cos(a );
                yi = y - 150 * Mathf.Sin(a );
            }
            a = a + Mathf.PI / LinesCount;
            DrawLine(xi, yi, 0, i);
        }
       DrawLine(100, 0, 0, LinesCount);
    }


}

