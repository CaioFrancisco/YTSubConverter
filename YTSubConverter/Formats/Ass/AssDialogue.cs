﻿using System;

namespace Arc.YTSubConverter.Formats.Ass
{
    internal class AssDialogue
    {
        public AssDialogue(AssDocumentItem item)
        {
            Start = item.GetTimestamp("Start");
            End = item.GetTimestamp("End");
            Style = item.GetString("Style");
            Effect = item.GetString("Effect");
            Text = item.GetString("Text");
        }

        public DateTime Start
        {
            get;
        }

        public DateTime End
        {
            get;
        }

        public string Style
        {
            get;
        }

        public string Effect
        {
            get;
        }

        public string Text
        {
            get;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
