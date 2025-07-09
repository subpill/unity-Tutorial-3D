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
        //key: 핵심 값 (중복 X) - 중복시 덮어쓰기, 밸류 값: 값(중복 O)
        persons.Add("배숙희", 8);
        persons.Add("나빈순", 1);
        persons.Add("설희원", 31);

        int age = persons["배숙희"];
        Debug.Log($"철수의 나이는 {age}입니다.");

        foreach (var person in persons)
        {
            if (person.Value == 31)
            {
                Debug.Log($"나이가 31인 사람의 이름은 {person.Key}입니다.");
            }
            Debug.Log($"{person.Key}의 나이는 {person.Value}입니다.");
        }

        if (persons.ContainsKey("나빈순"))
            Debug.Log("사람중에 나빈순이 있음");
    }
}
