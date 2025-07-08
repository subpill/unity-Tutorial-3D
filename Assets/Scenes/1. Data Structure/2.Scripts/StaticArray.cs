using UnityEngine;

public class StaticArray : MonoBehaviour
{
    public int[] array1; //배열 선언
    public int[] array2 = { 1, 2, 3, 4, 5 }; //배열 선언과 초기화
    public int[] array3 = new int[5]; //배열 선언과 공간 할당
    public int[] array4 = new int[5] { 1, 2, 3, 4, 5 };
    //배열 선언과 공간 할당, 초기화
    void Start()
    {
        array1 = new int[5]; //배열 공간 할당
    }
}
