﻿using OpenNLP.Tools.SentenceDetect;
using System.Reflection;

namespace TextRank.POSTagger
{
    internal static class SentencePOSTagger
    {
        //private static string _modelPath = AppDomain.CurrentDomain.BaseDirectory + "/Resources/Models/";
        private static string _modelPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Resources/Models/";
        private static EnglishMaximumEntropySentenceDetector _sentence_tokenizer = new EnglishMaximumEntropySentenceDetector(_modelPath + "/EnglishSD.nbin");

        public static string[] GetTaggedSentences(string paragraph)
        {
            return _sentence_tokenizer.SentenceDetect(paragraph.Trim());
        }
    }
}
