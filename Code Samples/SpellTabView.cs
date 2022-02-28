using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SpellTabView : MonoBehaviour
{
    [SerializeReference] TextMeshProUGUI _spellTitle;
    [SerializeReference] TextMeshProUGUI _spellDescription;
    [SerializeReference] TextMeshProUGUI _spellRequireLevel;
    [SerializeReference] Sprite _backActive;
    [SerializeReference] Sprite _backNotActive;


#if UNITY_EDITOR
    private void OnValidate()
    {
        var childs = gameObject.GetComponentsInChildren<RectTransform>(true);
        foreach (var obj in childs)
        {
            switch (obj.name)
            {
                case "_spellTitle": _title = obj.GetComponent<TextMeshProUGUI>(); 
                    break;
                case "_spellDescription": _spellDescription = obj.GetComponent<TextMeshProUGUI>(); 
                    break;
                case "_spellRequireLevel": _spellRequireLevel = obj.GetComponent<TextMeshProUGUI>(); 
                    break;
            }
        }
    }
#endif

    public void Init(string description, string requireLevel, bool isActive)
    {
        _spellDescription.text = description;
        _spellRequireLevel.text = requireLevel;

        _spellDescription.gameObject.SetActive(isActive);
        _spellRequireLevel.gameObject.SetActive(!isActive);
    }

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    public void SetTitle(string text)
    {
        _spellTitle.text = text;
    }
}