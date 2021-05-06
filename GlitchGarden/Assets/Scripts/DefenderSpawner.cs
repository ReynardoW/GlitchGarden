using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown()
    {
        //Debug.Log("Mouse was clicked");
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);
        return SnapToGrid(worldPosition);
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        Vector2 snappedWorldPos = new Vector2(newX, newY);
        return snappedWorldPos;
    }

    private void SpawnDefender(Vector2 roundedPos)
    {
        GameObject newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as GameObject;
    }
}
