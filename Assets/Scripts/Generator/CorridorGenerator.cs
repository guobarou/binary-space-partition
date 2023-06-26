using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CorridorGenerator 
{
    public static void CreatCorridors(int maxLevel, Dictionary<int, List<DungeonNode>> dicNodes, List<Rect> corridors)
    {
        if (maxLevel <= 0) return;

        int index = (int)Mathf.Pow(2, maxLevel - 1) - 1;
        int length = (int)Mathf.Pow(2, maxLevel) -1;

        Debug.Log(maxLevel + ":" + index + "," + length);

        for (int i = index ; i < length; i++)
        {
            int leftIndex = 2 * i + 1;
            dicNodes.TryGetValue(leftIndex, out var leftList);

            int rightIndex = 2 * i + 2;
            dicNodes.TryGetValue(rightIndex, out var rightList);

            if (leftList != null && rightList != null)
            {
                NearestNeighborSearch(leftList, rightList, out var leftNode, out var rightNode);
                corridors.Add(CreatCorridor(leftNode, rightNode));

                dicNodes[i] = leftList.Concat(rightList).ToList();
            }
        }
        CreatCorridors(maxLevel - 1, dicNodes, corridors);
    }

    private static Rect CreatCorridor(DungeonNode leftNode, DungeonNode rightNode)
    {
        Rect leftRect = leftNode.room;
        Rect rightRect = rightNode.room;

        //水平交集，垂直走廊
        if(leftRect.Overlaps(new Rect(rightRect.xMin, leftRect.yMin, rightRect.width, leftRect.height)))
        {
            int corridorX = (int)(Mathf.Max(leftRect.x, rightRect.x) + Mathf.Min(leftRect.xMax, rightRect.xMax)) / 2;
            int corridorY = (int)Mathf.Min(leftRect.yMax, rightRect.yMax);
            int corridorWidth = 1;
            int corridorHeight = (int)Mathf.Max(leftRect.y, rightRect.y) - corridorY;

            return new Rect(corridorX, corridorY, corridorWidth, corridorHeight);
        }
        //垂直交集，水平走廊
        else if(leftRect.Overlaps(new Rect(leftRect.xMin, rightRect.yMin, leftRect.width, rightRect.height)))
        {
            int corridorX = (int)Mathf.Min(leftRect.xMax, rightRect.xMax);
            int corridorY = (int)(Mathf.Max(leftRect.y, rightRect.y) + Mathf.Min(leftRect.yMax, rightRect.yMax)) / 2;
            int corridorWidth = (int)Mathf.Max(leftRect.x, rightRect.x) - corridorX;
            int corridorHeight = 1;

            return new Rect(corridorX, corridorY, corridorWidth, corridorHeight);
        }
        else
        {
            Debug.LogError("Warring!!!!! + 无交集，需要转角走廊或其他方案");
            return new Rect(0, 0, 0, 0);
        }        
    }

    private static void NearestNeighborSearch(List<DungeonNode> leftList, List<DungeonNode> rightList, out DungeonNode leftNode, out DungeonNode rightNode)
    {
        leftNode = null;
        rightNode = null;

        float minimumDistance = float.MaxValue;

        foreach (DungeonNode node1 in leftList)
        {
            foreach (DungeonNode node2 in rightList)
            {
                float distance = Vector2.Distance(node1.room.center, node2.room.center);
                minimumDistance = Mathf.Min(distance, minimumDistance);

                if (distance == minimumDistance)
                {
                    leftNode = node1;
                    rightNode = node2;
                }
            }
        }
    }
}
