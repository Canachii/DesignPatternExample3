using UnityEngine;

public class MathPendulum : MonoBehaviour
{
    public float angle; // 각도 표현

    private float time = 0; // 시간
    private float speed = 2.0f; // 속도

    private void Update()
    {
        time += Time.deltaTime * speed;
        transform.rotation = MovePendulum();
        // 설정한 각도로 z축이 1부터 -1까지 이동하는 작업이 반복될 것 입니다.
    }
    
    // 진자 운동에 대한 함수 구현
    Quaternion MovePendulum()
    {
        return Quaternion.Lerp(Quaternion.Euler(Vector3.forward * angle), Quaternion.Euler(Vector3.back * angle), LerpT());
    }

    // Lerp(a,b,t) 함수의 t의 값을 계산하는 함수입니다.
    // Lerp는 a 지점에서 b 지점까지 부드럽게 이동하며 t 간격으로 이동하게 됩니다.
    float LerpT() => (Mathf.Sin(time) + 1) * 0.5f;
}
