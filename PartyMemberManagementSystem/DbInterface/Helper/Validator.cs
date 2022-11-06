
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;
public static class Validator
{
    static internal bool IsDecimal(string text)
    {
        decimal tmp = default(decimal);
        dynamic canConvert = decimal.TryParse(text,out tmp);
        return canConvert;
    }

    static internal bool IsInteger(string text)
    {
        Int16 tmp = default(Int16);
        dynamic res = Int16.TryParse(text,out tmp);
        return res;
    }
    static internal bool IsEmail(string text)
    {
        dynamic result = Regex.IsMatch(text, "\\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z");
        return result;
    }

    static internal bool IsWebAddress(string text)
    {
        dynamic result = Regex.IsMatch(text, "^(|https?:\\/\\/[\\w\\-_]+(\\.[\\w\\-_]+)+([\\w\\-\\.,@?^=%&amp;:/~\\+#]*[\\w\\-\\@?^=%&amp;/~\\+#])?)$");
        return result;
    }

    static internal bool IsPhone(string text)
    {
        dynamic result = Regex.IsMatch(text, "^0[0-9]{2} [0-9]{3} [0-9]{3,4}$");
        return result;
    }
    //@"^[A-Za-z]+\d+.*$"
    static internal bool IsStrongPassword(string text)
    {
        if ((string.IsNullOrEmpty(text.Trim())))
            return false;

        dynamic result = Regex.IsMatch(text, "^[A-Za-z]+\\d+.*$");
        return result;
    }
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
