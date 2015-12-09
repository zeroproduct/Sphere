﻿using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	
	public Transform muzzle;
	public Projectile projectile;
	public float msBetweenShots = 100;
	public float muzzleVelocity = 35;
	
	float nextShotTime;
	
	public void Shoot() {
		
		if(Time.time > nextShotTime){
			nextShotTime = Time.time + msBetweenShots / 1000;

			/////*** NORMAL ***\\\\\
			Projectile newProjectile = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0)) as Projectile;
			newProjectile.SetSpeed (muzzleVelocity);

			/////*** SHOTGUN ***\\\\\
			//Projectile newProjectileL = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 350, 0)) as Projectile;
			//Projectile newProjectileF = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0)) as Projectile;
			//Projectile newProjectileR = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 10, 0)) as Projectile;
			//newProjectileL.SetSpeed (muzzleVelocity);
			//newProjectileF.SetSpeed (muzzleVelocity);
			//newProjectileR.SetSpeed (muzzleVelocity);

			/////*** 360 SHOT ***\\\\\
			//Projectile newProjectileN = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0)) as Projectile;
			//Projectile newProjectileE = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 90, 0)) as Projectile;
			//Projectile newProjectileS = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 180, 0)) as Projectile;
			//Projectile newProjectileW = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 270, 0)) as Projectile;
			//newProjectileN.SetSpeed (muzzleVelocity);
			//newProjectileE.SetSpeed (muzzleVelocity);
			//newProjectileS.SetSpeed (muzzleVelocity);
			//newProjectileW.SetSpeed (muzzleVelocity);

		}

	}
	
}
