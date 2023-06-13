using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryTree<T>
{
    public T root;
    public int maxIndex;

    public BinaryTree(T root)
    {
        this.root = root;
    }

    public int GetMaxLevel()
    {
        return Mathf.CeilToInt(Mathf.Log(maxIndex + 1, 2));
    }
}
