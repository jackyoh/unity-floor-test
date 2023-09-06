using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TestTileMap : MonoBehaviour {
    public TileBase tileToPlace;
    public TileBase wallToPlace;
    public TileBase leftWallToPlace;
    public TileBase middleWallToPlace;
    public TileBase rightWallToPlace;
    public TileBase right1WallToPlace;
    public TileBase floorRightToPlace;


    private Tilemap tilemap;
    private int count = 0;
    private List<List<Vector3Int>> floorTileMap = new List<List<Vector3Int>>();

    void Start() {
        List<Vector3Int> levelOneRow = new List<Vector3Int>();
        levelOneRow.Add(new Vector3Int(5, 2, 0));
        levelOneRow.Add(new Vector3Int(4, 1, 0));
        levelOneRow.Add(new Vector3Int(4, 0, 0));
        levelOneRow.Add(new Vector3Int(3, -1, 0));
        levelOneRow.Add(new Vector3Int(3, -2, 0));
        levelOneRow.Add(new Vector3Int(2, -3, 0));
        levelOneRow.Add(new Vector3Int(2, -4, 0));
        floorTileMap.Add(levelOneRow);

        List<Vector3Int> levelOneCol = new List<Vector3Int>();
        levelOneCol.Add(new Vector3Int(5, 3, 0));
        levelOneCol.Add(new Vector3Int(5, 4, 0));
        levelOneCol.Add(new Vector3Int(4, 5, 0));
        levelOneCol.Add(new Vector3Int(4, 6, 0));
        levelOneCol.Add(new Vector3Int(3, 7, 0));
        levelOneCol.Add(new Vector3Int(3, 8, 0));
        levelOneCol.Add(new Vector3Int(2, 9, 0));
        levelOneCol.Add(new Vector3Int(2, 10, 0));
        floorTileMap.Add(levelOneCol);


        List<Vector3Int> levelTwoRow = new List<Vector3Int>();
        levelTwoRow.Add(new Vector3Int(6, 2, 0));
        levelTwoRow.Add(new Vector3Int(5, 1, 0));
        levelTwoRow.Add(new Vector3Int(5, 0, 0));
        levelTwoRow.Add(new Vector3Int(4, -1, 0));
        levelTwoRow.Add(new Vector3Int(4, -2, 0));
        levelTwoRow.Add(new Vector3Int(3, -3, 0));
        levelTwoRow.Add(new Vector3Int(3, -4, 0));
        levelTwoRow.Add(new Vector3Int(2, -5, 0));
        floorTileMap.Add(levelTwoRow);

        List<Vector3Int> levelTwoCol = new List<Vector3Int>();
        levelTwoCol.Add(new Vector3Int(6, 3, 0));
        levelTwoCol.Add(new Vector3Int(6, 4, 0));
        levelTwoCol.Add(new Vector3Int(5, 5, 0));
        levelTwoCol.Add(new Vector3Int(5, 6, 0));
        levelTwoCol.Add(new Vector3Int(4, 7, 0));
        levelTwoCol.Add(new Vector3Int(4, 8, 0));
        levelTwoCol.Add(new Vector3Int(3, 9, 0));
        levelTwoCol.Add(new Vector3Int(3, 10, 0));
        levelTwoCol.Add(new Vector3Int(2, 11, 0));
        floorTileMap.Add(levelTwoCol);


        List<Vector3Int> levelThreeRow = new List<Vector3Int>();
        levelThreeRow.Add(new Vector3Int(7, 2, 0));
        levelThreeRow.Add(new Vector3Int(6, 1, 0));
        levelThreeRow.Add(new Vector3Int(6, 0, 0));
        levelThreeRow.Add(new Vector3Int(5, -1, 0));
        levelThreeRow.Add(new Vector3Int(5, -2, 0));
        levelThreeRow.Add(new Vector3Int(4, -3, 0));
        levelThreeRow.Add(new Vector3Int(4, -4, 0));
        levelThreeRow.Add(new Vector3Int(3, -5, 0));
        levelThreeRow.Add(new Vector3Int(3, -6, 0));
        floorTileMap.Add(levelThreeRow);

        List<Vector3Int> levelThreeCol = new List<Vector3Int>();
        levelThreeCol.Add(new Vector3Int(7, 3, 0));
        levelThreeCol.Add(new Vector3Int(7, 4, 0));
        levelThreeCol.Add(new Vector3Int(6, 5, 0));
        levelThreeCol.Add(new Vector3Int(6, 6, 0));
        levelThreeCol.Add(new Vector3Int(5, 7, 0));
        levelThreeCol.Add(new Vector3Int(5, 8, 0));
        levelThreeCol.Add(new Vector3Int(4, 9, 0));
        levelThreeCol.Add(new Vector3Int(4, 10, 0));
        levelThreeCol.Add(new Vector3Int(3, 11, 0));
        levelThreeCol.Add(new Vector3Int(3, 12, 0));
        floorTileMap.Add(levelThreeCol);


        List<Vector3Int> levelFourRow = new List<Vector3Int>();
        levelFourRow.Add(new Vector3Int(8, 2, 0));
        levelFourRow.Add(new Vector3Int(7, 1, 0));
        levelFourRow.Add(new Vector3Int(7, 0, 0));
        levelFourRow.Add(new Vector3Int(6, -1, 0));
        levelFourRow.Add(new Vector3Int(6, -2, 0));
        levelFourRow.Add(new Vector3Int(5, -3, 0));
        levelFourRow.Add(new Vector3Int(5, -4, 0));
        levelFourRow.Add(new Vector3Int(4, -5, 0));
        levelFourRow.Add(new Vector3Int(4, -6, 0));
        levelFourRow.Add(new Vector3Int(3, -7, 0));
        floorTileMap.Add(levelFourRow);

        List<Vector3Int> levelFourCol = new List<Vector3Int>();
        levelFourCol.Add(new Vector3Int(7, 2, 0));
        levelFourCol.Add(new Vector3Int(7, 1, 0));
        levelFourCol.Add(new Vector3Int(6, 0, 0));
        levelFourCol.Add(new Vector3Int(6, -1, 0));
        levelFourCol.Add(new Vector3Int(5, -2, 0));
        levelFourCol.Add(new Vector3Int(5, -3, 0));
        levelFourCol.Add(new Vector3Int(4, -4, 0));
        levelFourCol.Add(new Vector3Int(4, -5, 0));
        levelFourCol.Add(new Vector3Int(3, -6, 0));
        levelFourCol.Add(new Vector3Int(3, -7, 0));
        floorTileMap.Add(levelFourCol);


        tilemap = GetComponent<Tilemap>();
        StartCoroutine(CheckInitialization());
    }

    public void AddFloor() {
        if (count < floorTileMap.Count) {
            List<Vector3Int> levelRows = floorTileMap[count];
            for (int i = 0 ; i < levelRows.Count ; i++) {
                tilemap.SetTile(levelRows[i], tileToPlace);
            }
            count += 1;
        }
    }

    private IEnumerator CheckInitialization() {
        yield return new WaitForSeconds(1f);
        int []x = {1, 2, 2, 3, 3, 4, 4};
        for (int k = 0 ; k < x.Length ; k++) {
            int i = x[k];
            for (int j = -3 + k ; j <= 3 + k ; j++) {
                Vector3Int tilePosition = new Vector3Int(i, j, 0);
                tilemap.SetTile(tilePosition, tileToPlace);
                if ((j % 2) == 0) {
                    i = i - 1;
                }
            }
        }
        Vector3Int wallLeftPosition = new Vector3Int(3, -3, 0);
        tilemap.SetTile(wallLeftPosition, wallToPlace);

        Vector3Int wallLeft1Position = new Vector3Int(4, -2, 0);
        tilemap.SetTile(wallLeft1Position, leftWallToPlace);

        wallLeft1Position = new Vector3Int(4, -1, 0);
        tilemap.SetTile(wallLeft1Position, leftWallToPlace);

        wallLeft1Position = new Vector3Int(5, 0, 0);
        tilemap.SetTile(wallLeft1Position, leftWallToPlace);

        wallLeft1Position = new Vector3Int(5, 1, 0);
        tilemap.SetTile(wallLeft1Position, leftWallToPlace);

        wallLeft1Position = new Vector3Int(6, 2, 0);
        tilemap.SetTile(wallLeft1Position, leftWallToPlace);

        wallLeft1Position = new Vector3Int(6, 3, 0);
        tilemap.SetTile(wallLeft1Position, leftWallToPlace);

        Vector3Int wallMiddlePosition = new Vector3Int(6, 3, 0);
        tilemap.SetTile(wallMiddlePosition, middleWallToPlace);

        Vector3Int wallRightPosition = new Vector3Int(6, 4, 0);
        tilemap.SetTile(wallRightPosition, rightWallToPlace);

        wallRightPosition = new Vector3Int(5, 5, 0);
        tilemap.SetTile(wallRightPosition, rightWallToPlace);

        wallRightPosition = new Vector3Int(5, 6, 0);
        tilemap.SetTile(wallRightPosition, rightWallToPlace);

        wallRightPosition = new Vector3Int(4, 7, 0);
        tilemap.SetTile(wallRightPosition, rightWallToPlace);

        wallRightPosition = new Vector3Int(4, 8, 0);
        tilemap.SetTile(wallRightPosition, rightWallToPlace);

        wallRightPosition = new Vector3Int(3, 9, 0);
        tilemap.SetTile(wallRightPosition, rightWallToPlace);

        Vector3Int wallRight1Position = new Vector3Int(3, 9, 0);
        tilemap.SetTile(wallRight1Position, right1WallToPlace);

        Vector3Int floorRightPosition = new Vector3Int(1, 8, 0);
        tilemap.SetTile(floorRightPosition, floorRightToPlace);

        floorRightPosition = new Vector3Int(0, 7, 0);
        tilemap.SetTile(floorRightPosition, floorRightToPlace);

        floorRightPosition = new Vector3Int(0, 6, 0);
        tilemap.SetTile(floorRightPosition, floorRightToPlace);

        floorRightPosition = new Vector3Int(-1, 5, 0);
        tilemap.SetTile(floorRightPosition, floorRightToPlace);

        floorRightPosition = new Vector3Int(-1, 4, 0);
        tilemap.SetTile(floorRightPosition, floorRightToPlace);

        floorRightPosition = new Vector3Int(-2, 3, 0);
        tilemap.SetTile(floorRightPosition, floorRightToPlace);
    }
}
