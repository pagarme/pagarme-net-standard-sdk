// <copyright file="IBasicAuthCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Authentication
{
    using System;

    public interface IBasicAuthCredentials
    {
        /// <summary>
        /// Gets basicAuthUserName.
        /// </summary>
        string BasicAuthUserName { get; }

        /// <summary>
        /// Gets basicAuthPassword.
        /// </summary>
        string BasicAuthPassword { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        bool Equals(string basicAuthUserName, string basicAuthPassword);
    }
}