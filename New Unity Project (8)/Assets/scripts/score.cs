using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    // Use this for initialization
    public Transform PlayerTransform;
    public Text textScore;

	
	// Update is called once per frame
	void Update () {
       textScore.text= PlayerTransform.position.z.ToString("0");
	}
}
