﻿using System;
using System.Collections.Generic;

namespace ProjectTwo
{
    public class AtananKisi
    {
        
        private static readonly Dictionary<int, string> kisi = new()
        {
            { 1, "Carles" },
            { 2, "Carlos" },
            { 3, "Max" },
            { 4, "Lewis" },
            { 5, "Daniel" }
        };

        public static Dictionary<int, string> Kisi { get => kisi;  }

    }
    
}
