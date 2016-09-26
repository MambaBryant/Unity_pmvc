using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class MyCom1:MacroCommand{
	public new const string NAME="MyCom1";
	public override void Execute (PureMVC.Interfaces.INotification notification)
	{
		MyProxy mp2 = (MyProxy)Facade.RetrieveProxy (MyProxy.NAME);
		mp2.ChangeHp1 (Random.Range (10,15));
	}
}
