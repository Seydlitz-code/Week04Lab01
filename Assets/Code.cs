using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity");

		//변수
        int level = 5;
        float strength = 15.5f;
        string playername = "나검사";
        bool isFullLevel = false;

		//그룹형 변수
		string[] minsters = { "슬라임", "사막뱀", "악마" };

		int mionsterLevels = new int[3];
		mionsterLevels[0] = 1;
		mionsterLevels[1] = 6;
		mionsterLevels[2] = 2;

		List<string> items = new List<string>();
		items.Add("생명물약 30");
		items.Add("마나물약 30");

		Debug.Log("용사의 이름은?");
		Debug.Log(playername);
		Debug.Log("용사의 레벨은?");
		Debug.Log(level);
		Debug.Log("용사의 힘은?");
		Debug.Log(strength);
		Debug.Log("용사는 만렙인가?");
		Debug.Log(isFullLevel);

		Debug.Log("맵에 존재하는 몬스터의 레벨은?");
		Debug.Log(minsters[0]);
		Debug.Log(minsters[1]);
		Debug.Log(minsters[2]);

		Debug.Log("용사가 가지고 있는 아이템은?");
		Debug.Log(items[0]);
		Debug.Log(items[1]);

		//리스트 내 변수 삭제하기

		/*items.RenoveAt(0);
		Debug.Log("용사가 가지고 있는 아이템은?");
		Debug.Log(items[0]);
		Debug.Log(items[1]);*/

		//연산자
		int exp = 1500;
		exp = 1500 + 320;
		exp = exp - 10;
		level = exp / 300;
		strength = level * 3.1f;

		Debug.Log("용사의 총 경험치는?");
		Debug.Log(exp);
		Debug.Log("용사의 레벨은?");
		Debug.Log(level);
		Debug.Log("용사의 힘은?");
		Debug.Log(strength);

		int nextExp = 300 - (exp % 300);
		Debug.Log("다음 레벨까지 남은 경험치는?");
		Debug.Log(nextExp);
		string title = "전설의";
		Debug.Log("용사의 이름은?");
		Debug.Log(playername + " " + title);
		
		int fulllevel = 99;
		isFulllevel = level == fulllevel;
		Debug.Log("용사는 만렙입니까?" + isFullLevel);

		bool isEndTutorial = level > 10;
		Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

		int health = 30;
		int mana = 25;
		//bool isBadCondition = health <= 50 && mana <= 20;
		bool isBadCondition = health <= 50 || mana <= 20;

		string condition = isBadCondition ? "나쁨" : "좋음";
		Debug.Log("용사의 상태가 나쁘니까? " + condition);

		//5. 조건문
		if (condition == "나쁨")
		{
			Debug.Log("포션을이어 상태가 나빠진 아이템을 사용하세요.");
		}
		else
		{
			Debug.Log("현재 상태가 좋습니다.");
		}
		if (isBadCondition && items[0] == "생명포션30")
		{
			items.RemoveAt(0);
			health += 30;
			Debug.Log("생명포션30을 사용하였습니다.");
		}
		else if (isBadCondition && items[0] == "마나포션30")
		{
			items.RemoveAt(0);
			mana += 30;
			Debug.Log("마나포션30을 사용하였습니다.");
		}
		string monsterAlarm;
		switch (monsters[1])
		{
			case "슬라임":
				monsterAlarm = "소형 몬스터가 출현!";
				break;
			case "오크":
				monsterAlarm = "중형 몬스터가 출현!";
				break;
			case "골렘":
				monsterAlarm = "대형 몬스터가 출현!";
				break;
			default:
				monsterAlarm = "??? 몬스터가 출현!";
				break;
		}
		//6. 반복문
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
			//Debug.Log("이 지역에 있는 몬스터 : " + monster);
		}
		Heal();

		for (int index = 0; index < monsters.Length; index++)
		{
			Debug.Log("용사는 " + monsters[index] + "에게 " + Battle(monsterLevel[index]));
		}
		//8. 클래스
		Player player = new Player();
		player.id = 0;
		player.name = "냥냥펀치";
		player.title = "용사";
		player.strength = 2.4f;
		player.weapon = "나무 지팡이";
		Debug.Log(player.Talk());
		Debug.Log(player.HasWeapon());

		player.LevelUp();
		Debug.Log(player.name + "의 레벨은 " + player.level + " 입니다.");
		Debug.Log(player.move());
	}
	//7. 함수 (메소드)
	void Heal()
	{
		health += 10;
		Debug.Log("회복을 사용합니다. " + health);
	}

	string Battle(int monsterLevel)
	{
		string result;
		if (level >= monsterLevel)
		{
			result = "이겼습니다.";
		}
		else
		{
			result = "졌습니다.";
		}

		return result;
	}
}
