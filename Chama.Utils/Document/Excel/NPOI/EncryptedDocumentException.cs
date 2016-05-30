﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chama.Utils.NPOI
{
    [Serializable]
    public class EncryptedDocumentException : InvalidOperationException
    {
        public EncryptedDocumentException(String s)
            : base(s)
        { }

    }
}
