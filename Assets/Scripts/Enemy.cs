using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;

    private Vector3 _direction;
    private bool _isInitialized;

    public void Init(Vector3 direction)
    {
        _direction = direction;
        _isInitialized = true;
    }

    private void Update()
    {
        if (_isInitialized == false)
            return;

        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
