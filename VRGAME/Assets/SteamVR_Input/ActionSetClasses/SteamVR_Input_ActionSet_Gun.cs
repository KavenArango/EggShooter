//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public class SteamVR_Input_ActionSet_Gun : Valve.VR.SteamVR_ActionSet
    {
        
        public virtual SteamVR_Action_Boolean LeftTrigger
        {
            get
            {
                return SteamVR_Actions.gun_LeftTrigger;
            }
        }
        
        public virtual SteamVR_Action_Boolean RightTrigger
        {
            get
            {
                return SteamVR_Actions.gun_RightTrigger;
            }
        }
        
        public virtual SteamVR_Action_Vibration Haptic
        {
            get
            {
                return SteamVR_Actions.gun_Haptic;
            }
        }
    }
}
