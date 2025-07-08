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
        Debug.Log(intStack.Pop()); //stack���� �ε��� ����� ����.

        Debug.Log(intStack.Peek()); //�� ������ ���� ����� Ȯ��, �ٽ� �÷�����

        intStack = new Stack<int>(array); //array�� Stack���� ��ȯ

        array2 = intStack.ToArray();
    }
}
