using System.Collections.Generic;
using UnityEngine;

public class BoardBar : MonoBehaviour
{
    public enum BarType { Left, Center, Right }
    public BarType barType;

    public Stack<GameObject> barStack = new Stack<GameObject>();

    void OnMouseDown() // Collider만 있으면 가능
    {
        if (!TowerSc.isSelected) // 선택이 안된 상태일 때
        {
            TowerSc.isSelected = true;
            TowerSc.selectedDonut = PopDonut();
        }
        else // 선택된 상태일 때
        {
            PushDonut(TowerSc.selectedDonut);
        }
    }

    public bool CheckDonut(GameObject donut)
    {
        if (barStack.Count > 0)
        {
            int pushNumber = donut.GetComponent<HanoiTower>().donutNumb;

            GameObject peekDonut = barStack.Peek();
            int peekNumber = peekDonut.GetComponent<HanoiTower>().donutNumb;

            if (pushNumber < peekNumber)
            {
                return true;
            }
            else
            {
                Debug.Log($"현재 넣으려는 도넛은 {pushNumber}이고, 해당 기둥의 제일 위의 도넛은 {peekNumber}입니다.");
                return false;
            }
        }

        return true;
    }

    public void PushDonut(GameObject donut)
    {
        if (!CheckDonut(donut))
            return;

        TowerSc.isSelected = false;
        TowerSc.selectedDonut = null;

        donut.transform.position = transform.position + Vector3.up * 5f;
        donut.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        donut.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        barStack.Push(donut); // Stack에 GameObject를 넣는 기능
    }

    public GameObject PopDonut()
    {
        GameObject donut = barStack.Pop(); // Stack에서 GameObject를 꺼내는 기능

        return donut; // 꺼낸 도넛을 반환
    }
}
