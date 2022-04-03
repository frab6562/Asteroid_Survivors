using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dies : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

}

