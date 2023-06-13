using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryNode<T>
{
    public int index;
    public int level;
    
    public T left, right;    

    public BinaryNode(int index, int level)
    {
        this.index = index;
        this.level = level;
    }
}
