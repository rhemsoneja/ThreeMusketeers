// Alphabets Game Test : UnityCoder.com

using UnityEngine;
using System.Collections;

public class AA_gameplay : MonoBehaviour {

//	public AudioSource blip;
	public AudioClip clip;
	public AudioClip clipMiss;
	public AudioClip clipFall;
	
	public Transform prefab;
	public Transform explo;
	public GUIText scoreGUI;
	public GUITexture hpgui;
	
	static public int score;
	public float fireRate = 1.0f;
	private int hp=100;
	
    private int worldWidth = 0;
    private float nextFire = 0.0f;
    private float speedMultiplier = 0.95f;
	private Camera cam;
	private LineRenderer lineRenderer;
	private string[] alphabets;// = new string[28];
	
	// Use this for initialization
	void Start () {
		alphabets = new [] {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
		cam = Camera.main;
		lineRenderer = gameObject.GetComponent<LineRenderer>();
		// get view borders
		worldWidth = (int)Mathf.Floor(cam.ViewportToWorldPoint (new Vector3 (0,0, cam.nearClipPlane)).x*0.8f);
			
		//Debug.Log(worldWidth);
			
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		// autofire
		if (Time.time > nextFire) 
		{
            nextFire = Time.time + fireRate;
			
			//Debug.Log(border);
			
			
			Vector3 pos = new Vector3(Random.Range(-worldWidth,worldWidth),1,0);
			//Transform clone = Instantiate(prefab, pos, Quaternion.identity) as Transform;
			Transform clone = Instantiate(prefab, pos-new Vector3(-3,0,0), Quaternion.identity) as Transform;
			string alphabet = alphabets[(int)Random.Range(0,alphabets.Length)];
			//string alphabet = alphabets[(int)Random.Range(0,3)];
			clone.name = alphabet;
			clone.GetComponent<TextMesh>().text = alphabet;
			Destroy(clone.gameObject,10);
		}

		//	pressing keys, check if letter exists on screen
		if (Input.GetKeyDown("a")) {	GameObject go = GameObject.Find("A");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("b")) {	GameObject go = GameObject.Find("B");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("c")) {	GameObject go = GameObject.Find("C");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("d")) {	GameObject go = GameObject.Find("D");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("e")) {	GameObject go = GameObject.Find("E");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("f")) {	GameObject go = GameObject.Find("F");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("g")) {	GameObject go = GameObject.Find("G");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("h")) {	GameObject go = GameObject.Find("H");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("i")) {	GameObject go = GameObject.Find("I");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("j")) {	GameObject go = GameObject.Find("J");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("k")) {	GameObject go = GameObject.Find("K");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("l")) {	GameObject go = GameObject.Find("L");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("m")) { GameObject go = GameObject.Find("M"); if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("n")) {	GameObject go = GameObject.Find("N");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("o")) {	GameObject go = GameObject.Find("O");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("p")) {	GameObject go = GameObject.Find("P");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("q")) {	GameObject go = GameObject.Find("Q");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("r")) {	GameObject go = GameObject.Find("R");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("s")) {	GameObject go = GameObject.Find("S");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("t")) {	GameObject go = GameObject.Find("T");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("u")) {	GameObject go = GameObject.Find("U");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("v")) {	GameObject go = GameObject.Find("V");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("w")) { GameObject go = GameObject.Find("W"); if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("x")) {	GameObject go = GameObject.Find("X");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("y")) {	GameObject go = GameObject.Find("Y");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
		if (Input.GetKeyDown("z")) {	GameObject go = GameObject.Find("Z");	if (go){	if (go.GetComponent<Renderer>().IsVisibleFrom(cam))	{Explode(go);}else{Miss(go);}	}else{Miss(go);}}
	}
	
	void OnPostRender()
	{
		lineRenderer.SetPosition(0, new Vector3(999,999,999));
		lineRenderer.SetPosition(1, new Vector3(999,999,999));
	}


	void Miss(GameObject go)
	{
		Destroy(go);
		updateScore(-1);
		fireRate*=speedMultiplier;
		if (fireRate<0) fireRate=0;
		updateHP(-10);
		AudioSource.PlayClipAtPoint(clipMiss, Vector3.zero);
	}

	void FallOff(int temp)
	{
//		Destroy(go);
//		updateScore(-1);
		fireRate*=speedMultiplier;
		if (fireRate<0) fireRate=0;
//		updateHP(-10);
		AudioSource.PlayClipAtPoint(clipMiss, Vector3.zero);
	}
	
	void Explode(GameObject go)
	{
		// laser
		lineRenderer.SetPosition(0, go.transform.position-new Vector3(0,100,0)+new Vector3(2,-3,0));
		lineRenderer.SetPosition(1, go.transform.position+new Vector3(2,-3,0));
		
		Transform clone = Instantiate(explo, go.transform.position+new Vector3(2,-3,0), Quaternion.identity) as Transform;
		clone.parent = go.transform;
		go.GetComponent<Renderer>().enabled = false;
		
		go.name = "destroyed";
		Destroy(clone.gameObject,5);
		Destroy(go.gameObject,5);
		
		Vector3 viewPos = GetComponent<Camera>().WorldToViewportPoint(go.transform.position);
		//Debug.Log(viewPos.y);
		fireRate-=Mathf.Lerp(0.005f,0.0f,viewPos.y);
		//Debug.Log(Mathf.Lerp(0.005f,0.0f,viewPos.y));
		updateScore(1);
		//AudioSource.PlayClipAtPoint(clip, cam.transform.position+((viewPos+new Vector3(0.5f,0.5f,0.5f))*3));
		AudioSource.PlayClipAtPoint(clip, cam.transform.position+(new Vector3(viewPos.x,viewPos.y,0)-new Vector3(0.5f,0.5f,0.0f)));
	}
	
	void updateScore(int add)
	{
		score+=add;
		scoreGUI.text = "Score: "+score;
		// TODO: if below 0, end
	}
	
	void updateHP(int add)
	{
		hp+=add;
//		Debug.Log(hp);
//		hpgui.width = hp;
		//hpgui.pixelInset = new Rect (hpgui.pixelInset.x, hpgui.pixelInset.y, hp, hpgui.pixelInset.height);
		hpgui.pixelInset = new Rect (hpgui.pixelInset.x, hpgui.pixelInset.y, hpgui.pixelInset.width, hp);
//		UpdateHPGui(hp);
		
		if (hp<1)
		{
			Application.LoadLevel(2);
		}
		
	}
	
	
}
