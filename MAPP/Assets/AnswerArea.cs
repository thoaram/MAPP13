using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerArea : MonoBehaviour
{
    // Start is called before the first frame update

 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacles")
        {
            Destroy(collision.gameObject);
        }
    }
}
