﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters{

    [CreateAssetMenu(menuName = ("RPG/Special Ability/Power Attack"))] 
    public class PowerAttackConfig : SpecialAbilityConfig {

        [Header("Power Attack Specific")]
        [SerializeField] float extraDamage = 10f;

        public override void AttachComponentTo(GameObject gameObjectToattachTo)
        {
            var behaviourComponent = gameObjectToattachTo.AddComponent<PowerAttackBehaviour>();
            behaviourComponent.SetConfig(this);
            behaviour = behaviourComponent;
        }

        public float GetExtraDamage()
        {
            return extraDamage;
        }
    }
}
