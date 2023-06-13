using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.Tilemaps;

/**
 * @brief Depth First Search
 */
public class DungeonGenerator : MonoBehaviour
{

    public Rect rect;
    public int minSize;

    public GameObject floorPrefab;
    public GameObject corridorPrefab;
    public GameObject numPrefab;
    public Transform canvas;

    ////临时代码
    public GameObject floorVirtualPrefab;
    ////临时代码

    public Tilemap tilemapFloor;
    public TileBase tileBaseFloor;

    public Tilemap tilemapWall;
    public TileBase tileInnerLeftWall;
    public TileBase tileInnerRightWall;
    public TileBase tileTopWall;
    public TileBase tileBottomWall;
    public TileBase tileLeftWall;
    public TileBase tileRightWall;
    public TileBase tileTopLeftWall;
    public TileBase tileTopRightWall;
    public TileBase tileBottomLeftWall;
    public TileBase tileBottomRightWall;

    public void CreateDungeon()
    {
        DungeonTree tree = new DungeonTree(new DungeonNode(0, 1, rect));
        tree.finalNodes = tree.GetFinalNodes(minSize);

        //获取房间
        List<Rect> rooms = tree.finalNodes.Select(node => node.room).ToList();

        //for (int i = 0; i < tree.finalNodes.Count; i++)
        //{
        //    Rect rect = tree.finalNodes[i].room;
        //    PaintVisualier.PaintRect(rect, floorPrefab, transform);
        //    PaintVisualier.PaintRectNum(numPrefab, new Vector3(rect.x + rect.width / 2f - 0.5f, rect.y + rect.height / 2f - 0.5f, 0), canvas, i);//tree.finalNodes[i].index
        //}

        Dictionary<int, List<DungeonNode>> dicNodes = tree.finalNodes.GroupBy(node => node.index)
                     .ToDictionary(g => g.Key, g => g.ToList());

        ////临时代码 显示二叉树结构
        //List<DungeonNode> allNodes = tree.GetAllNodes();

        //for (int i = 0; i < allNodes.Count; i++)
        //{
        //    Rect rect = allNodes[i].rect;

        //    int index = allNodes[i].index;
        //    GameObject gameObject = dicNodes.ContainsKey(index) ? floorPrefab : floorVirtualPrefab;

        //    PaintVisualier.PaintRect(rect, gameObject, transform);
        //    PaintVisualier.PaintRectNum(numPrefab, new Vector3(rect.x + rect.width / 2f - 0.5f, rect.y + rect.height / 2f - 0.5f, 0), canvas, index);
        //}
        ////临时代码

        int maxLevel = tree.GetMaxLevel();
        //获取走廊
        List<Rect> corridors = new List<Rect>();
        CorridorGenerator.CreatCorridors(maxLevel - 1, dicNodes, corridors);
        List<Rect> rects = rooms.Concat(corridors).ToList();

        tilemapFloor.ClearAllTiles();
        HashSet<Vector2Int> floors = new HashSet<Vector2Int>();
        foreach (Rect rect in rects)
        {
            //PaintVisualier.PaintRect(rect, floorPrefab, transform);
            HashSet<Vector2Int> tiles = PaintVisualier.PaintRect(rect, tileBaseFloor, tilemapFloor);
            floors.UnionWith(tiles);
        }

        tilemapWall.ClearAllTiles();
        Dictionary<Vector2Int, byte> walls = WallGenerator.GetWallsInDirections(floors, Direction2D.diagonalDirectionsList);
        foreach (KeyValuePair<Vector2Int, byte> wall in walls)
        {
            TileBase tileBase = null;

            if ((wall.Value & Wall.innerLeft) == Wall.innerLeft)
            {
                tileBase = tileInnerLeftWall;
            }
            else if ((wall.Value & Wall.innerRight) == Wall.innerRight)
            {
                tileBase = tileInnerRightWall;
            }
            else if ((wall.Value & Wall.top) == Wall.top)
            {
                tileBase = tileTopWall;
            }
            else if ((wall.Value & Wall.bottom) == Wall.bottom)
            {
                tileBase = tileBottomWall;
            }
            else if ((wall.Value & Wall.left) == Wall.left)
            {
                tileBase = tileLeftWall;
            }
            else if ((wall.Value & Wall.right) == Wall.right)
            {
                tileBase = tileRightWall;
            }
            else if ((wall.Value & Wall.right) == Wall.right)
            {
                tileBase = tileRightWall;
            }
            else if ((wall.Value & Wall.right) == Wall.right)
            {
                tileBase = tileRightWall;
            }
            else if ((wall.Value & Wall.topLeft) == Wall.topLeft)
            {
                tileBase = tileTopLeftWall;
            }
            else if ((wall.Value & Wall.topRight) == Wall.topRight)
            {
                tileBase = tileTopRightWall;
            }
            else if ((wall.Value & Wall.bottomLeft) == Wall.bottomLeft)
            {
                tileBase = tileBottomLeftWall;
            }
            else if ((wall.Value & Wall.bottomRight) == Wall.bottomRight)
            {
                tileBase = tileBottomRightWall;
            }

            if (tileBase)
            {
                PaintVisualier.PaintTile(new Vector3Int(wall.Key.x, wall.Key.y, 0), tileBase, tilemapWall);
            }
        }
    }
}



