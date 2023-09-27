using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Langile : Kontaktua
    {
        public float soldata { get; set; }
        public string SSZenb { get; set; }
        public override string email
        {
            get { return this.email; }

            set
            {
                try
                {
                    if (value.Substring(value.Length - 14, 14) != "@iesunibhi.com")
                    {
                        Exception ex = new Exception("Emaila ez duzu ondo jarri");
                        throw ex;
                    }
                    else
                    {
                        this.email = value;
                    }
                } catch(Exception e) { Console.WriteLine(e.Message); }
            }
        }


        public override string gorde()
        {
            return "Langilea ondo gorde da";
        }
    }
}
