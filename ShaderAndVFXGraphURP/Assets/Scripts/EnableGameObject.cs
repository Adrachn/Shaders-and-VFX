using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGameObject : MonoBehaviour
{
    [SerializeField] private GameObject effect;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            effect.SetActive(!effect.activeSelf);
        }
    }
}
