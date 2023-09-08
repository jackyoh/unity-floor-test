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
    private int rightCount = 3;
    private int leftCount = -5;

    private Tilemap tilemap;
    private int count = 1;
    private List<List<Vector3Int>> floorTileMap = new List<List<Vector3Int>>();

    void Start() {
        tilemap = GetComponent<Tilemap>();
        StartCoroutine(CheckInitialization());
    }

    public void AddFloor() {
        Debug.Log("Test....................");

    }

    private IEnumerator CheckInitialization() {
        yield return new WaitForSeconds(1f);
        int xxCount = -1;
        int tempXCount = 0;
        int tempXXCount = 0;
        int initYValue = 3;
        for (int i = 0 ; i < rightCount ; i++) {
            int xCount = xxCount; // 右上延伸
            for (int y = 3 + i ; y >= leftCount + i ; y--) { // 右下到左上
                Debug.Log("(" + xCount + "," + y + ")");
                Vector3Int wallLeftPosition = new Vector3Int(xCount, y, 0);
                tempXCount = xCount;
                tilemap.SetTile(wallLeftPosition, tileToPlace);
                if (Mathf.Abs(y) % 2 == 1) {
                    xCount += 1;
                }
                
            }
            tempXXCount = xxCount;
            if (Mathf.Abs(i) % 2 == 0) {
                xxCount += 1;
            }
        }
        tilemap.SetTile(new Vector3Int(tempXXCount, (3 + (rightCount - 1))), null);

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
