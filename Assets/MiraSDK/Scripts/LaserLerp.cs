﻿// Copyright (c) Mira Labs, Inc., 2017. All rights reserved.
//
// Downloading and/or using this MIRA SDK is under license from MIRA,
// and subject to all terms and conditions of the Mira SDK License Agreement,
// found here: https://www.mirareality.com/Mira_SDK_License_Agreement.pdf
//
// By downloading this SDK, you agree to the Mira SDK License Agreement.
//
// This SDK may only be used in connection with the development of
// applications that are exclusively created for, and exclusively available
// for use with, MIRA hardware devices. This SDK may only be commercialized
// in the U.S. and Canada, subject to the terms of the License.

using UnityEngine;

namespace Mira
{
    /// <summary>
    /// Lerps the controller laser pointer to match the reticle position.
    /// This makes the transition between the graphics and physics raycast more seamless.
    /// </summary>
    public class LaserLerp : MonoBehaviour
    {
        public float laserLerpSpeed = 5f;


        private void Update()
        {
			Quaternion lookAtReticle = Quaternion.LookRotation(MiraController.Direction, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, lookAtReticle, Time.fixedDeltaTime * laserLerpSpeed);
        }
    }
}