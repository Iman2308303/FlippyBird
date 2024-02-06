using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalVelocityRotater : MonoBehaviour
{
    public float RotateDown = -20f;
    public float RotateUp = 60f;

    private Ghost _player;

    private float _currentY;
    private float _lasty;

    public float _velocity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _player = transform.parent.GetComponent<Ghost>();
        _currentY = _lasty = transform.parent.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_player == null)
            return;

        _currentY = _player.transform.position.y;

        _velocity = _currentY - _lasty;

        _velocity *= 10f;
        _velocity = Mathf.Clamp(_velocity, min:-1, max:1);
        _velocity = Unity.Mathematics.math.remap(-1, 1, 0, 1, x: _velocity);

        transform.rotation = Quaternion.Lerp(a: Quaternion.Euler(x: 0, y: 0, z: RotateDown), b: Quaternion.Euler(x: 0, y: 0, z: RotateUp), _velocity);

        _lasty = _player.transform.position.y;
    }
}
