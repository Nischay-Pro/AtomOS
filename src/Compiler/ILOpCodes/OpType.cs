﻿/*
* PROJECT:          Atomix Development
* LICENSE:          Copyright (C) Atomix Development, Inc - All Rights Reserved
*                   Unauthorized copying of this file, via any medium is
*                   strictly prohibited Proprietary and confidential.
* PURPOSE:          MSIL OpType
* PROGRAMMERS:      Aman Priyadarshi (aman.eureka@gmail.com)
*/

using System;
using System.Reflection;

namespace Atomix.ILOpCodes
{
    public class OpType : ILOpCode
    {
        public readonly Type Value;

        public OpType(ILCode aCode, int aPosition, int aNextPosition, Type aValue, ExceptionHandlingClause aEhc)
            : base(aCode, aPosition, aNextPosition, aEhc)
        {
            Value = aValue;
        }

        public override string ToString()
        {
            return string.Format("ILOpCode=>Type    [0x{1}-0x{2}] {0}:     {3}", Code, Position.ToString("X").PadLeft(3, '0'), NextPosition.ToString("X").PadLeft(3, '0'), Value);
        }
    }
}
