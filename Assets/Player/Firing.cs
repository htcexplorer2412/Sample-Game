using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public float damage = 10f;
    [SerializeField] Camera mainCam; 

   public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward,out hit))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
