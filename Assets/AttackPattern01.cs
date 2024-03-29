using UnityEngine;

public class AttackPattern01 : MonoBehaviour
{
    // 부채꼴 모양 발사 기능
    public GameObject bulletPrefab; // 총알 프리팹
    
    private void Update()
    {
        FireSector();
    }

    private int count = 0;

    private void FireSector()
    {
        var bullet = Instantiate(bulletPrefab); // 총알 생성 진행

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        Vector2 dir = new Vector2(Mathf.Cos(Mathf.PI * count), -1);
        rb.AddForce(dir.normalized * 3, ForceMode2D.Impulse);
        // normalized를 통해 정규화 진행
        // ForceMode2D.Impulse를 통해 순간적으로 힘을 가함.
        count++;
    }
}
