using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class MyProxy:Proxy{
	public new const string NAME="MyProxy";
	public MyCharacterInfo Data{ get; set;}
	public MyProxy():base(NAME){
		Data = new MyCharacterInfo ();
	}
	public void ChangeHp1(int change){
		Data.Hp1 -= change;
		SendNotification (MyNotificationConstant.ChangeHp1, Data);
	}
	public void ChangeHp2(int change){
		Data.Hp2 -= change;
		SendNotification (MyNotificationConstant.ChangeHp2, Data);
	}
	public void ChangePoint1(){
		Data.Point1 += 1;
		SendNotification (MyNotificationConstant.AddPoint1, Data);
	}
	public void ChangePoint2(){
		Data.Point2 += 1;
		SendNotification (MyNotificationConstant.AddPoint2, Data);
	}
}
