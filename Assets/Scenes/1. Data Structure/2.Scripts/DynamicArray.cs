using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    public List<int> list1 = new List<int>();
    public List<int> list2 = new List<int>() { 1, 2, 3, 4 };
    public List<int> list3;
    // priavte�� ���� new List�� �������
    // public�� ���� Inspectorâ���� ���� �����ؼ� ����
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            list1.Add(i);
        }

        list2.Add(20);

        list3.Add(30);


        list1.Remove(10); //�� 10�� ����

        list1.RemoveAt(0); //0���� �ִ� �� ����

        list1.RemoveRange(1, 3); //�ε��� 1~3�� �ִ� �� ����

        list1.Clear(); //������ ��� ����

        list1.RemoveAll(x => x > 5); //���� List�ȿ��� x > 5�� ���� ��� ����

        list1.Sort(); //�������� ����


        string str = string.Empty;

        foreach (var x in list1)
        {
            str += x.ToString() + " / ";
            Debug.Log(x);
        }
        Debug.Log(str);

        if (list1.Contains(10))
            Debug.Log("list1�� 10�� ����");
    }

}
