using UnityEngine;
using System.Collections;
using System;

public class HealthHelper : MonoBehaviour {

	public int maxHealth = 100;
	public int Health = 100;

	public bool isDynamicHealthBarCreate = true;

	UIHealthBarHelper _UIHealthBarHelper;

	private bool Dead;

	public bool MyProperty
	{
		get { return Dead; }
		set { Dead = value; }
	}

	public int Kills { get; private set; }

	void Start () {
		if (isDynamicHealthBarCreate)
		{
			GameObject healthBarSlider = Instantiate(Resources.Load("HealthBarSlider"), Vector3.zero, Quaternion.identity) as GameObject;
			healthBarSlider.transform.SetParent(GameObject.Find("Canvas").transform);
			_UIHealthBarHelper = healthBarSlider.GetComponent<UIHealthBarHelper>();
			_UIHealthBarHelper.NPC = transform;
		}
	}
	
	void Update () {
	
	}

    public void GetDamage(int damage, HealthHelper killer)
    {
		if (Dead) return;

		Health -= damage;

		if (Health <= 0)
		{
			Dead = true;
			killer.Kills += 1;
			GetComponentInChildren<PlayerShooting>().Drop();
			GetComponent<Animator>().SetBool("Dead", true);
		}
    }
}
