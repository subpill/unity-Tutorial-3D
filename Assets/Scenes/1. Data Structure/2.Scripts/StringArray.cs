using UnityEngine;

public class StringArray : MonoBehaviour
{
    string str = string.Empty;

    public string str1 = " Hello World *";

    public string str2 = "Apple,Banana,Orange";
    void Start()
    {
        Debug.Log(str1);

        Debug.Log(str1.Trim());

        // �յ� ���� ���� ()�� ���� ������ * ����
        str = str1.Trim('*');
        Debug.Log(str);

        Debug.Log(str1.Replace("Hello", "Bye"));

        string[] fruits = str2.Split(',');
        foreach (string fruit in fruits)
            Debug.Log(fruit);
    }
}
