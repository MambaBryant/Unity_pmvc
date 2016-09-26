using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class TestFacade:Facade  {
	public TestFacade(GameObject canvas){
		RegisterCommand (NotificationConstant.LevelUp, typeof(TestCommand));  //controller中的函数
		RegisterCommand (NotificationConstant.AddHp, typeof(TestCom));
		RegisterMediator (new TestMediator (canvas));  //view中的函数
		RegisterProxy (new TestProxy ());    //model中的函数
	}
}
