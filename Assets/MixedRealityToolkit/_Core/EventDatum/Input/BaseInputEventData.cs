﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Internal.Interfaces.InputSystem;
using UnityEngine.EventSystems;

namespace Microsoft.MixedReality.Toolkit.Internal.EventDatum.Input
{
    /// <summary>
    /// Base class of all Input Events.
    /// </summary>
    public abstract class BaseInputEventData : BaseEventData
    {
        /// <summary>
        /// The source the input event originates from.
        /// </summary>
        public IMixedRealityInputSource InputSource { get; private set; }

        /// <summary>
        /// The id of the source the event is from, for instance the hand id.
        /// </summary>
        public uint SourceId { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="eventSystem">Typically will be <see cref="EventSystem.current"/></param>
        public BaseInputEventData(EventSystem eventSystem) : base(eventSystem) { }

        /// <summary>
        /// Used to initialize/reset the event and populate the data.
        /// </summary>
        /// <param name="inputSource"></param>
        protected void BaseInitialize(IMixedRealityInputSource inputSource)
        {
            Reset();
            InputSource = inputSource;
            SourceId = InputSource.SourceId;
        }
    }
}