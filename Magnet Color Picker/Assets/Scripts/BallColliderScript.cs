using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColliderScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Green"))
        {
            print("Hello");
            other.gameObject.tag = "Pick";
            other.gameObject.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.gameObject.GetComponent<SphereCollider>().isTrigger = true;

    
            other.gameObject.AddComponent<BallColliderScript>();

            other.transform.parent = transform.parent;
        }
    }
   
}
