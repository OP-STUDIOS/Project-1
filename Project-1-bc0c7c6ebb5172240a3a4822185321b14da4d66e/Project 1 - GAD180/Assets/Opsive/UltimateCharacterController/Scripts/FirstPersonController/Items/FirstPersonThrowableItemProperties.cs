﻿/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

using UnityEngine;
using Opsive.UltimateCharacterController.Items.Actions;

namespace Opsive.UltimateCharacterController.FirstPersonController.Items
{
    /// <summary>
    /// Describes any first person perspective dependent properties for the ThrowableItem.
    /// </summary>
    public class FirstPersonThrowableItemProperties : FirstPersonWeaponProperties, IThrowableItemPerspectiveProperties
    {
        [Tooltip("The location to throw the object from.")]
        [SerializeField] protected Transform m_ThrowLocation;
        [Tooltip("The location of the trajectory curve.")]
        [SerializeField] protected Transform m_TrajectoryLocation;

        [Utility.NonSerialized] public Transform ThrowLocation { get { return m_ThrowLocation; } set { m_ThrowLocation = value; } }
        [Utility.NonSerialized] public Transform TrajectoryLocation { get { return m_TrajectoryLocation; } set { m_TrajectoryLocation = value; } }
    }
}