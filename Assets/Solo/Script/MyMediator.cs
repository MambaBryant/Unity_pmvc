using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using UnityEngine.UI;
using System.Collections.Generic;
public class MyMediator :Mediator{
	private cor c;
	private MyCharacterInfo mcc;
	public new static string  NAME="MyMediator";
	public Text point1Text;
	public Text point2Text;
	public Slider s1;
	public Slider s2;
	public MyMediator(GameObject root):base(NAME){
		mcc = new MyCharacterInfo ();
		c = GameObject.Find ("Main Camera").GetComponent<cor> ();
		Debug.Log (c.name);
		point1Text = MyGameUtility.GetChildComponent<Text> (root, "P1Point/Text");
		point2Text = MyGameUtility.GetChildComponent<Text> (root, "P2Point/Text");
		s1 = MyGameUtility.GetChildComponent<Slider> (root, "Player1Hp");
		s2 = MyGameUtility.GetChildComponent<Slider> (root, "Player2Hp");
		c.StartCoroutine (Attack1());
		c.StartCoroutine (Attack2 ());
	}
	IEnumerator Attack1(){

		while (mcc.Hp1 > 0 && mcc.Hp2 > 0) {
			Debug.Log ("kobe");
			SendNotification (MyNotificationConstant.Damage1);
			if (mcc.Hp2<=0) {
				SendNotification (MyNotificationConstant.AddPoint1);
			}
			yield return new WaitForSeconds (1.5f);
		}
	}
	IEnumerator Attack2(){
		while (mcc.Hp1 > 0 && mcc.Hp2 > 0) {
			SendNotification (MyNotificationConstant.Damage2);
			if (mcc.Hp1<=0) {
				SendNotification (MyNotificationConstant.AddPoint2);
			}
			yield return new WaitForSeconds (2f);
		}
	}
	public override IList<string> ListNotificationInterests ()
	{
		IList<string> list = new List<string> ();
		list.Add (MyNotificationConstant.ChangeHp1);
		list.Add (MyNotificationConstant.ChangeHp2);
		list.Add (MyNotificationConstant.ChangePoint1);
		list.Add (MyNotificationConstant.ChangePoint2);
		return list;
	
}
	public override void HandleNotification (PureMVC.Interfaces.INotification notification)
	{
		switch (notification.Name) {
		case MyNotificationConstant.ChangeHp1:
			MyCharacterInfo mc = notification.Body as MyCharacterInfo;
			s1.value =mc.Hp1 / 150;
			break;
		case MyNotificationConstant.ChangeHp2:
			MyCharacterInfo mc2 = notification.Body as MyCharacterInfo;
			s1.value = mc2.Hp2 / 200;
			break;
		case MyNotificationConstant.ChangePoint1:
			MyCharacterInfo cl = notification.Body as MyCharacterInfo;
			point1Text.text = cl.Point1.ToString();
			break;
		case MyNotificationConstant.ChangePoint2:
			MyCharacterInfo cl2= notification.Body as MyCharacterInfo;
			point1Text.text = cl2.Point2.ToString();
			break;
		}
	}
}
