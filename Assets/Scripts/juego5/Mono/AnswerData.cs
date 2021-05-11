using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerData : MonoBehaviour {

    #region Variables

    [Header("UI Elements")]
    [SerializeField] TextMeshProUGUI infoTextObject = null;
    [SerializeField] Image toggle = null;

    [Header("Textures")]
    [SerializeField] Sprite uncheckedToggle = null;
    [SerializeField] Sprite checkedToggle = null;

    [Header("References")]
    [SerializeField] GameEvents events = null;

    private RectTransform _rect = null;
    public RectTransform Rect
    {
        get
        {
            if (_rect == null)
            {
                _rect = GetComponent<RectTransform>() ?? gameObject.AddComponent<RectTransform>();
            }
            return _rect;
        }
    }

    private int _answerIndex = -1;
    public int AnswerIndex {get{return _answerIndex;}}

    private bool Checked = false;

    #endregion

    
    /// Función a la que se llama para actualizar los datos de respuesta.
    
    public void UpdateData (string info, int index)
    {
        infoTextObject.text = info;
        _answerIndex = index;
    }
    
    /// Función que se llama para restablecer los valores a los predeterminados.
    
    public void Reset ()
    {
        Checked = false;
        UpdateUI();
    }
    
    /// Función que se llama para cambiar el estado.
    
    public void SwitchState ()
    {
        Checked = !Checked;
        UpdateUI();

        if (events.UpdateQuestionAnswer != null)
        {
            events.UpdateQuestionAnswer(this);
        }
    }
    
    /// Función que se llama para actualizar la interfaz de usuario.
    
    void UpdateUI ()
    {
        if (toggle == null) return;

        toggle.sprite = (Checked) ? checkedToggle : uncheckedToggle;
    }
}