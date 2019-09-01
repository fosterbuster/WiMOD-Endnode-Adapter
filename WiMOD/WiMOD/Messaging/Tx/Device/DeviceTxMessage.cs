﻿// <copyright file="DeviceTxMessage.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace WiMOD.Messaging.Tx.Device
{
    /// <summary>
    /// Message to be transmitted to the device management SAP.
    /// </summary>
    public class DeviceTxMessage : TxHciMessage
    {
        private readonly DeviceManagementMessageIdentifier _messageIdentifier;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTxMessage"/> class.
        /// </summary>
        /// <param name="messageIdentifier">Message type identifier.</param>
        /// <param name="payload">the payload.</param>
        public DeviceTxMessage(DeviceManagementMessageIdentifier messageIdentifier, List<byte> payload)
            : base(EndpointIdentifier.DeviceManager, payload)
        {
            _messageIdentifier = messageIdentifier;
        }

        /// <summary>
        /// Gets the message identifier.
        /// </summary>
        public override byte MessageIdentifier => (byte)_messageIdentifier;
    }
}