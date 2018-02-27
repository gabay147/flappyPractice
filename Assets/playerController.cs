using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private Rigidbody2D _rb;
    private CircleCollider2D _col;

    public float jumpPow;
    public int timer;
    public float curVel;
    public float maxVel;
    private int count;

	// Use this for initialization
	void Start () {
        _rb = GetComponent<Rigidbody2D>();
        _col = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float input = Input.GetAxis("Fire1");
        curVel = _rb.velocity.y;
        if (input > 0 && count > timer * Time.deltaTime && _rb.velocity.y < maxVel)
        {
            count = 0;
            jump();
        }
        count++;
	}

    private void jump()
    {
        _rb.AddForce(new Vector2(0, jumpPow), ForceMode2D.Impulse);
    }
}
