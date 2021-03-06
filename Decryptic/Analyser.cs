﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decryptic
{
    class Analyser
    {
        public static readonly SortedDictionary<Char, double> EnglishFreq = new SortedDictionary<Char, double>
        {
            { 'a', 8.167 }, { 'b', 1.492 }, { 'c', 2.782 }, { 'd', 4.253 }, { 'e', 12.702 }, { 'f', 2.228 },
            { 'g', 2.015 }, { 'h', 6.094 }, { 'i', 6.966 }, { 'j', 0.153 }, { 'k', 0.772 }, { 'l', 4.025 },
            { 'm', 2.406 }, { 'n', 6.749 }, { 'o', 7.507 }, { 'p', 1.929 }, { 'q', 0.095 }, { 'r', 5.987 },
            { 's', 6.327 }, { 't', 9.056 }, { 'u', 2.758 }, { 'v', 0.978 }, { 'w', 2.360 }, { 'x', 0.150 },
            { 'y', 1.974 }, { 'z', 0.074 }
        };

        public static SortedDictionary<Char, double> frequencyAnalysis(String cipherText)
        {
            SortedDictionary<Char, double> analysis = new SortedDictionary<Char,double>
            {
                { 'a', 0 }, { 'b', 0 }, { 'c', 0 }, { 'd', 0 }, { 'e', 0 }, { 'f', 0 },
                { 'g', 0 }, { 'h', 0 }, { 'i', 0 }, { 'j', 0 }, { 'k', 0 }, { 'l', 0 },
                { 'm', 0 }, { 'n', 0 }, { 'o', 0 }, { 'p', 0 }, { 'q', 0 }, { 'r', 0 },
                { 's', 0 }, { 't', 0 }, { 'u', 0 }, { 'v', 0 }, { 'w', 0 }, { 'x', 0 },
                { 'y', 0 }, { 'z', 0 }
            };

            foreach(Char c in cipherText)
            {
                if(analysis.ContainsKey(c))
                {
                    analysis[c] = analysis[c] + 1;
                }
            }

            foreach(Char c in analysis.Keys.ToList())
            {
                analysis[c] = (analysis[c] / cipherText.Length) * 100;
            }

            return analysis;
        }
    }
}
