using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;

public class PaintVisualier : MonoBehaviour
{
    public static void PaintRect(Rect rect, GameObject original, Transform parent)
    {
        for (int x = (int)rect.x; x < rect.xMax; x++)
        {
            for (int y = (int)rect.y; y < rect.yMax; y++)
            {
                Instantiate(original, new Vector3(x, y, 0f), Quaternion.identity, parent);
            }
        }
    }

    public static void PaintRectNum(GameObject original, Vector3 postion, Transform parent, int depth)
    {
        GameObject num = Instantiate(original, postion, Quaternion.identity, parent);
        TextMeshProUGUI text = num.GetComponent<TextMeshProUGUI>();
        text.text = depth.ToString();
    }

    public static HashSet<Vector2Int> PaintRect(Rect rect, TileBase tileBase, Tilemap tileMap)
    {
        HashSet<Vector2Int> tiles = new HashSet<Vector2Int>();

        for (int x = (int)rect.x; x < rect.xMax; x++)
        {
            for (int y = (int)rect.y; y < rect.yMax; y++)
            {
                tiles.Add(new Vector2Int(x, y));
                //GameObject floor = Instantiate(original, new Vector3(i, j, 0f), Quaternion.identity, parent);
                tileMap.SetTile(new Vector3Int(x, y, 0), tileBase);
            }
        }
        return tiles;
    }

    public static void PaintTiles(HashSet<Vector2Int> positions, TileBase tileBase, Tilemap tileMap)
    {
        foreach (Vector2Int position in positions)
        {
            tileMap.SetTile(new Vector3Int(position.x, position.y, 0), tileBase);
        }
    }

    public static void PaintTile(Vector3Int position, TileBase tileBase, Tilemap tileMap)
    {
        tileMap.SetTile(position, tileBase);
    }
}
