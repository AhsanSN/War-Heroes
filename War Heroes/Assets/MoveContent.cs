using UnityEngine;
using System.Collections;

public class MoveContent : MonoBehaviour {

	public void MoveContentPane(float value)
	{
		var pos = transform.position;
		pos.x += value;
		transform.position = pos;
	}
}
