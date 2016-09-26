using UnityEngine;
using System.Collections;
using PureMVC.Patterns;

//逻辑处理
public class TestCommand:SimpleCommand {
	public new const string NAME="TestCommand";
	public override void Execute (PureMVC.Interfaces.INotification notification)
	{
		TestProxy proxy = (TestProxy)Facade.RetrieveProxy (TestProxy.NAME);
		proxy.ChangeLevel (1);


	}

}

