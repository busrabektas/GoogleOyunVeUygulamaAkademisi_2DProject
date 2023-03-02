using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D r2d;
    private Animator _animator;
    private Vector3 charPos;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject _camera;
    private int sayi;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();//caching spriterenderer
        r2d = GetComponent<Rigidbody2D>();//caching r2d
        _animator = GetComponent<Animator>();//caching anim
        charPos = transform.position;
    }

    //private void FixedUpdate()//50 kere çalýþýyor(1/0.02)
    //{
    //    r2d.velocity = new Vector2(speed, 0f);
    //}
    private void FixedUpdate()
    {
        sayi = 2;
    }

    void Update()
    {
        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal")*speed * Time.deltaTime), charPos.y);
        transform.position = charPos;//hesapladýðým pozisyon karakterime iþlensin
        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            _animator.SetFloat("speed", 0.0f);
        }
        else
        {
            _animator.SetFloat("speed", 1.0f);
        }

        if (Input.GetAxis("Horizontal") > 1.0f)
        {
            _spriteRenderer.flipX = false;
        }else if(Input.GetAxis("Horizontal") < -0.01f)
        {
            _spriteRenderer.flipX = true;
        }
        sayi = 3;
        Debug.Log("Update" + sayi);
    }
    private void LateUpdate()
    {
        // _camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z - 1.0f);
        sayi = 4;
    }
}
