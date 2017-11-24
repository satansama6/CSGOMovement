using UnityEngine;
using System.Collections;

public class BacisMovement : MonoBehaviour
{
  // This only works with the mouse but you should be able to figure out from here

  public Camera mainCamera;

  public float m_MovementSpeed = 50;
  public float m_HorizontalRotationSpeed = 50;
  public float m_VerticalRotationSpeed = 20;

  private float m_Yaw = 0;
  private float m_Pitch = 0;

  // Update is called once per frame
  private void Update()
  {
    if (Input.GetKey(KeyCode.W))
    {
      transform.position += transform.forward * m_MovementSpeed * Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.S))
    {
      transform.position -= transform.forward * m_MovementSpeed * Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.D))
    {
      transform.position += transform.right * m_MovementSpeed * Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.A))
    {
      transform.position -= transform.right * m_MovementSpeed * Time.deltaTime;
    }

    m_Yaw += m_HorizontalRotationSpeed * Input.GetAxis("Mouse X");
    m_Pitch -= m_VerticalRotationSpeed * Input.GetAxis("Mouse Y");
    transform.eulerAngles = new Vector3(0, m_Yaw, 0);
    mainCamera.transform.eulerAngles = new Vector3(m_Pitch, m_Yaw, 0);
  }
}