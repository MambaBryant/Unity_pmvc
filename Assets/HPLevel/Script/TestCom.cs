using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class TestCom :SimpleCommand {
	public  new const string NAME="TestCom";
	public override void Execute (PureMVC.Interfaces.INotification notification)
	{
				TestProxy por=(TestProxy)Facade.RetrieveProxy (TestProxy.NAME);
				por.CHangeHp (50);
	}
}
