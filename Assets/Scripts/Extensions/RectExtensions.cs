using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RectExtensions
{
    // 检查两个Rect是否有交集，并返回交集区域
    public static Rect Intersect(this Rect a, Rect b)
    {
        // 确保Rect的宽度和高度都是正数
        a = a.Normalize();
        b = b.Normalize();

        // 计算交集区域的左下角和右上角坐标
        float xMin = Mathf.Max(a.xMin, b.xMin);
        float xMax = Mathf.Min(a.xMax, b.xMax);
        float yMin = Mathf.Max(a.yMin, b.yMin);
        float yMax = Mathf.Min(a.yMax, b.yMax);

        // 如果没有交集，返回一个空的Rect
        if (xMin >= xMax || yMin >= yMax)
        {
            return new Rect(0, 0, 0, 0);
        }

        // 返回交集区域
        return new Rect(xMin, yMin, xMax - xMin, yMax - yMin);
    }

    // 返回一个新的Rect，它的宽度和高度都是正数
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
