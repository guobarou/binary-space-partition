using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Wall
{
    public static byte innerLeft = 0b11100000;
    public static byte innerRight = 0b10000011;

    public static byte top = 0b00001000;
    public static byte bottom = 0b10000000;
    public static byte left = 0b00100000;
    public static byte right = 0b00000010;

    public static byte topLeft = 0b00010000;
    public static byte topRight = 0b00000100;
    public static byte bottomLeft = 0b01000000;
    public static byte bottomRight = 0b00000001;
}

public class Direction2D
{
    //public static List<Vector2Int> cardinalDirectionsList = new List<Vector2Int>
    //{
    //    new Vector2Int(0,1), //UP
    //    new Vector2Int(1,0), //RIGHT
    //    new Vector2Int(0, -1), // DOWN
    //    new Vector2Int(-1, 0) //LEFT
    //};

    public static List<Vector2Int> diagonalDirectionsList = new List<Vector2Int>
    {
        new Vector2Int(1,1), //UP-RIGHT
        new Vector2Int(1,-1), //RIGHT-DOWN
        new Vector2Int(-1, -1), // DOWN-LEFT
        new Vector2Int(-1, 1) //LEFT-UP
    };

    public static List<Vector2Int> eightDirectionsList = new List<Vector2Int>
    {
        new Vector2Int(0,1), //UP
        new Vector2Int(1,1), //UP-RIGHT
        new Vector2Int(1,0), //RIGHT
        new Vector2Int(1,-1), //RIGHT-DOWN
        new Vector2Int(0, -1), // DOWN
        new Vector2Int(-1, -1), // DOWN-LEFT
        new Vector2Int(-1, 0), //LEFT
        new Vector2Int(-1, 1) //LEFT-UP
    };
}

public class WallGenerator
{
    public static Dictionary<Vector2Int, byte> GetWallsInDirections(HashSet<Vector2Int> floors, List<Vector2Int> directionList)
    {
        Dictionary<Vector2Int, byte> walls = new Dictionary<Vector2Int, byte>();

        foreach (Vector2Int position in floors)
        {
            foreach (Vector2Int direction in directionList)
            {
                Vector2Int neighbourPosition = position + direction;
                if (floors.Contains(neighbourPosition) == false)
                {
                    string byteStr = CreateByteString(neighbourPosition, floors);
                    byte byteWall = Convert.ToByte(byteStr, 2);
                    walls[neighbourPosition] = byteWall;
                }                    
            }
        }
        return walls;
    }

    private static string CreateByteString(Vector2Int position, HashSet<Vector2Int> floors)
    {
        string byteStr = "";
        foreach (var direction in Direction2D.eightDirectionsList)
        {
            var neighbourPosition = position + direction;
            if (floors.Contains(neighbourPosition))
            {
                byteStr += "1";
            }
            else
            {
                byteStr += "0";
            }
        }
        return byteStr;
    }
}
