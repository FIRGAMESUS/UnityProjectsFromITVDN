using UnityEngine;
using System.Collections;

public class HealthHelper : MonoBehaviour {

	public int maxHealth = 100;
	public int Health = 100;

	public bool isDynamicHealthBarCreate = true;

	UIHealthBarHelper _UIHealthBarHelper;

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
}
