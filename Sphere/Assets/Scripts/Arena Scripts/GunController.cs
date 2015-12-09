using UnityEngine;
using System.Collections;


public class GunController : MonoBehaviour {
	
	public Transform weaponHold;
	public Gun startingGun;
	Gun equiptedGun;
	
	void Start() {
		if (startingGun != null) {
			EquipGun(startingGun);
		}
	}
	
	public void EquipGun(Gun gunToEquip) {
		if (equiptedGun != null) {
			Destroy(equiptedGun.gameObject);
		}
		equiptedGun = Instantiate (gunToEquip, weaponHold.position, weaponHold.rotation) as Gun;
		equiptedGun.transform.parent = weaponHold;
	}
	
	public void Shoot() {
		if (equiptedGun != null) {
			equiptedGun.Shoot();
		}
	}
}
