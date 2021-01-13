using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CButtonL : MonoBehaviour
{
    [SerializeField] GameObject Boat;
    float Horizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDrag()
    {
        
        Boat.GetComponent<SpriteRenderer>().flipX = false;
        if (Boat.transform.position.x > -2.6)
        {
            Boat.transform.Translate(-0.05F, 0, 0);
        }
        
    }
}
