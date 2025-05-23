using UnityEngine;

[ExecuteAlways]
public class HallwayScaler : MonoBehaviour
{
    [SerializeField] Transform leftWall;
    [SerializeField] Transform rightWall;
    [SerializeField] Transform topWall;
    [SerializeField] Transform bottomWall;

    [SerializeField] float wallThickness = 1f; // larghezza dei muri

    private void Update()
    {
        Vector3 scale = transform.localScale;

        if (leftWall != null)
        {
            leftWall.localPosition = new Vector3(-scale.x / 2f, 0, 0);
            leftWall.localScale = new Vector3(wallThickness, 1, 1);
        }

        if (rightWall != null)
        {
            rightWall.localPosition = new Vector3(scale.x / 2f, 0, 0);
            rightWall.localScale = new Vector3(wallThickness, 1, 1);
        }

        if (topWall != null)
        {
            topWall.localPosition = new Vector3(0, scale.y / 2f, 0);
            topWall.localScale = new Vector3(1, wallThickness, 1);
        }

        if (bottomWall != null)
        {
            bottomWall.localPosition = new Vector3(0, -scale.y / 2f, 0);
            bottomWall.localScale = new Vector3(1, wallThickness, 1);
        }
    }
}