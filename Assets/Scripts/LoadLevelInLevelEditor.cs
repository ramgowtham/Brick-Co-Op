using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;
using System.Collections.Generic;
using UnityEngine.UI;

public class LoadLevelInLevelEditor : MonoBehaviour {
    public TextAsset[] xmlFiles;
    public TextAsset xmlFile;

    public List<LevelObjects> LevelObjectList;

    public GameObject Brick_11;
    public GameObject Brick_12;
    public GameObject Brick_13;
    public GameObject Brick_14;
    public GameObject Brick_15;
    public GameObject Brick_21;
    public GameObject Brick_22;
    public GameObject Brick_23;
    public GameObject Brick_24;
    public GameObject Brick_25;
    public GameObject Brick_31;
    public GameObject Brick_32;
    public GameObject Brick_33;
    public GameObject Brick_34;
    public GameObject Brick_35;
    public GameObject Brick_41;
    public GameObject Brick_42;
    public GameObject Brick_43;
    public GameObject Brick_44;
    public GameObject Brick_45;
    public GameObject Brick_51;
    public GameObject Brick_52;
    public GameObject Brick_53;
    public GameObject Brick_54;
    public GameObject Brick_55;
    public GameObject Brick_61;
    public GameObject Brick_62;
    public GameObject Brick_63;
    public GameObject Brick_64;
    public GameObject Brick_65;
    public GameObject Brick_71;
    public GameObject Brick_72;
    public GameObject Brick_73;
    public GameObject Brick_74;
    public GameObject Brick_75;
    public GameObject Brick_81;
    public GameObject Brick_82;
    public GameObject Brick_83;
    public GameObject Brick_84;
    public GameObject Brick_85;
    public GameObject Brick_91;
    public GameObject Brick_92;
    public GameObject Brick_93;
    public GameObject Brick_94;
    public GameObject Brick_95;
    public GameObject Brick_96;
    public GameObject Brick_97;
    public GameObject Brick_98;
    public GameObject Brick_A;
    public GameObject Brick_B;
    public GameObject Brick_C;
    public GameObject Brick_D;
    public GameObject Brick_E;
    public GameObject Brick_F;
    public GameObject Brick_G;
    public GameObject Brick_H;
    public GameObject Brick_I;
    public GameObject Brick_J;
    public GameObject Brick_K;
    public GameObject Brick_L;
    public GameObject Brick_M;
    public GameObject Brick_N;
    public GameObject Brick_O;
    public GameObject Brick_P;
    public GameObject Brick_Q;
    public GameObject Brick_R;
    public GameObject Brick_S;
    public GameObject Brick_T;
    public GameObject Brick_U;
    public GameObject Brick_V;
    public GameObject Brick_W;
    public GameObject Brick_X;
    public GameObject Brick_Y;
    public GameObject Brick_Z;
    public GameObject Brick_QUESTION;
    public GameObject Brick_EXCLAMATION;
    public GameObject Brick_AT;
    public GameObject Brick_HASH;
    public GameObject Brick_DOLLOR;
    public GameObject Brick_AND;
    public GameObject Brick_PERCENTAGE;
    public GameObject BouncePad_1;
    public GameObject BouncePad_2;


















    GameObject instObj;

    public Material BlueMaterial;
    public Material BrownMaterial;
    public Material GreenMaterial;
    public Material IndigoMaterial;
    public Material OrangeMaterial;
    public Material RedMaterial;
    public Material RoseMaterial;
    public Material VioletMaterial;
    public Material YellowMaterial;






    string materialName;

    public Text getLevelNum;


    // Use this for initialization
  public  void OnClick()
    {
        //  xmlFiles = new TextAsset[1];

        LevelObjectList = new List<LevelObjects>();

        ReadXMLData();
        DrawLevel();


    }


    void ReadXMLData()
    {

        int x;
        x = int.Parse(getLevelNum.text);

       
        xmlFile = xmlFiles[x];
       

        //  TextAsset xmlFile = (TextAsset)Resources.Load("Assets/XML/Level1.xml");

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(xmlFile.text);


        XmlNodeList nodeList = xmlDoc.GetElementsByTagName("ObjectList");
        foreach (XmlNode title in nodeList)
        {
            XmlNodeList ChildLvlObjList = title.ChildNodes;

            foreach (XmlNode childLvlObj in ChildLvlObjList)
            {
                LevelObjects lvlObjc = new LevelObjects();

                lvlObjc.posX = float.Parse(childLvlObj.Attributes["posX"].Value);
                lvlObjc.posY = float.Parse(childLvlObj.Attributes["posY"].Value);
                lvlObjc.posZ = float.Parse(childLvlObj.Attributes["posZ"].Value);

                lvlObjc.rotX = float.Parse(childLvlObj.Attributes["rotX"].Value);
                lvlObjc.rotY = float.Parse(childLvlObj.Attributes["rotY"].Value);
                lvlObjc.rotZ = float.Parse(childLvlObj.Attributes["rotZ"].Value);

                lvlObjc.scaleX = float.Parse(childLvlObj.Attributes["scaleX"].Value);
                lvlObjc.scaleY = float.Parse(childLvlObj.Attributes["scaleY"].Value);
                lvlObjc.sclaeZ = float.Parse(childLvlObj.Attributes["scaleZ"].Value);

                lvlObjc.name = childLvlObj.Attributes["name"].Value;
                lvlObjc.tag = childLvlObj.Attributes["tag"].Value;

                materialName = childLvlObj.Attributes["Material"].Value;

                if (childLvlObj.Attributes["RotateX"].Value == "Y")
                {
                    lvlObjc.RotateX = true;
                }
                else if (childLvlObj.Attributes["RotateX"].Value == "N")
                {
                    lvlObjc.RotateX = false;
                }

                if (childLvlObj.Attributes["RotateY"].Value == "Y")
                {
                    lvlObjc.RotateY = true;
                }
                else if (childLvlObj.Attributes["RotateY"].Value == "N")
                {
                    lvlObjc.RotateY = false;
                }


                if (childLvlObj.Attributes["RotateZ"].Value == "Y")
                {
                    lvlObjc.RotateZ = true;
                }
                else if (childLvlObj.Attributes["RotateZ"].Value == "N")
                {
                    lvlObjc.RotateZ = false;
                }


                LevelObjectList.Add(lvlObjc);
            }
        }


    }

    void DrawLevel()
    {


        foreach (LevelObjects lvlObjs in LevelObjectList)
            switch (lvlObjs.tag)
            {



                case "Brick":

                    //if (lvlObjs.name == "Brick_11")
                    instObj = GameObject.Find(lvlObjs.name);

                    Instantiate(instObj, new Vector3(lvlObjs.posX, lvlObjs.posY, lvlObjs.posZ), Quaternion.Euler(new Vector3(lvlObjs.rotX, lvlObjs.rotY, lvlObjs.rotZ)));
                    if (materialName == "BlueMaterial")
                        instObj.GetComponent<Renderer>().material = BlueMaterial;
                    if (materialName == "BrownMaterial")
                        instObj.GetComponent<Renderer>().material = BrownMaterial;
                    if (materialName == "GreenMaterial")
                        instObj.GetComponent<Renderer>().material = GreenMaterial;
                    if (materialName == "IndigoMaterial")
                        instObj.GetComponent<Renderer>().material = IndigoMaterial;
                    if (materialName == "OrangeMaterial")
                        instObj.GetComponent<Renderer>().material = OrangeMaterial;
                    if (materialName == "RedMaterial")
                        instObj.GetComponent<Renderer>().material = RedMaterial;
                    if (materialName == "RoseMaterial")
                        instObj.GetComponent<Renderer>().material = RoseMaterial;
                    if (materialName == "VioletMaterial")
                        instObj.GetComponent<Renderer>().material = VioletMaterial;
                    if (materialName == "YellowMaterial")
                        instObj.GetComponent<Renderer>().material = YellowMaterial;


                    if (lvlObjs.RotateX == true)
                        lvlObjs.GetComponent<RotateXaxis>().enabled = true;

                    if (lvlObjs.RotateY == true)
                        lvlObjs.GetComponent<RotateYaxis>().enabled = true;

                    if (lvlObjs.RotateZ == true)
                        lvlObjs.GetComponent<RotateZaxis>().enabled = true;

                    break;

            }
    }

}
