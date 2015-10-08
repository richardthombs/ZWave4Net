﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWave.Channel.Protocol
{
    class NodeCommandCompleted : Message
    {
        public readonly byte CallbackID;
        public readonly TransmissionState TransmissionState;
        public readonly byte UnknownByte1;
        public readonly byte UnknownByte2;

        public NodeCommandCompleted(byte[] payload) : 
            base(FrameHeader.SOF, MessageType.Request, Channel.Function.SendData)
        {
            CallbackID = payload[0];
            TransmissionState = (TransmissionState)payload[1];
            if (payload.Length > 2)
            {
                UnknownByte1 = payload[2];
            }
            if (payload.Length > 3)
            {
                UnknownByte2 = payload[3];
            }
        }

        public override string ToString()
        {
            return string.Concat(base.ToString(), " ", $"CallbackID:{CallbackID}, {TransmissionState}, {UnknownByte1}?, {UnknownByte2}?");
        }
    }
}
