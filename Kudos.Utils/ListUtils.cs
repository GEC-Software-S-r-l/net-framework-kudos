﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudos.Utils
{
    public static class ListUtils
    {
        public static Boolean IsValidIndex(IList oList, Int32 i32Index)
        {
            return
                oList != null
                && i32Index > -1
                && i32Index < oList.Count;
        }
    }
}