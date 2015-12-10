using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileGenerator : MonoBehaviour {

	public GameObject currentTile;
	public GameObject[] tilePrefabs;
	private static TileGenerator instance;
	private Stack<GameObject> leftTiles = new Stack<GameObject>();
	private Stack<GameObject> topTiles = new Stack<GameObject>();

	public Stack<GameObject> LeftTiles {
		get { return leftTiles;}
		set { leftTiles = value; }
	}

	public Stack<GameObject> TopTiles {
		get { return topTiles;}
		set { topTiles = value;}
	}

	public static TileGenerator Instance{
		get
		{
			if(instance ==null){
				instance = GameObject.FindObjectOfType<TileGenerator>();
			}
			return instance;
		}
	}

	// Use this for initialization
	void Start () {
		createTile (100);

		//create 50 tiles
		for(int i=0; i<50; i++){
			spawnTile();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//create tiles to spawn later
	public void createTile(int amt){
		for (int i=0; i<amt; i++) {
			leftTiles.Push(Instantiate(tilePrefabs[0]));
			topTiles.Push(Instantiate(tilePrefabs[1]));
			topTiles.Peek ().name = "TopTile";
			topTiles.Peek ().SetActive(false);
			leftTiles.Peek().name = "LeftTile";
			leftTiles.Peek ().SetActive(false);

		}
	}

	public void spawnTile(){
		//if no tiles create tiles
		if (leftTiles.Count == 0 || topTiles.Count == 0) {
			createTile(10);
		}
		//generate random # between 0-1
		int randomIndex = Random.Range (0, 2);
		if (randomIndex == 0) {
			GameObject temp = leftTiles.Pop ();
			temp.SetActive(true);
			temp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position;
			currentTile = temp;
		} else if(randomIndex==1) {
			GameObject temp = leftTiles.Pop ();
			temp.SetActive(true);
			temp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position;
			currentTile = temp;		
		}

		currentTile= (GameObject)Instantiate(tilePrefabs[randomIndex], currentTile.transform.GetChild(0).transform.transform.GetChild(randomIndex).position, Quaternion.identity);
	}
}
