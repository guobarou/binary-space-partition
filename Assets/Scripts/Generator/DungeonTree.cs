using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonTree : BinaryTree<DungeonNode>
{

    public List<DungeonNode> finalNodes;

    public DungeonTree(DungeonNode root) : base (root){}

    public List<DungeonNode> GetFinalNodes(int minSize)
    {
        List<DungeonNode> nodes = new List<DungeonNode>();
        DivideRect(root, minSize, nodes);

        return nodes;
    }

    public List<DungeonNode> GetAllNodes()
    {
        List<DungeonNode> nodes = new List<DungeonNode>();
        CreateAllNodes(0, 1, GetMaxLevel(), new Rect(0, 0, 2, 2), nodes);

        return nodes;
    }

    private void CreateAllNodes(int index, int level, int maxLevel, Rect rect, List<DungeonNode> nodes)
    {
        if (root == null)
        {
            Debug.Log("BinaryTree无节点");
            return;
        }

        if (index > maxIndex) return;

        DungeonNode DungeonNode = new DungeonNode(index, level, rect);
        nodes.Add(DungeonNode);

        float offset = rect.width * Mathf.Pow(2, maxLevel - level - 1);

        int leftIndex = 2 * index + 1;
        CreateAllNodes(leftIndex, level + 1, maxLevel, new Rect(rect.x - offset, rect.y - rect.height - 4, rect.width, rect.height), nodes);

        int rightIndex = 2 * index + 2;
        CreateAllNodes(rightIndex, level + 1, maxLevel, new Rect(rect.x + offset, rect.y - rect.height - 4, rect.width, rect.height), nodes);
    }

    private void DivideRect(DungeonNode node, int minSize, List<DungeonNode> nodes)
    {
        if (node.index > maxIndex) maxIndex = node.index;

        Rect rect = node.rect;

        if (rect.width / 2 < minSize && rect.height / 2 < minSize)
        {
            node.BuildRoom();
            nodes.Add(node);
            return;
        }

        bool isSplitHorizontal = ChooseSplitDirection(rect);

        int index = node.index;
        int level = node.level;

        if (isSplitHorizontal)
        {
            int split = (int)Random.Range(minSize, rect.width - minSize);

            int leftIndex = 2 * index + 1;
            node.left = new DungeonNode(leftIndex, level + 1, new Rect(rect.x, rect.y, split, rect.height));
            DivideRect(node.left, minSize, nodes);

            int rightIndex = 2 * index + 2;
            node.right = new DungeonNode(rightIndex, level + 1, new Rect(rect.x + split, rect.y, rect.width - split, rect.height));
            DivideRect(node.right, minSize, nodes);
        }
        else
        {
            int split = (int)Random.Range(minSize, rect.height - minSize);

            int leftIndex = 2 * index + 1;
            node.left = new DungeonNode(leftIndex, level + 1, new Rect(rect.x, rect.y, rect.width, split));
            DivideRect(node.left, minSize, nodes);

            int rightIndex = 2 * index + 2;
            node.right = new DungeonNode(rightIndex, level + 1, new Rect(rect.x, rect.y + split, rect.width, rect.height - split));
            DivideRect(node.right, minSize, nodes);
        }
    }

    // 根据矩形宽高比选择拆分方向
    private bool ChooseSplitDirection(Rect rect)
    {
        if (rect.width / rect.height >= 1.25) return true;
        else if (rect.height / rect.width >= 1.25) return false;
        else return Random.Range(0.0f, 1.0f) > 0.5f;
    }
}
