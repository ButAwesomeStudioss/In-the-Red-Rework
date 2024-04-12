using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private int _width, _height;

    [SerializeField] private TIle _TilePrefab;


    void Start()
    {
        GenerateGrid();
        
    }



    void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var spawntile = Instantiate(_TilePrefab, new Vector3(x, y), Quaternion.identity);
                spawntile.name = $"tile {x} {y}";


            }


        }
        
    }
       
}
