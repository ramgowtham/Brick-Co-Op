using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;
using System.Collections.Generic;


public class ReadXML : MonoBehaviour {

	public TextAsset xmlFile;

	public List<LevelObjects> LevelObjectList;

	public GameObject BlueBox;

    public Material BlueMaterial;
    public string materialName;
    



	// Use this for initialization
	void Start ()
	{
		
		LevelObjectList=new List<LevelObjects>();
		ReadXMLData ();
		DrawLevel ();


	}

	void ReadXMLData()
	{
		XmlDocument xmlDoc = new XmlDocument ();
		xmlDoc.LoadXml (xmlFile.text);


		XmlNodeList nodeList = xmlDoc.GetElementsByTagName("ObjectList");		
		foreach (XmlNode title in nodeList) 
		{
			XmlNodeList ChildLvlObjList = title.ChildNodes;

			foreach (XmlNode childLvlObj in ChildLvlObjList) 
				{
				LevelObjects lvlObjc = new LevelObjects ();

				lvlObjc.posX =float.Parse( childLvlObj.Attributes ["posX"].Value);
				lvlObjc.posY =float.Parse( childLvlObj.Attributes ["posY"].Value);
				lvlObjc.posZ =float.Parse( childLvlObj.Attributes ["posZ"].Value);

				lvlObjc.rotX =float.Parse( childLvlObj.Attributes ["rotX"].Value);
				lvlObjc.rotY =float.Parse( childLvlObj.Attributes ["rotY"].Value);
				lvlObjc.rotZ =float.Parse( childLvlObj.Attributes ["rotZ"].Value);

                lvlObjc.scaleX = float.Parse(childLvlObj.Attributes["scaleX"].Value);
                lvlObjc.scaleY = float.Parse(childLvlObj.Attributes["scaleY"].Value);
                lvlObjc.sclaeZ = float.Parse(childLvlObj.Attributes["scaleZ"].Value);

                lvlObjc.name = childLvlObj.Attributes ["name"].Value;
				lvlObjc.tag = childLvlObj.Attributes ["tag"].Value;

                materialName = childLvlObj.Attributes["Material"].Value;


                LevelObjectList.Add (lvlObjc);
				}
		}
		

	}

	void DrawLevel()
	{
		foreach (LevelObjects lvlObjs in LevelObjectList)
			switch (lvlObjs.tag) 
			{
			case "Brick": Instantiate (BlueBox, 	new Vector3 (lvlObjs.posX,lvlObjs.posY,lvlObjs.posZ),	Quaternion.Euler( new Vector3(lvlObjs.rotX,lvlObjs.rotY,lvlObjs.rotZ)));
                    if (materialName == "BlueMaterial")
                        BlueBox.GetComponent<Renderer>().material = BlueMaterial;
                          //  Material yourMaterial = (Material)Resources.Load(materialName, typeof(Material));
                          //  BlueBox.GetComponent<Renderer>().sharedMaterial = yourMaterial;
                            break;

                





            }
	}






}
