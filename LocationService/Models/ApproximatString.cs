using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class ApproximatString
    {
        string s;
        int i, j, k, loi, saiSo;
        public ApproximatString(string nhap)
        {
            s = nhap;
            saiSo = (int)Math.Round(s.Length * 0.2);
        }
        public bool SoSanh(string s1)
        {
            if (s1.Length < (s.Length - saiSo) || s1.Length > (s.Length + saiSo))
                return false;
            i = j = loi = 0;
            while (i < s.Length && j < s1.Length)
            {
                if (s[i] != s1[j])
                {
                    loi++;
                    for (k = 1; k <= saiSo; k++)
                    {
                        if ((i + k < s.Length) && s[i + k] == s1[j])
                        {
                            i += k;
                            break;
                        }
                        else if ((j + k < s1.Length) && s[i] == s1[j + k])
                        {
                            j += k;
                            break;
                        }
                    }
                }
                i++;
                j++;
            }
            loi += s.Length - i + s1.Length - j;
            if (loi <= saiSo)
                return true;
            else return false;
        }
    }
}