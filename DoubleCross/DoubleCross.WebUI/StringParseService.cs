﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DoubleCross.Core
{
    public class StringParseService
    {
        public List<string> PlayerNames(string playerNames)
        {
            List<string> PlayerList = playerNames.Split(',').ToList();

            return PlayerList;
        }

        public List<string> PhoneNumbers(string phoneNumbers)
        {

            return new List<string>();
        }

    }

    //public interface IStringParseService
    //{
    //    List<string> PlayerNames(string playerNames);
    //    List<string> PhoneNumbers(string phoneNumbers);

    //}
}
