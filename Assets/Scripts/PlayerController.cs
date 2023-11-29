using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
Rigidbody2D _rb;
Animator _anim;
GameManager _gm;
[SerializeField] private float _velocidad;
[SerializeField] private float _fSalto;
private float _inputMovimiento;


    void Awake()
    {   
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
        _gm = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") && GroundSensor._groundSensor == true)
        {
            Salto();
        }
        _anim.SetBool("isJumping", !GroundSensor._groundSensor);
    }

    void FixedUpdate()
    {
        Movimiento();
    }

    void Movimiento()
    { 
        _inputMovimiento = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2 (_inputMovimiento*_velocidad, _rb.velocity.y);
        if(_inputMovimiento > 0)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            _anim.SetBool("isRunning", true);
        } else if (_inputMovimiento < 0)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
            _anim.SetBool("isRunning", true);
        }else{
            _anim.SetBool("isRunning", false);
        }
        
    }

    void Salto()
    {
        _rb.AddForce(Vector2.up*_fSalto, ForceMode2D.Impulse);   
    }

    
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
            _gm.Win();
        }

        if(other.gameObject.tag == "Coin")
        {
            _gm._coin++;
        }
    }
}
