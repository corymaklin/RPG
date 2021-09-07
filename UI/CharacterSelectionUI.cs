using System.Collections.Generic;
using _Project.Scripts.Managers;
using Cinemachine;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Project.Scripts.UI
{
    public class CharacterSelectionUI : BaseUI
    {
        [SerializeField] private ModularCharacterController modularCharacter;
        [SerializeField] private Stats stats;
        [SerializeField] private List<TextMeshProUGUI> statLabelTexts;
        [SerializeField] private List<TextMeshProUGUI> statValueTexts;
        [SerializeField] private TextMeshProUGUI hairText;
        [SerializeField] private TextMeshProUGUI faceText;
        [SerializeField] private TextMeshProUGUI facialHairText;
        [SerializeField] private Button prevFaceButton;
        [SerializeField] private Button nextFaceButton;
        [SerializeField] private Button prevHairButton;
        [SerializeField] private Button nextHairButton;
        [SerializeField] private Button prevFacialHairButton;
        [SerializeField] private Button nextFacialHairButton;
        [SerializeField] private Button maleButton;
        [SerializeField] private Button femaleButton;
        [SerializeField] private Transform facialHairParent;
        [SerializeField] private Button blackHairButton;
        [SerializeField] private Button brownHairButton;
        [SerializeField] private Button blondHairButton;
        [SerializeField] private Button redHairButton;
        [SerializeField] private Button paleSkinButton;
        [SerializeField] private Button lightSkinButton;
        [SerializeField] private Button tannedSkinButton;
        [SerializeField] private Button darkSkinButton;
        [SerializeField] private Button randomizeStatsButton;
        [SerializeField] private Button acceptButton;
        [SerializeField] private GameObject mirror;
        
        
        private int hairId;
        public int HairId
        {
            get => hairId;
            set
            {
                hairId = value;
                if (modularCharacter.activeParts[PartType.Hair].id != -1)
                    modularCharacter.DeactivatePart(PartType.Hair, modularCharacter.activeParts[PartType.Hair].id);
                modularCharacter.ActivatePart(PartType.Hair, hairId);
                hairText.text = $"Hair {hairId}";
            }
        }

        private int faceId;
        public int FaceId
        {
            get => faceId;
            set
            {
                faceId = value;
                modularCharacter.DeactivatePart(PartType.Head, modularCharacter.activeParts[PartType.Head].id);
                modularCharacter.ActivatePart(PartType.Head, faceId);
                faceText.text = $"Face {faceId}";
            }
        }

        private int facialHairId;
        public int FacialHairId
        {
            get => facialHairId;
            set
            {
                facialHairId = value;
                modularCharacter.DeactivatePart(PartType.FacialHair, modularCharacter.activeParts[PartType.FacialHair].id);
                modularCharacter.ActivatePart(PartType.FacialHair, facialHairId);
                facialHairText.text = $"Facial Hair {facialHairId}";
            }
        }
        private void Awake()
        {
            base.Awake();
            
            randomizeStatsButton.onClick.AddListener(RandomizeStats);
            acceptButton.onClick.AddListener(Accept);
            prevFaceButton.onClick.AddListener(PreviousFace);
            nextFaceButton.onClick.AddListener(NextFace);
            prevHairButton.onClick.AddListener(PreviousHair);
            nextHairButton.onClick.AddListener(NextHair);
            prevFacialHairButton.onClick.AddListener(PreviousFacialHair);
            nextFacialHairButton.onClick.AddListener(NextFacialHair);
            maleButton.onClick.AddListener(delegate { ChangeGender(Gender.Male); });
            femaleButton.onClick.AddListener(delegate { ChangeGender(Gender.Female); });
            blackHairButton.onClick.AddListener(delegate { ChangeHairColor(new Color(0f, 0f, 0f)); });
            blondHairButton.onClick.AddListener(delegate { ChangeHairColor( new Color(139f / 255, 109f / 255, 55f / 255)); });
            brownHairButton.onClick.AddListener(delegate { ChangeHairColor( new Color(63f / 255, 45f / 255, 13f / 255)); });
            redHairButton.onClick.AddListener(delegate { ChangeHairColor(new Color(197f / 255, 87f / 255, 18f / 255)); });
            paleSkinButton.onClick.AddListener(delegate { ChangeSkinColor( new Color(241f / 255, 210f / 255, 192f / 255)); });
            lightSkinButton.onClick.AddListener(delegate { ChangeSkinColor(new Color(1f, 204f / 255, 174f / 255)); });
            tannedSkinButton.onClick.AddListener(delegate { ChangeSkinColor(new Color(180f / 255, 127f / 255, 94f / 255)); });
            darkSkinButton.onClick.AddListener(delegate { ChangeSkinColor(new Color(91f / 255, 50f / 255, 26f / 255)); });
            
            for (int i = 0; i < statValueTexts.Count; i++)
            {
                statValueTexts[i].text = $"{stats[statLabelTexts[i].text.ToLower()].BaseValue}";
            }
        }
        
        public override void Show()
        {
            base.Show();
            if (mirror)
                mirror.SetActive(true);
        }

        public override void Hide()
        {
            base.Hide();
            if (mirror)
                mirror.SetActive(false);
        }

        private void NextFace()
        {
            FaceId = modularCharacter.GetGender() == Gender.Female
                ? (FaceId + 1) % modularCharacter.femaleParts[PartType.Head].parts.Length
                : (FaceId + 1) % modularCharacter.maleParts[PartType.Head].parts.Length;
        }

        private void PreviousFace()
        {
            if (FaceId == 0)
            {
                FaceId = modularCharacter.GetGender() == Gender.Female
                    ? modularCharacter.femaleParts[PartType.Head].parts.Length - 1
                    : modularCharacter.maleParts[PartType.Head].parts.Length - 1;
            }
            else
            {
                FaceId--;
            }
        }

        private void PreviousHair()
        {
            HairId = HairId == 0 ? modularCharacter.genderNeutralParts[PartType.Hair].parts.Length - 1 : HairId - 1;
        }

        private void NextHair()
        {
            HairId = (HairId + 1) % modularCharacter.genderNeutralParts[PartType.Hair].parts.Length;
        }
        
        private void NextFacialHair()
        {
            FacialHairId = (FacialHairId + 1) % modularCharacter.maleParts[PartType.FacialHair].parts.Length;
        }

        private void PreviousFacialHair()
        {
            FacialHairId = FacialHairId == 0
                ? facialHairId = modularCharacter.maleParts[PartType.FacialHair].parts.Length - 1
                : FacialHairId - 1;
        }

        private void ChangeGender(Gender gender)
        {
            modularCharacter.ChangeGender(gender);
            
            if (gender == Gender.Male)
            {
                facialHairParent.gameObject.SetActive(true);
            }
            else
            {
                facialHairParent.gameObject.SetActive(false);
            }
        }

        private void ChangeHairColor(Color color)
        {
            modularCharacter.ChangeColor("_Color_Hair", color);
        }
        
        private void ChangeSkinColor(Color color)
        {
            modularCharacter.ChangeColor("_Color_Skin", color);
        }

        private void RandomizeStats()
        {
            stats.Initialize(true);

            for (int i = 0; i < statValueTexts.Count; i++)
            {
                statValueTexts[i].text = $"{stats[statLabelTexts[i].text.ToLower()].BaseValue}";
            }
        }
        
        private void Accept()
        {
            SceneManager.UnloadSceneAsync("Character Selection");
            SceneManager.LoadScene("Demo_Scene", LoadSceneMode.Additive);
            // SceneManager.LoadScene("Tutorial", LoadSceneMode.Additive);
        }
    }
}