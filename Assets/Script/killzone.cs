using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killzone : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject.Destroy(col.gameObject);
    }
}
