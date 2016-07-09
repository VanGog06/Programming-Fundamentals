/*
You have some text that contains your email address. You’re sick of spammers, so you want to hide it. You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain.
Assume your email address will always be in format [username]@[domain]. You need to replace the username with asterisks of equal number of letters and keep the domain unchanged.
Input
•	The first line holds your email address.
•	The second line holds a text where the email should be censored.

Examples
Input
pesho.peshev@email.bg
My name is Pesho Peshev. I am from Sofia, my email is: pesho.peshev@email.bg (not pesho.peshev@email.com). Test: pesho.meshev@email.bg, pesho.peshev@email.bg

Output
My name is Pesho Peshev. I am from Sofia, my email is: ************@email.bg (not pesho.peshev@email.com). Test: pesho.meshev@email.bg, ************@email.bg
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CensorYourEmail
{
    class CensorYourEmail
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string input = Console.ReadLine();

            int index = email.IndexOf("@");

            string username = email.Substring(0, index);
            string domain = email.Substring(index, email.Length - index);

            string replacementEmail = new string('*', username.Length) + domain;

            Console.WriteLine(input.Replace(email, replacementEmail));
        }
    }
}
