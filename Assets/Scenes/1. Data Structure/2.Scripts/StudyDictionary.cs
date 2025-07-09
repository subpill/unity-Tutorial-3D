using System.Collections.Generic;
using UnityEngine;
public class PersonData
{
    public int age;
    public string name;
    public float height;
    public float weight;
    public PersonData(int age, string name, float height, float weight)
    {
        this.age = age;
        this.name = name;
        this.height = height;
        this.weight = weight;
    }
}
public class StudyDictionary : MonoBehaviour
{
    public Dictionary<string, int> persons = new Dictionary<string, int>();
    void Start()
    {
        //key: �ٽ� �� (�ߺ� X) - �ߺ��� �����, ��� ��: ��(�ߺ� O)
        persons.Add("�����", 8);
        persons.Add("�����", 1);
        persons.Add("�����", 31);

        int age = persons["�����"];
        Debug.Log($"ö���� ���̴� {age}�Դϴ�.");

        foreach (var person in persons)
        {
            if (person.Value == 31)
            {
                Debug.Log($"���̰� 31�� ����� �̸��� {person.Key}�Դϴ�.");
            }
            Debug.Log($"{person.Key}�� ���̴� {person.Value}�Դϴ�.");
        }

        if (persons.ContainsKey("�����"))
            Debug.Log("����߿� ������� ����");
    }
}
