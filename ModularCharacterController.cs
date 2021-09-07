using System;
using System.Collections.Generic;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.GameFoundation;

namespace _Project.Scripts
{
    [Serializable]
    public enum Gender
    {
        Male,
        Female
    }
    
    [Serializable]
    public enum PartType
    {
        Helmet,
        HeadAttachment,
        Head,
        Hat,
        Mask,
        HeadCovering,
        Hair,
        Eyebrows,
        Ear,
        FacialHair,
        BackAttachment,
        Torso,
        ShoulderAttachmentRight,
        ShoulderAttachmentLeft,
        ArmUpperRight,
        ArmUpperLeft,
        ElbowAttachmentRight,
        ElbowAttachmentLeft,
        ArmLowerRight,
        ArmLowerLeft,
        HandRight,
        HandLeft,
        HipsAttachment,
        Hips,
        KneeAttachmentRight,
        KneeAttachmentLeft,
        LegRight,
        LegLeft
    }
    
    public class ModularCharacterController : MonoBehaviour, ISavable
    {
        [SerializeField] private Gender gender;

        [SerializeField] private Material material;
        [SerializeField] private Equipment equipment;

        [Header("Active Parts")]
        public ActivePartMap activeParts;
        
        [Header("Male Parts")]
        public PartMap maleParts;
        
        [Header("Female Parts")]
        public PartMap femaleParts;
        
        [Header("Universal Parts")]
        public PartMap genderNeutralParts;
        
        private List<PartType> genderSpecificPartTypes = new List<PartType>
        {
            PartType.Head,
            PartType.Eyebrows,
            PartType.FacialHair,
            PartType.Torso,
            PartType.ArmUpperRight,
            PartType.ArmUpperLeft,
            PartType.ArmLowerRight,
            PartType.ArmLowerLeft,
            PartType.HandRight,
            PartType.HandLeft,
            PartType.Hips,
            PartType.LegRight,
            PartType.LegLeft
        };
        
        private List<PartType> genderNeutralPartTypes = new List<PartType>
        {
            PartType.Hair,
            PartType.Helmet,
            PartType.HeadAttachment,
            PartType.Mask,
            PartType.Hat,
            PartType.HeadCovering,
            PartType.Ear,
            PartType.BackAttachment,
            PartType.ElbowAttachmentRight,
            PartType.ElbowAttachmentLeft,
            PartType.HipsAttachment,
            PartType.ShoulderAttachmentRight,
            PartType.ShoulderAttachmentLeft,
            PartType.KneeAttachmentRight,
            PartType.KneeAttachmentLeft
        };

        private void Start()
        {
            if (activeParts.parts.Count == 0)
            {
                activeParts = new ActivePartMap();

                foreach (PartType partType in Enum.GetValues(typeof(PartType)))
                {
                    activeParts.parts.Add(new ActivePart(partType, -1));
                }

                foreach (PartType type in genderSpecificPartTypes)
                {
                    ActivatePart(type, 0);
                }
            }
            else
            {
                foreach (var activePart in activeParts.parts)
                {
                    if (activePart.id != -1)
                        ActivatePart(activePart.type, activePart.id);   
                }
            }
            
            ChangeColor("_Color_Hair", material.GetColor("_Color_Hair"));
            ChangeColor("_Color_Skin", material.GetColor("_Color_Skin"));
        }

        private void OnEnable()
        {
            equipment.OnEquip += Equip;
            equipment.OnUnEquip += UnEquip;
        }

        private void OnDisable()
        {
            equipment.OnEquip -= Equip;
            equipment.OnUnEquip -= UnEquip;
        }

        public void ChangeColor(string name, Color color)
        {
            material.SetColor(name, color);
            ApplyMaterialToParts(transform);
        }

        public void ChangeGender(Gender gender)
        {
            foreach (PartType type in genderSpecificPartTypes)
            {
                DeactivatePart(type, activeParts[type].id);
            }
            
            this.gender = gender;
            
            foreach (PartType type in genderSpecificPartTypes)
            {
                ActivatePart(type, 0);
            }
        }

        public Gender GetGender()
        {
            return gender;
        }

        private void ApplyMaterialToParts(Transform parent)
        {
            if (parent.childCount > 0)
            {
                foreach (Transform child in parent)
                {
                    ApplyMaterialToParts(child);
                }
            }
            else
            {
                var parentRenderer = parent.GetComponent<Renderer>();
                
                if (parentRenderer)
                {
                    parentRenderer.sharedMaterial = material;
                }
            }
        }

        private void Equip(InventoryItem inventoryItem)
        {
            string type = inventoryItem.definition.GetStaticProperty("type").AsString();

            if (type == "armor")
            {
                Armor armor = inventoryItem.definition.GetStaticProperty("armor").AsAsset<Armor>();
                
                foreach (ArmorPart part in armor.parts)
                {
                    if (activeParts[part.type].id == 0)
                        DeactivatePart(part.type, activeParts[part.type].id);
                    
                    ActivatePart(part.type, part.id);
                }
            }
        }

        private void UnEquip(InventoryItem inventoryItem)
        {
            string type = inventoryItem.definition.GetStaticProperty("type").AsString();

            if (type == "armor")
            {
                Armor armor = inventoryItem.definition.GetStaticProperty("armor").AsAsset<Armor>();
                
                foreach (ArmorPart part in armor.parts)
                {
                    DeactivatePart(part.type, part.id);
            
                    if (genderSpecificPartTypes.Contains(part.type))
                    {
                        ActivatePart(part.type, 0);
                    }
                }
            }
        }
        
        public void ActivatePart(PartType type, int id)
        {
            if (genderNeutralPartTypes.Contains(type))
            {
                genderNeutralParts[type][id].SetActive(true);
            }
            else
            {
                if (gender == Gender.Female)
                {
                    femaleParts[type][id].SetActive(true);
                }
                else
                {
                    maleParts[type][id].SetActive(true);
                }
            }
            
            activeParts[type].id = id;
        }
        public void DeactivatePart(PartType type, int id)
        {
            if (genderNeutralPartTypes.Contains(type))
            {
                genderNeutralParts[type][id].SetActive(false);
            }
            else
            {
                if (gender == Gender.Female)
                {
                    femaleParts[type][id].SetActive(false);
                }
                else
                {
                    maleParts[type][id].SetActive(false);
                }
            }
            
            activeParts[type].id = -1;
        }

        [ContextMenu("Setup")]
        public void Setup()
        {
            Transform genderNeutralPartsParent = transform.Find("All_Gender_Parts"); ;

            genderNeutralParts = new PartMap();
            genderNeutralParts.partLists = new List<PartList>
            {
                new PartList(PartType.Hat, GetParts(genderNeutralPartsParent.Find("All_00_HeadCoverings/HeadCoverings_Base_Hair"))),
                new PartList(PartType.Mask, GetParts(genderNeutralPartsParent.Find("All_00_HeadCoverings/HeadCoverings_No_FacialHair"))),
                new PartList(PartType.HeadCovering, GetParts(genderNeutralPartsParent.Find("All_00_HeadCoverings/HeadCoverings_No_Hair"))),
                new PartList(PartType.Hair, GetParts(genderNeutralPartsParent.Find("All_01_Hair"))),
                new PartList(PartType.HeadAttachment, GetParts(genderNeutralPartsParent.Find("All_02_Head_Attachment/Helmet"))),
                new PartList(PartType.BackAttachment, GetParts(genderNeutralPartsParent.Find("All_04_Back_Attachment"))),
                new PartList(PartType.ShoulderAttachmentRight, GetParts(genderNeutralPartsParent.Find("All_05_Shoulder_Attachment_Right"))),
                new PartList(PartType.ShoulderAttachmentLeft, GetParts(genderNeutralPartsParent.Find("All_06_Shoulder_Attachment_Left"))),
                new PartList(PartType.ElbowAttachmentRight, GetParts(genderNeutralPartsParent.Find("All_07_Elbow_Attachment_Right"))),
                new PartList(PartType.ElbowAttachmentLeft, GetParts(genderNeutralPartsParent.Find("All_08_Elbow_Attachment_Left"))),
                new PartList(PartType.HipsAttachment, GetParts(genderNeutralPartsParent.Find("All_09_Hips_Attachment"))),
                new PartList(PartType.KneeAttachmentRight, GetParts(genderNeutralPartsParent.Find("All_10_Knee_Attachement_Right"))),
                new PartList(PartType.KneeAttachmentLeft, GetParts(genderNeutralPartsParent.Find("All_11_Knee_Attachement_Left"))),
                new PartList(PartType.Ear, GetParts(genderNeutralPartsParent.Find("All_12_Extra/Elf_Ear")))
            };
            
            Transform malePartsParent = transform.Find("Male_Parts");

            maleParts = new PartMap();
            maleParts.partLists = new List<PartList>
            {
                new PartList(PartType.Helmet, GetParts(malePartsParent.Find("Male_00_Head/Male_Head_No_Elements"))),
                new PartList(PartType.Head, GetParts(malePartsParent.Find("Male_00_Head/Male_Head_All_Elements"))),
                new PartList(PartType.Eyebrows, GetParts(malePartsParent.Find("Male_01_Eyebrows"))),
                new PartList(PartType.FacialHair, GetParts(malePartsParent.Find("Male_02_FacialHair"))),
                new PartList(PartType.Torso, GetParts(malePartsParent.Find("Male_03_Torso"))),
                new PartList(PartType.ArmUpperRight, GetParts(malePartsParent.Find("Male_04_Arm_Upper_Right"))),
                new PartList(PartType.ArmUpperLeft, GetParts(malePartsParent.Find("Male_05_Arm_Upper_Left"))),
                new PartList(PartType.ArmLowerRight, GetParts(malePartsParent.Find("Male_06_Arm_Lower_Right"))),
                new PartList(PartType.ArmLowerLeft, GetParts(malePartsParent.Find("Male_07_Arm_Lower_Left"))),
                new PartList(PartType.HandRight, GetParts(malePartsParent.Find("Male_08_Hand_Right"))),
                new PartList(PartType.HandLeft, GetParts(malePartsParent.Find("Male_09_Hand_Left"))),
                new PartList(PartType.Hips, GetParts(malePartsParent.Find("Male_10_Hips"))),
                new PartList(PartType.LegRight, GetParts(malePartsParent.Find("Male_11_Leg_Right"))),
                new PartList(PartType.LegLeft, GetParts(malePartsParent.Find("Male_12_Leg_Left"))),
            };
            
            Transform femalePartsParent = transform.Find("Female_Parts");

            femaleParts = new PartMap();
            femaleParts.partLists = new List<PartList>
            {
                new PartList(PartType.Helmet, GetParts(femalePartsParent.Find("Female_00_Head/Female_Head_No_Elements"))),
                new PartList(PartType.Head, GetParts(femalePartsParent.Find("Female_00_Head/Female_Head_All_Elements"))),
                new PartList(PartType.Eyebrows, GetParts(femalePartsParent.Find("Female_01_Eyebrows"))),
                new PartList(PartType.FacialHair, GetParts(femalePartsParent.Find("Female_02_FacialHair"))),
                new PartList(PartType.Torso, GetParts(femalePartsParent.Find("Female_03_Torso"))),
                new PartList(PartType.ArmUpperRight, GetParts(femalePartsParent.Find("Female_04_Arm_Upper_Right"))),
                new PartList(PartType.ArmUpperLeft, GetParts(femalePartsParent.Find("Female_05_Arm_Upper_Left"))),
                new PartList(PartType.ArmLowerRight, GetParts(femalePartsParent.Find("Female_06_Arm_Lower_Right"))),
                new PartList(PartType.ArmLowerLeft, GetParts(femalePartsParent.Find("Female_07_Arm_Lower_Left"))),
                new PartList(PartType.HandRight, GetParts(femalePartsParent.Find("Female_08_Hand_Right"))),
                new PartList(PartType.HandLeft, GetParts(femalePartsParent.Find("Female_09_Hand_Left"))),
                new PartList(PartType.Hips, GetParts(femalePartsParent.Find("Female_10_Hips"))),
                new PartList(PartType.LegRight, GetParts(femalePartsParent.Find("Female_11_Leg_Right"))),
                new PartList(PartType.LegLeft, GetParts(femalePartsParent.Find("Female_12_Leg_Left"))),
            };
            
            foreach (PartList partList in maleParts)
            {
                foreach (GameObject part in partList)
                {
                    part.SetActive(false);
                }
            }
            
            foreach (PartList partList in femaleParts)
            {
                foreach (GameObject part in partList)
                {
                    part.SetActive(false);
                }
            }
            
            foreach (PartList partList in genderNeutralParts)
            {
                foreach (GameObject part in partList)
                {
                    part.SetActive(false);
                }
            }
        }
        
        private GameObject[] GetParts(Transform parent)
        {
            GameObject[] parts = new GameObject[parent.childCount];

            for (int i = 0; i < parent.childCount; i++)
            {
                parts[i] = parent.GetChild(i).gameObject;
            }
            
            return parts;
        }
        
        public object SaveData()
        {
            return new ModularCharacterData
            {
                activeParts = activeParts
            };
        }
        
        public void LoadData(object data)
        {
            ModularCharacterData modularCharacterData = (ModularCharacterData) data;
            activeParts = modularCharacterData.activeParts;
        }
    }
}