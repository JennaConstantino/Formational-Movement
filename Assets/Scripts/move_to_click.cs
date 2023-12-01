using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_to_click : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        MoveToClick();
    }
    private void MoveToClick(){
        if (Input.GetMouseButton(0)){
            Ray dir = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(dir, out raycastHit, Mathf.Infinity)){
                if (Vector3.Distance(transform.position, raycastHit.point) > 0.1f){
                    transform.position = raycastHit.point;
                }
			}
        }
    }
}
