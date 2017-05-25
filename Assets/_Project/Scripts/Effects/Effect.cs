﻿using System;
using UnityEngine;

namespace _Project.Scripts.Effects
{
    public abstract class Effect : MonoBehaviour
    {
        /// <summary>
        /// Tries to apply the given effect to the given game object. Succeeds if the game object has the component that the effect targets.
        /// </summary>
        /// <param name="effectPrefab">Effect prefab to apply.</param>
        /// <param name="gameObj">Game object to apply the effect to.</param>
        /// <param name="instantiatedEffect">reference to the instantiated effect. null if not succesfull.</param>
        /// <returns>true if the effect was succesfully applied, false otherwise.</returns>
        public static bool TryApplyEffect(Effect effectPrefab, GameObject gameObj)
        {
            //Each effect has a target component. If the game object does not have this component, we do not continue.
            if (!effectPrefab.HasTargetComponent(gameObj))
                return false;

            //Instantiate the prefab.
            Effect instantiatedEffect = Instantiate(effectPrefab, gameObj.transform);
            instantiatedEffect.Apply(gameObj);
            return true;
        }

        public abstract bool HasTargetComponent(GameObject gameObj);
        protected abstract void Apply(GameObject gameObj);
    }
}
