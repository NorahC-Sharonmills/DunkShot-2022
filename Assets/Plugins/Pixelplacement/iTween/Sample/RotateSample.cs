using UnityEngine;
using System.Collections;

public class RotateSample : MonoBehaviour
{
     public Transform[] line;
	void Start(){
		iTween.RotateBy(gameObject, iTween.Hash("x", .25, "easeType", "easeInOutBack", "loopType", "pingPong", "delay", .4));
      
	}
    private void OnDrawGizmos()
    {
        iTween.DrawLine(line);
    }
}

