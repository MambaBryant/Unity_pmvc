using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class TestProxy : Proxy    {
	public new const string NAME="TestProxy";
	public CharacterInfo Data{ get; set;}
	public TestProxy():base(NAME){
		Data = new CharacterInfo ();
	}
	public void ChangeLevel(int change){
		Data.Level += change;
		SendNotification (NotificationConstant.LevelChange, Data);
	}
	public void CHangeHp(int change){
		Data.Hp += change;
		SendNotification (NotificationConstant.HpChange, Data);
	}
}
