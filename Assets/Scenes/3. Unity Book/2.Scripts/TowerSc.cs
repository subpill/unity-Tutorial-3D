using System.Collections;
using UnityEngine;

public class TowerSc : MonoBehaviour
{
    public enum HanoiLevel { Lv1 = 3, Lv2, Lv3 }
    public HanoiLevel hanoiLevel;

    public GameObject[] donutPrefabs;
    public BoardBar[] bars; // L, C, R

    public static GameObject selectedDonut;
    public static bool isSelected;

    IEnumerator Start()
    {
        for (int i = (int)hanoiLevel - 1; i >= 0; i--) // �ݺ������� Level��ŭ ���� ����
        {
            GameObject donut = Instantiate(donutPrefabs[i]); // ���� ����
            donut.transform.position = new Vector3(-5f, 5f, 0); // ���� ���� ��ġ : ���� ����� + ����

            bars[0].PushDonut(donut); // ��� ������ ������ �ش� Bar�� Stack Push

            yield return new WaitForSeconds(1f); // ���������� ����
        }
    }
}
