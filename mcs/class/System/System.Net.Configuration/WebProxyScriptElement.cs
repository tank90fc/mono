//
// System.Net.Configuration.WebProxyScriptElement
//
// Authors:
//	Chris Toshok (toshok@ximian.com)
//
// (C) 2005 Novell, Inc. (http://www.novell.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if NET_2_0 && CONFIGURATION_DEP

using System;
using System.Configuration;

namespace System.Net.Configuration {

        public sealed class WebProxyScriptElement : ConfigurationElement
        {
                static ConfigurationProperty downloadTimeoutProp;
                static ConfigurationPropertyCollection properties;

                static WebProxyScriptElement ()
                {
                        downloadTimeoutProp = new ConfigurationProperty ("downloadTimeout", typeof (TimeSpan), new TimeSpan (0,0,2,0));
                        properties = new ConfigurationPropertyCollection ();

                        properties.Add (downloadTimeoutProp);
                }

                protected override void PostDeserialize ()
                {
                }

                [ConfigurationProperty ("downloadTimeout", DefaultValue = "00:02:00")]
                public TimeSpan DownloadTimeout {
                        get { return (TimeSpan) base [downloadTimeoutProp];}
                        set { base[downloadTimeoutProp] = value; }
                }

                protected override ConfigurationPropertyCollection Properties {
                        get { return properties; }
                }
        }

}

#endif
