using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeGraph", menuName = "Scriptable Object/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string roomNodeTypeName;

    #region Header
    [Header("Only flag the RoomNodeTypes that should be visible in the editor")]
    #endregion Header
    public bool displayInNodeGraphEdtior = true;
    #region Header
    [Header("One Type Should Be A Corridor")]
    #endregion Header
    public bool isCorridor;
    #region Header
    [Header("One Type Should Be A CorridorNs ")]
    #endregion Header
    public bool isCorridorNS;
    #region Header
    [Header("One Type Should Be A CorridorEW")]
    #endregion Header
    public bool isCorridorEW;
    #region Header
    [Header("One Type Should Be An Entrance")]
    #endregion Header
    public bool isEntrance;
    #region Header
    [Header("One Type Should Be An Boss Room")]
    #endregion Header
    public bool isBossRoom;
    #region Header
    [Header("One Type Should Be None (Unassigned)")]
    #endregion Header
    public bool isNone;
}
