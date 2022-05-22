using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    PlayerControls controls;
    CharacterController characterController;
    public GameObject avatar;
    [Range(0.5f, 5f)]
    public float moveSpeed = 1f;
    [Range(0.5f, 5f)]
    public float rotationSpeed = 1f;

    private void Awake()
    {
        characterController = avatar.GetComponent<CharacterController>();
        controls = new PlayerControls();
    }

    void Update()
    {
        Debug.Log(controls.DesktopPlayer.Movement.ReadValue<Vector2>());
        headsetMove();
        desktopMove();
    }

    private void headsetMove()
    {
        Vector2 m = controls.HeadsetPlayer.Movement.ReadValue<Vector2>();
        Vector3 movement;

        if (m.y > 0.9f)
        {
            movement = (avatar.transform.forward);
            characterController.Move(movement * moveSpeed * Time.deltaTime);
        }

        if (m.y < -0.9f)
        {
            movement = (-avatar.transform.forward);
            characterController.Move(movement * moveSpeed * Time.deltaTime);
        }
        if (m.x > 0.9f)
        {
            avatar.transform.Rotate(Vector3.up * 1 * rotationSpeed);
        }
        if (m.y < -0.9f)
        {
            avatar.transform.Rotate(Vector3.up * -1 * rotationSpeed);
        }
    }
    private void desktopMove()
    {
        Vector2 input = controls.DesktopPlayer.Movement.ReadValue<Vector2>();
        Vector3 movement = (input.y * avatar.transform.forward) + (input.x * avatar.transform.right);
        characterController.Move(movement * moveSpeed * Time.deltaTime);
    }

    private void OnEnable()
    {
        controls.HeadsetPlayer.Enable();
        controls.DesktopPlayer.Enable();
    }

    private void OnDisable()
    {
        controls.HeadsetPlayer.Disable();
        controls.DesktopPlayer.Disable();
    }
}
