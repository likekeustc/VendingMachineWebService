﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MSData
{
    [DataContract(Namespace = "http://vendnovation.com/")]
    public class SaleCompletedResult
    {
        bool approved = false;
        string error = "";

        [DataMember]
        public bool Approved
        {
            get { return approved; }
            set { approved = value; }
        }

        [DataMember]
        public string Error
        {
            get { return error; }
            set { error = value; }
        }
    }
}