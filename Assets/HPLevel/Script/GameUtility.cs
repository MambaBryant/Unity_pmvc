using UnityEngine;
using System.Collections;

public class GameUtility {
//获取子节点
	public static Transform GetChild(GameObject root,string path){
		Transform tra = root.transform.Find (path);
		if (tra==null) {
			Debug.Log (path + "not found");
		}
		return tra;
	}
	public static T GetChildComponent<T>(GameObject root,string path){
		Transform tra = root.transform.Find (path);
		if (tra == null) Debug.Log (path + "not found");
		T t = tra.GetComponent<T> ();
		return t;
	}
}
