using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gestionare_Parc_Auto.Classes
{
    class Criptografie
    {
        public  string PassHash(string data)
        {
            SHA1 sHA1 = SHA1.Create();
            //criptare, cand adaug inregistrare in baza de date, in tabela useri,  parola sa fie criptata
            //iar cand ma loghez  , ma loghez cu paroal pe care am pus-o  
            //array de biti ce le transform in string, sau o varianta mai era sa pun varbinary in  tabele2_users

            //Functiile hash md5 si sha1 sau functiile de dispersie, cum se mai numesc,  sunt unidirectionale,
            //adica nu pot fi decriptate; functiile sunt folosite de regula pentru protejarea parolelor.

            byte[] hashdata = sHA1.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder returnValue = new StringBuilder();

            for(int i=0; i< hashdata.Length; i++)
            {
                returnValue.Append(hashdata[i].ToString());
            }

            return returnValue.ToString();
            
        }
    }
}
