using UnityEngine;

public class MultiDimensionalArray : MonoBehaviour
{
    int[,] array = new int[3, 3]; //3행 3렬을 가진, 2차원배열
    int[,,] array2 = new int[2, 3, 4]; //3차원 배열

    int[,] matrix = new int[3, 3];
    void Start()
    {
        matrix[1, 2] = 25;
        Debug.Log(matrix[1, 2]);
    }
}
