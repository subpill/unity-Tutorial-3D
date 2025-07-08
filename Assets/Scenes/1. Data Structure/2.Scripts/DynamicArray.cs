using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    public List<int> list1 = new List<int>();
    public List<int> list2 = new List<int>() { 1, 2, 3, 4 };
    public List<int> list3;
    // priavte을 쓰면 new List를 적어야함
    // public을 쓰면 Inspector창에서 변경 가능해서 ㄱㅊ
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            list1.Add(i);
        }

        list2.Add(20);

        list3.Add(30);


        list1.Remove(10); //값 10을 제거

        list1.RemoveAt(0); //0번에 있는 값 제거

        list1.RemoveRange(1, 3); //인덱스 1~3에 있는 값 제거

        list1.Clear(); //데이터 모두 제거

        list1.RemoveAll(x => x > 5); //현재 List안에서 x > 5인 값은 모두 제거

        list1.Sort(); //오름차순 정렬


        string str = string.Empty;

        foreach (var x in list1)
        {
            str += x.ToString() + " / ";
            Debug.Log(x);
        }
        Debug.Log(str);

        if (list1.Contains(10))
            Debug.Log("list1에 10이 존재");
    }

}
