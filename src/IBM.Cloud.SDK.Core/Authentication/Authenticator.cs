﻿/**
* Copyright 2019 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using IBM.Cloud.SDK.Core.Http;

namespace IBM.Cloud.SDK.Core.Authentication
{
    public class Authenticator
    {
        public const string AuthtypeBasic = "basic";
        public const string AuthtypeNoauth = "noauth";
        public const string AuthtypeIam = "iam";
        public const string AuthtypeIcp4d = "icp4d";

        /// <summary>
        /// Returns the authentication type associated with the AuthenticatorConfig instance.
        /// </summary>
        virtual public string AuthenticationType { get; }

        /// <summary>
        /// Validate the configuration and throw an exception if validation fails.
        /// </summary>
        virtual public void Authenticate(IClient client) { }
    }
}