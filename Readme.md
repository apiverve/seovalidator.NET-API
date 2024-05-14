SEO Validator API
============

SEO Validator is a simple tool for validating SEO metrics. It returns the SEO metrics of a web page.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [SEO Validator API](https://apiverve.com/marketplace/api/seovalidator)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.SEOValidator
```

Using the Package Manager:
```
nuget install APIVerve.API.SEOValidator
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.SEOValidator
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.SEOValidator".
5. Click on the APIVerve.API.SEOValidator package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the seovalidator API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The SEO Validator API documentation is found here: [https://docs.apiverve.com/api/seovalidator](https://docs.apiverve.com/api/seovalidator).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
SEO Validator API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new SEOValidatorAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new QueryOptions{
  "url": "https://ebay.com"
};
```

###### Simple Request

```
var response = apiClient.execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    Console.WriteLine(response);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "url": "https://ebay.com",
    "output": [
      "There are 386 <a> tag without rel attribute.",
      "This HTML does not have <meta name=descriptions> in <head>",
      "This HTML does not have <meta name=keywords> in <head>"
    ],
    "seoPassed": false
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the mailboxlayer website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.