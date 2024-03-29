using UnityEngine;

public class Farmer : MonoBehaviour
{
    public float speed = 3f;
    public KeyCode interact = KeyCode.E;

    private Animator _animator;
    private FarmerCollider _collider;
    private Rigidbody2D _rigidbody;

    private float _x;
    private float _y;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _collider = GetComponentInChildren<FarmerCollider>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        Interact();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_x, _y).normalized * speed;
    }

    private void Move()
    {
        _x = Input.GetAxisRaw("Horizontal");
        _y = Input.GetAxisRaw("Vertical");

        _animator.SetFloat("Horizontal", _x);
        _animator.SetFloat("Vertical", _y);
        _animator.speed = _rigidbody.velocity == Vector2.zero ? 0 : 1;
    }

    private void Interact()
    {
        if (Input.GetKeyDown(interact))
        {
            if (_collider.IsTouch && _collider.IsExist)
            {
                Debug.Log("Touch " + _collider.Thing);
                // Sell();
            }
            else if (_collider.IsTouch)
            {
                GameManager.instance.Gold += 100;
                // Plant();
            }
        }
    }
}