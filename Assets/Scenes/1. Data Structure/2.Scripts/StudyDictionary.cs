using System.Collections.Generic;
using UnityEngine;

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
