using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            ShootRay();
        }
    }

    // Update is called once per frame
    void ShootRay()

    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Destroy(hit.collider.gameObject);
        }    
    }
}
