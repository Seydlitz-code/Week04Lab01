using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity");

		//����
        int level = 5;
        float strength = 15.5f;
        string playername = "���˻�";
        bool isFullLevel = false;

		//�׷��� ����
		string[] minsters = { "������", "�縷��", "�Ǹ�" };

		int mionsterLevels = new int[3];
		mionsterLevels[0] = 1;
		mionsterLevels[1] = 6;
		mionsterLevels[2] = 2;

		List<string> items = new List<string>();
		items.Add("������ 30");
		items.Add("�������� 30");

		Debug.Log("����� �̸���?");
		Debug.Log(playername);
		Debug.Log("����� ������?");
		Debug.Log(level);
		Debug.Log("����� ����?");
		Debug.Log(strength);
		Debug.Log("���� �����ΰ�?");
		Debug.Log(isFullLevel);

		Debug.Log("�ʿ� �����ϴ� ������ ������?");
		Debug.Log(minsters[0]);
		Debug.Log(minsters[1]);
		Debug.Log(minsters[2]);

		Debug.Log("��簡 ������ �ִ� ��������?");
		Debug.Log(items[0]);
		Debug.Log(items[1]);

		//����Ʈ �� ���� �����ϱ�

		/*items.RenoveAt(0);
		Debug.Log("��簡 ������ �ִ� ��������?");
		Debug.Log(items[0]);
		Debug.Log(items[1]);*/

		//������
		int exp = 1500;
		exp = 1500 + 320;
		exp = exp - 10;
		level = exp / 300;
		strength = level * 3.1f;

		Debug.Log("����� �� ����ġ��?");
		Debug.Log(exp);
		Debug.Log("����� ������?");
		Debug.Log(level);
		Debug.Log("����� ����?");
		Debug.Log(strength);

		int nextExp = 300 - (exp % 300);
		Debug.Log("���� �������� ���� ����ġ��?");
		Debug.Log(nextExp);
		string title = "������";
		Debug.Log("����� �̸���?");
		Debug.Log(playername + " " + title);
		
		int fulllevel = 99;
		isFulllevel = level == fulllevel;
		Debug.Log("���� �����Դϱ�?" + isFullLevel);

		bool isEndTutorial = level > 10;
		Debug.Log("Ʃ�丮���� ���� ����Դϱ�?" + isEndTutorial);

		int health = 30;
		int mana = 25;
		//bool isBadCondition = health <= 50 && mana <= 20;
		bool isBadCondition = health <= 50 || mana <= 20;

		string condition = isBadCondition ? "����" : "����";
		Debug.Log("����� ���°� ���ڴϱ�? " + condition);

		//5. ���ǹ�
		if (condition == "����")
		{
			Debug.Log("�������̾� ���°� ������ �������� ����ϼ���.");
		}
		else
		{
			Debug.Log("���� ���°� �����ϴ�.");
		}
		if (isBadCondition && items[0] == "��������30")
		{
			items.RemoveAt(0);
			health += 30;
			Debug.Log("��������30�� ����Ͽ����ϴ�.");
		}
		else if (isBadCondition && items[0] == "��������30")
		{
			items.RemoveAt(0);
			mana += 30;
			Debug.Log("��������30�� ����Ͽ����ϴ�.");
		}
		string monsterAlarm;
		switch (monsters[1])
		{
			case "������":
				monsterAlarm = "���� ���Ͱ� ����!";
				break;
			case "��ũ":
				monsterAlarm = "���� ���Ͱ� ����!";
				break;
			case "��":
				monsterAlarm = "���� ���Ͱ� ����!";
				break;
			default:
				monsterAlarm = "??? ���Ͱ� ����!";
				break;
		}
		//6. �ݺ���
		while (health > 0)
		{
			health--;
			if (health == 10)
			{
				break;
			}
		}

		for (int count = 0; count < 10; count++)
		{
			health++;
		}

		foreach (string monster in monsters)
		{
			//Debug.Log("�� ������ �ִ� ���� : " + monster);
		}
		Heal();

		for (int index = 0; index < monsters.Length; index++)
		{
			Debug.Log("���� " + monsters[index] + "���� " + Battle(monsterLevel[index]));
		}
		//8. Ŭ����
		Player player = new Player();
		player.id = 0;
		player.name = "�ɳ���ġ";
		player.title = "���";
		player.strength = 2.4f;
		player.weapon = "���� ������";
		Debug.Log(player.Talk());
		Debug.Log(player.HasWeapon());

		player.LevelUp();
		Debug.Log(player.name + "�� ������ " + player.level + " �Դϴ�.");
		Debug.Log(player.move());
	}
	//7. �Լ� (�޼ҵ�)
	void Heal()
	{
		health += 10;
		Debug.Log("ȸ���� ����մϴ�. " + health);
	}

	string Battle(int monsterLevel)
	{
		string result;
		if (level >= monsterLevel)
		{
			result = "�̰���ϴ�.";
		}
		else
		{
			result = "�����ϴ�.";
		}

		return result;
	}
}
