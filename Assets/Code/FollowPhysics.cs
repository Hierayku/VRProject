using UnityEngine;

public class FollowPhysics : MonoBehaviour
{
    
    [SerializeField] private Transform target;
    private Rigidbody _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rb.MovePosition(target.position);
    }
}
