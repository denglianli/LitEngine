﻿using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;
namespace LitEngine
{
    namespace NetTool
    {
        public struct SocketDataBase
        {
            static public int mFirstLen = 2;//包头长度占位
            static public int mCmdLen = 2;//cmd占位
            static public int mPackageTopLen = mFirstLen + mCmdLen;

        }
    }
}

