using UnityEngine;

public class StaticArray : MonoBehaviour
{
    public int[] array1; //�迭 ����
    public int[] array2 = { 1, 2, 3, 4, 5 }; //�迭 ����� �ʱ�ȭ
    public int[] array3 = new int[5]; //�迭 ����� ���� �Ҵ�
    public int[] array4 = new int[5] { 1, 2, 3, 4, 5 };
    //�迭 ����� ���� �Ҵ�, �ʱ�ȭ
    void Start()
    {
        array1 = new int[5]; //�迭 ���� �Ҵ�
    }
}
