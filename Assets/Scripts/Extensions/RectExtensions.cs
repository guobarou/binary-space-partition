using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RectExtensions
{
    public static Rect Intersect(this Rect a, Rect b)
    {
        a = a.Normalize();
        b = b.Normalize();

        float xMin = Mathf.Max(a.xMin, b.xMin);
        float xMax = Mathf.Min(a.xMax, b.xMax);
        float yMin = Mathf.Max(a.yMin, b.yMin);
        float yMax = Mathf.Min(a.yMax, b.yMax);

        if (xMin >= xMax || yMin >= yMax)
        {
            return new Rect(0, 0, 0, 0);
        }

        return new Rect(xMin, yMin, xMax - xMin, yMax - yMin);
    }

    public static Rect Normalize(this Rect rect)
    {
        return new Rect(
            rect.width < 0 ? rect.x + rect.width : rect.x,
            rect.height < 0 ? rect.y + rect.height : rect.y,
            Mathf.Abs(rect.width),
            Mathf.Abs(rect.height)
        );
    }
}
