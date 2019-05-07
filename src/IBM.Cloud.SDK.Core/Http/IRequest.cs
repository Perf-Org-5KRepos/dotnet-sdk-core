﻿/**
* Copyright 2017 IBM Corp. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace IBM.Cloud.SDK.Core.Http
{
    public interface IRequest : IResponse
    {
        HttpRequestMessage Message { get; }

        IRequest WithBody<T>(T body, MediaTypeHeaderValue contentType = null);

        IRequest WithBody<T>(T body, MediaTypeFormatter formatter, string mediaType = null);

        IRequest WithBodyContent(HttpContent body);

        IRequest WithHeader(string key, string value);

        IRequest WithHeaders(Dictionary<string, string> headers);

        IRequest WithArgument(string key, object value);

        IRequest WithArguments(object arguments);

        IRequest WithCustom(Action<HttpRequestMessage> request);

        IRequest WithFormatter(MediaTypeHeaderValue contentType);

        Task<T> AsAsync<T>(this IRequest request, CancellationToken cancellationToken = default(CancellationToken));

        TaskAwaiter<IResponse> GetAwaiter();
    }
}