using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class MyFacade :Facade{
	public MyFacade(GameObject canvas){
		RegisterCommand (MyNotificationConstant.AddPoint1, typeof(MyComPo1));
		RegisterCommand (MyNotificationConstant.AddPoint2, typeof(MyComPo2));
		RegisterCommand (MyNotificationConstant.Damage1, typeof(MyCom1));
		RegisterCommand (MyNotificationConstant.Damage2, typeof(MyCom2));
		RegisterMediator (new MyMediator (canvas));
		RegisterProxy(new MyProxy());
	}
}
