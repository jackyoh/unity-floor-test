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
    private int rightCount = 7;
    private int leftCount = -5;

    private Tilemap tilemap;
    private int count = 1;
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
        floorTileMap.Add(levelFourCol);int leftCount = -5;


        tilemap = GetComponent<Tilemap>();
        StartCoroutine(CheckInitialization());
    }

    public void AddFloor() {

        int xPosition = 3;
        for (int i = 0 ; i < count ; i++) {
            if (i % 2 == 0) {
                xPosition += 1;
            }
            int xCount = xPosition;
            int leftStart = (leftCount + (rightCount - 1) - 1) + i;
            int yCount = 0 - i;
            for (int j = leftStart ; j < rightCount + i ; j++) {
                Vector3Int wallLeftPosition = new Vector3Int(xCount, yCount, 0);
                //Debug.Log("(" + xCount + "," + yCount + ")");
                tilemap.SetTile(wallLeftPosition, tileToPlace);
                if (j % 2 == 0) {
                    xCount -= 1;
                }
                yCount -= 1;
            }
        }

        count = count + 1;

    }

    private IEnumerator CheckInitialization() {
        yield return new WaitForSeconds(1f);
        int xxCount = -1;
        int tempXCount = 0;
        for (int i = 0 ; i < rightCount ; i++) {
            int xCount = xxCount; // 右上延伸
            for (int y = 3 + i ; y >= leftCount + i ; y--) { // 右下到左上
                Vector3Int wallLeftPosition = new Vector3Int(xCount, y, 0);
                tempXCount = xCount;
                tilemap.SetTile(wallLeftPosition, tileToPlace);
                if (Mathf.Abs(y) % 2 == 1) {
                    xCount += 1;
                }
                
            }
            if (Mathf.Abs(i) % 2 == 0) {
                xxCount += 1;
            }
        }
        int wallLeftxCount = tempXCount + 3;
        int wallLeftyCount = leftCount + rightCount - 1;

        for (int i = 0 ; i < rightCount ; i++) {
            if ( Mathf.Abs(i) % 2 == 0 ) {
                wallLeftxCount -= 1;
            }
            Vector3Int wallLeft1Position = new Vector3Int(wallLeftxCount, wallLeftyCount);
            if (i == 0) {
                tilemap.SetTile(wallLeft1Position, middleWallToPlace);
            } else if (i == (rightCount - 1)) {
                tilemap.SetTile(wallLeft1Position, wallToPlace);
            } else {
                tilemap.SetTile(wallLeft1Position, leftWallToPlace);
            }
            wallLeftyCount -= 1;
        }
        int wallRightXCount = tempXCount + 3 - 1;
        int wallRightYCount = leftCount + rightCount;
        int oneLeftCellCount = Mathf.Abs(leftCount) + 3 + 1;

        for (int i = 0 ; i < oneLeftCellCount - 1 ; i++) {
            if (Mathf.Abs(i) % 2 == 1) {
                wallRightXCount -= 1;
            }

            Vector3Int wallRight1Position = new Vector3Int(wallRightXCount, wallRightYCount);
            if (i == (oneLeftCellCount - 2)) {
                tilemap.SetTile(wallRight1Position, right1WallToPlace);
            } else {
                tilemap.SetTile(wallRight1Position, rightWallToPlace);
            }
            wallRightYCount += 1;
        }
    }
}
