//using UnityEngine;
using System.Collections;

public class RoleData {

	//基础信息
	public int ID;//全局唯一ID
	public string Name;
	public string Title;

	private int _sing;
	public int Sing {
		get{ return _sing;}
		set {
			if (value > 9999)
				_sing = 9999;
			else if (value < 0)
				_sing = 0;
			else
				_sing = value;
		}
	}

	//基础数值
	private int _actor;
	public int Actor {
		get{ return _actor;}
		set {
			if (value > 9999)
				_actor = 9999;
			else if (value < 0)
				_actor = 0;
			else
				_actor = value;
		}
	}

	private int _repute;
	public int Repute {
		get{ return _repute;}
		set {
			if (value > 20)
				_repute = 20;
			else if (value < 0)
				_repute = 0;
			else
				_repute = value;
		}
	}

	private int _popular;
	public int Popular {
		get{ return _popular;}
		set {
			if (value > 20)
				_popular = 20;
			else if (value < 0)
				_popular = 0;
			else
				_popular = value;
		}
	}

	//天赋数值
	private int _sing_talent;
	public int SingTalent{
		get{return _sing_talent;}
		set{
			if (value > 999)
				_sing_talent = 999;
			else if (value < 0)
				_sing_talent = 0;
			else
				_sing_talent = value;
		}
	}

	private int _actor_talent;
	public int ActorTalent{
		get{return _actor_talent;}
		set{
			if (value > 999)
				_actor_talent = 999;
			else if (value < 0)
				_actor_talent = 0;
			else
				_actor_talent = value;
		}
	}

	//状态数值
	private int _mind;
	public int Mind{
		get{return _mind;}
		set{
			if (value > 100)
				_mind = 100;
			else if (value < -100)
				_mind = -100;
			else
				_mind = value;
		}
	}

	private int _health;
	public int Health{
		get{return _health;}
		set{
			if (value > 100)
				_health = 100;
			else if (value < -100)
				_health = -100;
			else
				_health = value;
		}
	}

	private int _weariness;
	public int Weariness{
		get{return _weariness;}
		set{
			if (value > 100)
				_weariness = 100;
			else if (value < 0)
				_weariness = 0;
			else
				_weariness = value;
		}
	}

	//其他计量值

	private int _gold;
	public int Gold{
		get{return _gold;}
		set{
			if (value < 0)
				_gold = 0;
			else if (value > 10000000000)
				_gold = 1000000000;
			else
				_gold = value;
		}
	}

	private int _fans;
	public int Fans {
		get{ return _fans;}
		set {
			if (value < 0)
				_fans = 0;
			else if (value > 100000000)
				_fans = 100000000;
			else
				_fans = value;
		}
	}

	//创作能力
	private int _music_creativity;
	public int MusicCreativity{
		get {return _music_creativity;}
		set{
			if (value < 0)
				_music_creativity = 0;
			else if (value > 9999)
				_music_creativity = 9999;
			else
				_music_creativity = value;
		}
	}

	private int _rap;
	public int Rap{
		get {return _rap;}
		set{
			if (value < 0)
				_rap = 0;
			else if (value > 999)
				_rap = 999;
			else
				_rap = value;
		}
	}

	private int _opera_creativity;
	public int OperaCreativity{
		get {return _opera_creativity;}
		set{
			if (value < 0)
				_opera_creativity = 0;
			else if (value > 9999)
				_opera_creativity = 9999;
			else
				_opera_creativity = value;
		}
	}

	private int _action;
	public int Action{
		get {return _action;}
		set{
			if (value < 0)
				_action = 0;
			else if (value > 999)
				_action = 999;
			else
				_action = value;
		}
	}

	//性格与特殊状态栏

	//人际关系

}
