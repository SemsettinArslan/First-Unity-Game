using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class DoTweenHandler : MonoBehaviour
{
    // Karakter coin toplad���nda yaz�n�n b�y�y�p k���lmesini sa�lama.
    public void textTween(TextMeshProUGUI textObject)
    {
        DOTween.To(() => textObject.fontSize, x => textObject.fontSize = x, 50f, 0.5f)
        .OnComplete(() => DOTween.To(() => textObject.fontSize, x => textObject.fontSize = x, 36f, 0.5f));
    }
}
