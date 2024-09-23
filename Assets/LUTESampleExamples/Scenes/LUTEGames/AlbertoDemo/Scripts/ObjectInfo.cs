using System;
using UnityEngine;

namespace LoGaCulture.LUTE
{
    [Serializable]
    /// <summary>
    /// Contains information about a specific object that can be used by other scripts
    /// </summary>
    public class ObjectInfo : ScriptableObject
    {
        [SerializeField] protected string objectName;
        [SerializeField] protected string objectDescription;
        [SerializeField] protected Sprite objectIcon;
        [SerializeField] protected ObjectSpinner spinningObject;
        [SerializeField] protected bool unlocked;

        public string ObjectName => objectName;
        public string ObjectDescription => objectDescription;
        public Sprite ObjectIcon => objectIcon;
        public ObjectSpinner SpinningObject => spinningObject;
        public bool Unlocked { get => unlocked; set => unlocked = value; }
    }
}
