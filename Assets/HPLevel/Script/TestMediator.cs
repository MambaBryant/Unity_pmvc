using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using PureMVC.Patterns;
using UnityEngine.UI;
public class TestMediator :Mediator {
	public new const string NAME="TestMediator";
	private Text levelText;
	private Button levelUpButton;

	private Text HpText;
	private Button HpAddButton;
	public TestMediator(GameObject root):base(NAME){
		levelText = GameUtility.GetChildComponent<Text> (root, "Text/LevelText");
		levelUpButton = GameUtility.GetChildComponent<Button> (root, "LevelUpButton");
		levelUpButton.onClick.AddListener (OnClickLevelUpButton);

		HpText = GameUtility.GetChildComponent<Text> (root, "Text/HpText");
		HpAddButton = GameUtility.GetChildComponent<Button> (root, "HpButton");
		HpAddButton.onClick.AddListener (OnClickHpAddButton);
	}
	private void OnClickLevelUpButton(){
		SendNotification (NotificationConstant.LevelUp);
	}
	private void OnClickHpAddButton(){
		SendNotification (NotificationConstant.AddHp);
	}
	public override IList<string> ListNotificationInterests(){
		IList<string > list = new List<string>();
		list.Add (NotificationConstant.LevelChange);
		list.Add (NotificationConstant.HpChange);
		return list;
	}
	public override void HandleNotification (PureMVC.Interfaces.INotification notification)
	{
		switch (notification.Name) {
		case NotificationConstant.LevelChange:
			CharacterInfo cl = notification.Body as CharacterInfo;
			levelText.text = cl.Level.ToString ();
			break;
		case NotificationConstant.HpChange:
			CharacterInfo cl1 = notification.Body as CharacterInfo;
			HpText.text = cl1.Hp.ToString ();
			break;
		default :
			break;
		}
	}
}
