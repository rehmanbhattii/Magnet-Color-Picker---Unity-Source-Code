using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStopperScript : MonoBehaviour
{
    public List<GameObject> GreenBallList;
    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Green"))
        {

            other.gameObject.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.gameObject.GetComponent<SphereCollider>().isTrigger = true;

            other.transform.parent = transform.parent;
            GreenBallList.Add(other.gameObject);
            other.gameObject.tag = "Pick";

            other.gameObject.AddComponent<BallColliderScript>();
        }
      
    }
}
