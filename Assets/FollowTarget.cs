using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
  public Transform target;
  private Vector3 offset;

  // Use this for initialization
  private void Start()
  {
    // Get the offset from the cameras position relative to the target
    offset = target.position - transform.position;
  }

  // We use late update so the camera always moves after the target moved, otherwise we would get some jitterish movement
  private void LateUpdate()
  {
    transform.position = target.position + offset;
  }
}