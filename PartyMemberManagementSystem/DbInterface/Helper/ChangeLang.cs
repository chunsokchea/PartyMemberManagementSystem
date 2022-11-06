using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

static class ChangeLang
{
    public static void EnglishKeyBoard()
    {
        foreach (InputLanguage language in InputLanguage.InstalledInputLanguages)
        {
            if (language.Culture.TwoLetterISOLanguageName.Contains("en") == true)
            {
                InputLanguage.CurrentInputLanguage = language;
            }
        }
    }
    public static void KhmerKeyBoard()
    {
        foreach (InputLanguage language in InputLanguage.InstalledInputLanguages)
        {
            if (language.Culture.TwoLetterISOLanguageName.Contains("km") == true)
            {
                InputLanguage.CurrentInputLanguage = language;
            }
        }
    }
}
