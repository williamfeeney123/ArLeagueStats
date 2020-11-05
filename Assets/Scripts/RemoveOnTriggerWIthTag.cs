using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOnTriggerWIthTag : MonoBehaviour
{
	public string strTag;
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == strTag)
		{
			Destroy(gameObject);
			Destroy(other.gameObject);
		}
	}

}
