using UnityEngine;
using System.Collections;

public class HandleTrigger : MonoBehaviour {

	public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {
            transform.localScale *= 1.2f;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hand")
        {
            transform.localScale /= 1.2f;
        }
    }
}
