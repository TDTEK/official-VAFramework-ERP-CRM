﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VAdvantage.Model;
using VAdvantage.Utility;
using System.Data;
using VAdvantage.DataBase;

namespace VAdvantage.Model
{
    class MGmailConfiguration : X_AD_GmailConfiguration
    {


        public MGmailConfiguration(Ctx ctx, int GmailContactsSettings_ID, Trx trxName)
            : base(ctx, GmailContactsSettings_ID, trxName)
        {

        }

        public MGmailConfiguration(Ctx ctx, DataRow rs, Trx trxName)
            : base(ctx, rs, trxName)
        {
            //super(ctx, rs, trxName);
        }

    }
}
