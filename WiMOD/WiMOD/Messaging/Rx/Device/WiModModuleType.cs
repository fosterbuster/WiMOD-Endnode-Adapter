﻿// <copyright file="WiModModuleType.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace WiMOD.Messaging.Rx.Device
{
    /// <summary>
    /// Module types for WiMod.
    /// </summary>
    public enum WiModModuleType : byte
    {
#pragma warning disable SA1602 // Enumeration items should be documented
        IM8880A = 0x90,
        IM889AL = 0x92,
        IU880A = 0x93,
        IM880BL = 0x98,
        IU880B = 0x99,
        IM980A = 0x9A,
        IM881A = 0xA0,
#pragma warning restore SA1602 // Enumeration items should be documented
    }
}