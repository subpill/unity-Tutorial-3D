using System.Collections;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private Rigidbody bombRb;
    public float bombTime = 4f;
    public float bombRange = 10f;
    public LayerMask layerMask;
    private void Awake()
    {
        bombRb = GetComponent<Rigidbody>();
    }

    //���ϴ� Ÿ�ֿ̹� ���� ȿ��
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);

        BombForce();
    }
    private void BombForce()
    {
        //�ڽ��� �������� bombRange �������� �ɸ��� layer���� Collider�� �迭�� ����
        Collider[] colliders = Physics.OverlapSphere(transform.position, 10f, layerMask);

        foreach (Collider collider in colliders) 
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();

            // ���� �Ŀ�, ���� ��ġ, ���� ����, ���� ����
            rb.AddExplosionForce(500f, transform.position, bombRange, 1f);
        
        
        }
        Destroy(gameObject);

    }
}
