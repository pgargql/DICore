//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace PRI.DICore.SystemNetHttp
{
    
    
    /// <summary>
    /// Default implementation of <sealso cref="IHttpClientHandler" />
    /// </summary>
    public sealed partial class HttpClientHandler : IHttpClientHandler
    {
        
        private System.Net.Http.HttpClientHandler containedObject;
        
        public HttpClientHandler(System.Net.Http.HttpClientHandler containedObject)
        {
            if ((containedObject == null))
            {
                throw new System.ArgumentNullException("containedObject");
            }
            this.containedObject = containedObject;
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.SupportsAutomaticDecompression"/>
        /// </summary>
        public bool SupportsAutomaticDecompression
        {
            get
            {
                return this.containedObject.SupportsAutomaticDecompression;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.SupportsProxy"/>
        /// </summary>
        public bool SupportsProxy
        {
            get
            {
                return this.containedObject.SupportsProxy;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.SupportsRedirectConfiguration"/>
        /// </summary>
        public bool SupportsRedirectConfiguration
        {
            get
            {
                return this.containedObject.SupportsRedirectConfiguration;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.UseCookies"/>
        /// </summary>
        public bool UseCookies
        {
            get
            {
                return this.containedObject.UseCookies;
            }
            set
            {
                this.containedObject.UseCookies = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.CookieContainer"/>
        /// </summary>
        public System.Net.CookieContainer CookieContainer
        {
            get
            {
                return this.containedObject.CookieContainer;
            }
            set
            {
                this.containedObject.CookieContainer = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.ClientCertificateOptions"/>
        /// </summary>
        public System.Net.Http.ClientCertificateOption ClientCertificateOptions
        {
            get
            {
                return this.containedObject.ClientCertificateOptions;
            }
            set
            {
                this.containedObject.ClientCertificateOptions = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.AutomaticDecompression"/>
        /// </summary>
        public System.Net.DecompressionMethods AutomaticDecompression
        {
            get
            {
                return this.containedObject.AutomaticDecompression;
            }
            set
            {
                this.containedObject.AutomaticDecompression = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.UseProxy"/>
        /// </summary>
        public bool UseProxy
        {
            get
            {
                return this.containedObject.UseProxy;
            }
            set
            {
                this.containedObject.UseProxy = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.Proxy"/>
        /// </summary>
        public System.Net.IWebProxy Proxy
        {
            get
            {
                return this.containedObject.Proxy;
            }
            set
            {
                this.containedObject.Proxy = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.PreAuthenticate"/>
        /// </summary>
        public bool PreAuthenticate
        {
            get
            {
                return this.containedObject.PreAuthenticate;
            }
            set
            {
                this.containedObject.PreAuthenticate = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.UseDefaultCredentials"/>
        /// </summary>
        public bool UseDefaultCredentials
        {
            get
            {
                return this.containedObject.UseDefaultCredentials;
            }
            set
            {
                this.containedObject.UseDefaultCredentials = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.Credentials"/>
        /// </summary>
        public System.Net.ICredentials Credentials
        {
            get
            {
                return this.containedObject.Credentials;
            }
            set
            {
                this.containedObject.Credentials = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.AllowAutoRedirect"/>
        /// </summary>
        public bool AllowAutoRedirect
        {
            get
            {
                return this.containedObject.AllowAutoRedirect;
            }
            set
            {
                this.containedObject.AllowAutoRedirect = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.MaxAutomaticRedirections"/>
        /// </summary>
        public int MaxAutomaticRedirections
        {
            get
            {
                return this.containedObject.MaxAutomaticRedirections;
            }
            set
            {
                this.containedObject.MaxAutomaticRedirections = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.MaxRequestContentBufferSize"/>
        /// </summary>
        public long MaxRequestContentBufferSize
        {
            get
            {
                return this.containedObject.MaxRequestContentBufferSize;
            }
            set
            {
                this.containedObject.MaxRequestContentBufferSize = value;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.HttpClientHandler.Dispose"/>
        /// </summary>
        public void Dispose()
        {
            this.containedObject.Dispose();
        }
    }
}