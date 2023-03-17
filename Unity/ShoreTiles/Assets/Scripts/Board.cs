using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    //LOGIC
    private const int TILE_COUNT_X = 6;
    private const int TILE_COUNT_Y = 6;
    private GameObject[,] tiles;

    private void Awake()
    {
        GenerateAllTiles(1,8,8);
    }


    private void GenerateAllTiles(float tileSize, int tileCountX, int tileCountY)
    {
        tiles = new GameObject[tileCountX, tileCountY];
        for ()
    }
}
