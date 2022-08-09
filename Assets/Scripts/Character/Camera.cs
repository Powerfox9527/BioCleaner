using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    #region FIELDS
    [Header("Camera")]
    [SerializeField]
    float Sensitivity = 1.0f;
    [SerializeField]
    float Smooth = 12.0f;

    Vector2 frameVelocity;
    Vector2 velocity;
    Transform Character;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        Character = transform.parent;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector2 mouseVelocity = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * Sensitivity;
        frameVelocity = Vector2.Lerp(frameVelocity, mouseVelocity, 1 / Smooth);
        velocity += frameVelocity;
        velocity.y = Mathf.Clamp(velocity.y, -70, 70);

        // Rotate camera up-down and controller left-right from velocity.
        transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
        Character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
    }
}
