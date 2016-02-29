using UnityEngine;

namespace HelloMod
{
    public class Main : IMod
    {
        public string Identifier { get; set; }
        GameObject _go; 
        public void onEnabled()
        {
            _go = new GameObject();
            DisableCollision DC = _go.AddComponent<DisableCollision>();
            DC.Disable();
        }

        public void onDisabled()
        {
            UnityEngine.Object.Destroy (_go);
        }

        public string Name 
        {
            get { return "DislableCollisions"; }
        }

        public string Description
        {
            get { return "DislableCollisions"; }
        }
    }
}
