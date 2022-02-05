using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectEfx
{
    public static void drawCircle(this GameObject container, float radius, float width)
    {
        var segment = 360;
        var line = container.AddComponent<LineRenderer>();
        line.useWorldSpace = false;
        line.startWidth = width;
        line.endWidth = width;
        line.positionCount = segment + 1;
        line.materials[0] = Resources.Load<Material>("Materials/Circle");
        line.startColor = new Color(255, 255, 255);
        line.endColor = new Color(255, 255, 255);
        var points = new Vector3[line.positionCount];
        for (int i = 0; i < points.Length; i++)
        {
            var rad = Mathf.Deg2Rad * i;
            points[i] = new Vector3(Mathf.Cos(rad) * radius, 0, Mathf.Sin(rad) * radius);
        }
        line.SetPositions(points);
    }
    public static void drawRectangle(this GameObject container, float wBox,float hbox, float width)
    {
        var line = container.AddComponent<LineRenderer>();
        line.useWorldSpace = false;
        line.startWidth = width;
        line.endWidth = width;
        line.startColor = new Color(255, 255, 255);
        line.endColor = new Color(255, 255, 255);
        line.positionCount = 5;
        line.SetPosition(0,new Vector3(-wBox,0,hbox));
        line.SetPosition(1, new Vector3(wBox, 0, hbox));
        line.SetPosition(2, new Vector3(wBox , 0, -hbox));
        line.SetPosition(3, new Vector3(-wBox, 0, -hbox));
        line.SetPosition(4, new Vector3(-wBox, 0, hbox));
    }
}
