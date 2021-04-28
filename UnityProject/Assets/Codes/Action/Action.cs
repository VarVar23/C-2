using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public delegate void Delegate();
    public event Delegate Event;

    [SerializeField] private Light _light;
    [SerializeField] private GameObject _player;

    private Camera _myCamera;
    
    private void Awake()
    {
        _myCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Event += CameraFieldOfViewFast;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) Event += ChangeMaterial;
        else if (Input.GetKeyDown(KeyCode.Alpha3)) Event += DayColor;

        if (Input.GetKeyDown(KeyCode.Space)) Event?.Invoke();

        if (Input.GetMouseButtonDown(1)) MyReset();
        if (Input.GetMouseButtonDown(0))
        {
            Event -= DayColor;
            Event -= ChangeMaterial;
            Event -= CameraFieldOfViewFast;
            Debug.Log("Сработала отписка");
        }
    }

    private void MyReset()
    {
        _myCamera.fieldOfView = 60;
        _player.GetComponent<Renderer>().material.color = Color.white;
        _light.color = Color.white;
        Debug.Log("Сработал метод MyReset");
    }
    private void CameraFieldOfViewFast()
    {
        _myCamera.fieldOfView = 80;
        Debug.Log("Сработал метод CameraFieldOfViewFast");
    }

    private void ChangeMaterial()
    {
        _player.GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("Сработал метод ChangeMaterial");
    }

    private void DayColor()
    {
        _light.color = Color.red;
        Debug.Log("Сработал метод DayColor");
    }
}
