using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportController : MonoBehaviour
{

    [SerializeField]
    private Image _charge;

    private Transform _player;



    // Start is called before the first frame update
    void Awake()
    {
        _player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        _charge.fillAmount += Time.deltaTime;
        if(_charge.fillAmount == 1)
        {
            this.enabled = false;
        }
    }


    void OnPointerExit()
    {
        //Debug.Log("Estoy dejando de mirar " + name);
        this.enabled = true;
    }
    
    void OnPointerEnter()
    {
        //Debug.Log("Estoy mirando a " + name);
        this.enabled = false;
    }

    void OnPointerStay()
    {
        //Debug.Log("Sigo mirando a " + name);
        _charge.fillAmount -= Time.deltaTime;

        if(_charge.fillAmount == 0)
        {
            _charge.fillAmount = 1;
            _player.position = transform.position;
        }



    }



}
