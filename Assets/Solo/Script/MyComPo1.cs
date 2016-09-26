using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class MyComPo1 :SimpleCommand {
	public new const string NAME="MyComPo1";
	public override void Execute (PureMVC.Interfaces.INotification notification)
	{
		MyProxy proxy = (MyProxy)Facade.RetrieveProxy (MyProxy.NAME);
		proxy.ChangePoint1 ();
	}
}
