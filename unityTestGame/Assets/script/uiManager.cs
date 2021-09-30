using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class uiManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int outX = 1500;
    public RectTransform loginMenu, infoMenu;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void loginBtn(RectTransform target)
    {


        target.DOAnchorPos(new Vector2(0, target.anchoredPosition.y), 0.25f);
        loginMenu.DOAnchorPos(new Vector2(outX, loginMenu.anchoredPosition.y), 0.25f);

    }
    public void infoCloseBtn(RectTransform target)
    {


        target.DOAnchorPos(new Vector2(0, target.anchoredPosition.y), 0.25f);
        infoMenu.DOAnchorPos(new Vector2(outX, infoMenu.anchoredPosition.y), 0.25f);

    }

}
