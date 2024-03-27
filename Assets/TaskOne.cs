using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskOne : MonoBehaviour
{
    public GameObject A;
    private void OnTriggerEnter(Collider other)
    {
        A.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        A.SetActive(false);
    }
}
