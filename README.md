imagetyperzapi - Imagetyperz API wrapper
=========================================
imagetyperzapi is a super easy to use bypass captcha API wrapper for imagetyperz.com captcha service

## Installation
    Install-Package imagetyperzapi

or
    
    git clone https://github.com/imagetyperz-api/imagetyperz-api-csharp

## How to use?

Simply import the library, set the auth details and start using the captcha service:

``` csharp
using imagetyperzapi;
```
Set access_token or username and password (legacy) for authentication

``` csharp
string access_key = "your_access_key";
ImagetyperzAPI i = new ImagetyperzAPI(access_key);
```
legacy authentication, will get deprecated at some point
```csharp
i.set_user_and_password("your_username", "your_password");
```
Once you've set your authentication details, you can start using the API

**Get balance**

``` csharp
string balance = i.account_balance();
Console.WriteLine(string.Format("Balance: {0}", balance));
```

**Submit image captcha**

``` csharp
var captcha_text = i.solve_captcha("captcha.jpg");
Console.WriteLine(string.Format("Got response: {0}", captcha_text));
```
Takes a 2nd argument, **case_sensitive** which is a bool
``` csharp
// tell our server this is caseSensitive, false by default
var captcha_text = i.solve_captcha("captcha.jpg", true);
```

**Works with both files and URLs**
``` csharp
var captcha_text = i.solve_captcha("http://abc.com/captcha.jpg");
```
**OBS:** URL instead of image file path works when you're authenticated with access_key. For those that are still using username & password, retrieve your access_key from imagetyperz.com

**Submit recaptcha details**

For recaptcha submission there are two things that are required.
- page_url
- site_key
``` csharp
string page_url = "your_page_url_here";
string sitekey = "your_site_key_here";
// get captcha_id, we'll use this later
string captcha_id = i.submit_recaptcha(page_url, sitekey);
```
This method returns a captchaID. This ID will be used next, to retrieve the g-response, once workers have 
completed the captcha. This takes somewhere between 10-80 seconds.

**Retrieve captcha response**

Once you have the captchaID, you check for it's progress, and later on retrieve the gresponse.

The ***in_progress(captcha_id)*** method will tell you if captcha is still being decoded by workers.
Once it's no longer in progress, you can retrieve the gresponse with ***retrieve_recaptcha(captcha_id)***  

``` csharp
Console.WriteLine("Waiting for recaptcha to be solved ...");
while (i.in_progress(captcha_id))       // check if it's still being decoded
{ System.Threading.Thread.Sleep(10000); }      // sleep for 10 seconds
string recaptcha_response = i.retrieve_captcha(captcha_id);     // get the response
Console.WriteLine(string.Format("Recaptcha response: {0}", recaptcha_response));
```

## Other methods/variables

**Affiliate id**

The constructor accepts a 2nd parameter, as the affiliate id. 
``` csharp
ImagetypersAPI i = new ImagetypersAPI(access_token, 123);
```

**Requests timeout**

You can set the timeout for the requests using the **set_timeout(seconds)** method
``` csharp
i.set_timeout(10);
```

**Submit recaptcha with proxy**

When a proxy is submitted with the recaptcha details, the workers will complete the captcha using
the provided proxy/IP.

``` csharp
i.submit_recaptcha(page_url, sitekey, "127.0.0.1:1234");
```
Proxy with authentication is also supported
``` csharp
i.submit_recaptcha(page_url, sitekey, "127.0.0.1:1234:user:pass");
```

**Set captcha bad**

When a captcha was solved wrong by our workers, you can notify the server with it's ID,
so we know something went wrong

``` csharp
i.set_captcha_bad(captcha_id);
```

## Examples
Compile and run the **example** project in solution

## Command-line client
For those that are looking for a command-line, check out the **imagetyperz-cli** project in solution
It's a tool that allows you to do pretty much all the API offers, from the command-line
Check it's README.md file of the cli for more details

## Binary
If you don't want to compile your own library, you can check the binary folder for a compiled version.
**Keep in mind** that this might not be the latest version with every release

## License
API library is licensed under the MIT License

## More information
More details about the server-side API can be found [here](http://imagetyperz.com)


<sup><sub>captcha, bypasscaptcha, decaptcher, decaptcha, 2captcha, deathbycaptcha, anticaptcha, 
bypassrecaptchav2, bypassnocaptcharecaptcha, bypassinvisiblerecaptcha, captchaservicesforrecaptchav2, 
recaptchav2captchasolver, googlerecaptchasolver, recaptchasolverpython, recaptchabypassscript</sup></sub>
