using UnityEngine;
using System.Collections;

public class MyCharacterInfo  {
	public int Point1{ get; set;}
	public int Hp1{ get; set;}
	public int Point2{ get; set;}
	public int Hp2{ get; set;}
	public MyCharacterInfo(){
	}
	public MyCharacterInfo(int p1,int p2){
		Point1 = p1;
		Point2 = p2;
		Hp1 = 150;
		Hp2 = 200;
	}
}
