using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Personalities", menuName = "ScriptableObjects/Create list of personalities", order = 1)]
class PiecePersonality : ScriptableObject
{
    /// <summary>
    /// List of different personalities of the pieces, can be created more lists to create distict possibilities.
    /// </summary>
    public List<string> personalitiesList;
}
