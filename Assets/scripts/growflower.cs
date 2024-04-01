using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code from: click and hold to grow https://www.youtube.com/watch?v=SyRCSiQdpaw

public class growflower : MonoBehaviour
{
    Vector3 scaleChange = new Vector3(-0.1f, -0.1f, -0.1f);

    private GameObject selectedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //click and hold down on object to grow
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Stationary)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "sunflower")
                {
                    selectedObject = hit.collider.gameObject;

                    selectedObject.transform.localScale += scaleChange;

                    if (hit.transform.localScale.y < 1f || hit.transform.localScale.y > 5f)
                    {
                        scaleChange = new Vector3(-0.1f, -0.1f, -0.1f);
                    }
                    
                }
            }
        }



    }
}
