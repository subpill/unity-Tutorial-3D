using System.Collections.Generic;
using UnityEngine;

public class StudyStack : MonoBehaviour
{
    public Stack<int> intStack = new Stack<int>();

    public int[] array = new int[3] { 1, 2, 3 };
    public int[] array2;

    private void Start()
    {
        for(int i=1; i<=10; i++)
        {
            intStack.Push(i);
        }
        Debug.Log(intStack.Pop()); //stack에는 인덱스 기능이 없다.

        Debug.Log(intStack.Peek()); //그 다음에 뽑힐 대상을 확인, 다시 올려놓음

        intStack = new Stack<int>(array); //array를 Stack으로 변환

        array2 = intStack.ToArray();
    }
}
