using UnityEngine;
using System.Collections;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections.Generic;

using UnityEngine.UI;


public class CreateXML : MonoBehaviour {
	bool temp=true;

	public List<GameObject> lvlobj;

    public Text lvlNumInputField;

	

    public int LevelNum;

	// Use this for initialization
	void Start () {

        lvlNumInputField.text = "" + LevelNum;

        lvlobj = new List<GameObject> ();
	}
	
	// Update is called once per frame
	

    public void OnClick()
    {
        XMLWrite();
    }


	void XMLWrite()
	{
		FileStream file= new FileStream("Assets/XML/Level"+LevelNum+".xml", FileMode.Create);
		XmlTextWriter writer= new XmlTextWriter(file,Encoding.UTF8);

		GameObject[] BrickObjs = GameObject.FindGameObjectsWithTag ("Brick");
		foreach (GameObject obj in BrickObjs) 
		{
			lvlobj.Add (obj);
            
		}

     




        writer.WriteStartDocument ();
        writer.WriteStartElement("Level");
        writer.WriteStartElement ("ObjectList");




		for (int i = 0; i < lvlobj.Count; i++)
		{
		writer.WriteStartElement("levelObject");

			writer.WriteAttributeString("name", lvlobj[i].name + "");
			writer.WriteAttributeString("tag", lvlobj[i].tag + "");

			writer.WriteAttributeString("posX", lvlobj[i].transform.position.x + "");
			writer.WriteAttributeString("posY", lvlobj[i].transform.position.y + "");
			writer.WriteAttributeString("posZ", lvlobj[i].transform.position.z + "");

			writer.WriteAttributeString("rotX", lvlobj[i].transform.rotation.eulerAngles.x + "");
			writer.WriteAttributeString("rotY", lvlobj[i].transform.rotation.eulerAngles.y + "");
			writer.WriteAttributeString("rotZ", lvlobj[i].transform.rotation.eulerAngles.z + "");

            writer.WriteAttributeString("scaleX", lvlobj[i].transform.localScale.x + "");
            writer.WriteAttributeString("scaleY", lvlobj[i].transform.localScale.y + "");
            writer.WriteAttributeString("scaleZ", lvlobj[i].transform.localScale.z + "");

            writer.WriteAttributeString("Material", lvlobj[i].GetComponent<Renderer>().material.name);
            
            writer.WriteEndElement();
		}	




        writer.WriteEndElement ();
        writer.WriteEndDocument ();
		writer.Flush ();
		file.Close ();

		Debug.Log ("XML Created");




	}


}
