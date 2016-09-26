using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class MyCom2:MacroCommand{
	public new const string NAME="MyCom2";
	public override void Execute (PureMVC.Interfaces.INotification notification)
	{
		MyProxy mp1 = (MyProxy)Facade.RetrieveProxy (MyProxy.NAME);
		mp1.ChangeHp2(Random.Range (8,20));

	}
}
