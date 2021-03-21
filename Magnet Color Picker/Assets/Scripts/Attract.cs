using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class Attract : MonoBehaviour
{
    public Transform magnet;
    public float speed;

   
    private void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Green") &&  ObjectDragger.isMouseDown == true )
        {
            print("Magnettt");
            other.gameObject.transform.position = Vector3.Lerp(other.gameObject.transform.position, magnet.position, speed * Time.smoothDeltaTime);
            //other.gameObject.GetComponent<Rigidbody>().AddForce((magnet.transform.position - other.transform.position).normalized * speed * Time.smoothDeltaTime);
            //rigidbody.AddForce((target.position - transform.position) * multiplicationFactor);
        }
    }
   
}
