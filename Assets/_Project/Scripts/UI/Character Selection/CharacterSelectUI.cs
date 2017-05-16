﻿using InControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectUI : MonoBehaviour
{
    #region Internal Variables
    private CharacterSelectHeadShot[] _headshots;
    private CharacterSelectHeadShot _selectedHeadShot;
    #endregion

    #region Properties
    public InputDevice _controller;
    #endregion

    private void Awake()
    {
        _headshots = GetComponentsInChildren<CharacterSelectHeadShot>();
    }

    private void Start()
    {
        ChangeSelectionTo(_headshots[0]);
    }

    /// <summary>
    /// Changes the currently selected headshot to the given headshot.
    /// </summary>
    /// <param name="headshot">The headshot to be selected.</param>
    private void ChangeSelectionTo(CharacterSelectHeadShot headshot)
    {
        //Unselect the current selection.
        if(_selectedHeadShot != null)
            _selectedHeadShot.Unselect();

        //Select the new headshot.
        _selectedHeadShot = headshot;
        _selectedHeadShot.Select();
    }
}
