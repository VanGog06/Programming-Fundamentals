/*
Write a program that parses an URL given in the following format:
[protocol]://[server]/[resource]

The parsing extracts its parts: protocol, server and resource. 
•	The [server] part is mandatory.
•	The [protocol] and [resource] parts are optional.

Examples
Input	                                            Output
http://www.abc.com/video	                        [protocol] = "http"
                                                    [server] = "www.abc.com"
                                                    [resource] = "video"

https://www.softuni.bg/Resources/Materials	        [protocol] = "https"
                                                    [server] = "www.softuni.bg"
                                                    [resource] = "Resources/Materials"

ftp://www.su.us/TestResource	                    [protocol] = "ftp"
                                                    [server] = "www.su.us"
                                                    [resource] = "TestResource"

https://softuni.bg	                                [protocol] = "https"
                                                    [server] = "softuni.bg"
                                                    [resource] = ""

www.nakov.com	                                    [protocol] = ""
                                                    [server] = "www.nakov.com"
                                                    [resource] = ""
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.URLParser
{
    class URLParser
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();

            string protocol = string.Empty;
            string server = string.Empty;
            string resource = string.Empty;

            int protocolIndex = url.IndexOf("://");
            int resourceIndex = 0;

            if (protocolIndex != -1)
            {
                resourceIndex = url.IndexOf("/", protocolIndex + 3);
            }
            else
            {
                resourceIndex = url.IndexOf("/");
            }

            if (protocolIndex == -1 && resourceIndex == -1)
            {
                server = url;
            }
            else if (protocolIndex == -1)
            {
                server = url.Substring(0, resourceIndex);
                resource = url.Substring(resourceIndex + 1, url.Length - resourceIndex - 1);
            }
            else if (resourceIndex == -1)
            {
                protocol = url.Substring(0, protocolIndex);
                server = url.Substring(protocolIndex + 3, url.Length - protocolIndex - 3);
            }
            else
            {
                protocol = url.Substring(0, protocolIndex);
                server = url.Substring(protocolIndex + 3, resourceIndex - protocolIndex - 3);
                resource = url.Substring(resourceIndex + 1, url.Length - 1 - resourceIndex);
            }

            Console.WriteLine("[protocol] = \"" + protocol + "\"");
            Console.WriteLine("[server] = \"" + server + "\"");
            Console.WriteLine("[resource] = \"" + resource + "\"");
        }
    }
}
