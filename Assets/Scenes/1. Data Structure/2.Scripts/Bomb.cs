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

    //원하는 타이밍에 폭파 효과
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);

        BombForce();
    }
    private void BombForce()
    {
        //자신을 기준으로 bombRange 범위에서 걸리는 layer들의 Collider를 배열로 저장
        Collider[] colliders = Physics.OverlapSphere(transform.position, 10f, layerMask);

        foreach (Collider collider in colliders) 
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();

            // 폭발 파워, 폭발 위치, 폭발 범위, 폭발 높이
            rb.AddExplosionForce(500f, transform.position, bombRange, 1f);
        
        
        }
        Destroy(gameObject);

    }
}
