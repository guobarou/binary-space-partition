using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonNode : BinaryNode<DungeonNode>
{

    public Rect rect;
    public Rect room;

    public DungeonNode(int index, int level, Rect rect) : base(index, level)
    {
        this.rect = rect;
    }

    public void BuildRoom()
    {
        //适当缩小一点 随机范围为（宽/高的一半 到  减去围墙） 防止超出边界
        int roomWidth = (int)Random.Range(rect.width / 2, rect.width - 2);
        int roomHeight = (int)Random.Range(rect.height / 2, rect.height - 2);
        int roomX = (int)Random.Range(1, rect.width - roomWidth - 1);
        int roomY = (int)Random.Range(1, rect.height - roomHeight - 1);

        room = new Rect(rect.x + roomX, rect.y + roomY, roomWidth, roomHeight);
    }
}
