using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code_01 : MonoBehaviour
{
	int id;
	string name;
	string title;
	string weapon;
	float strength;
	int level;

	string Talk()
	{
		return "��ȭ�� �ɾ����ϴ�.";
	}

	string HasWeapon()
	{
		return weapon;
	}
	void LevelUp()
	{
		level = level + 1;
	}
}
