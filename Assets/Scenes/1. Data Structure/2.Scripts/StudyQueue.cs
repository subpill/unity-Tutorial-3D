using System.Collections.Generic;
using UnityEngine;

public class StudyQueue : MonoBehaviour
{
    public Queue<int> queue = new Queue<int>();
    private void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            queue.Enqueue(i); // 1 ~ 10까지 추가
        }
        Debug.Log(queue.Contains(1));
        
        int output = queue.Dequeue(); //값을 뽑음

        Debug.Log(output);
        Debug.Log(queue.Peek()); //그 다음에 뽑을 값을 확인

        queue.Clear();
    }
}
