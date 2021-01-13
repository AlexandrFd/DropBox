using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBoxDestroy : MonoBehaviour
{
    /// <summary>
    /// Удаление обьекта через время
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("DestroyBox", 10F);
    }

    
    void DestroyBox() 
    {
        Destroy(gameObject);
    }
}
