using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowFlower : MonoBehaviour
{
    private Vector3 scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
    private GameObject selectedObject;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Moved)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("sunflower"))
                {
                    selectedObject = hit.collider.gameObject;

                    selectedObject.transform.localScale += scaleChange;

                    if (selectedObject.transform.localScale.y < 1f || selectedObject.transform.localScale.y > 5f)
                    {
                        scaleChange *= -1;
                    }
                }
            }
        }
        else if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("sunflower"))
                {
                    selectedObject = hit.collider.gameObject;

                    selectedObject.transform.localScale += scaleChange;

                    if (selectedObject.transform.localScale.y < 1f || selectedObject.transform.localScale.y > 5f)
                    {
                        scaleChange *= -1;
                    }
                }
            }
        }
    }
}