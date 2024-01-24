# BlazorWebAssemblyApp-With-Auth0-Authentication

Before starting the app, create an account in [Auth0](https://auth0.com/) and follow this steps:
- After logging in, you'll proceed to the Management Dashboard, click on Applications tab and click on `+ Create Application`
- Type the name of your app and select the `Single Page Web Applications` and click `Create`
- Copy your Domain and ClientId and paste it in the AppSettings.json, note that the `Authority` value must start with `https://`
- Scroll down and in the Allowed Callback Urls, type: `https://localhost:7005/authentication/login-callback` since this is the port of the app, also in the Allowed Logout URLS enter this `https://localhost:7005/`.

appsettings.json
```
"Auth0": {
    "Authority": "https://yourDevId.us.auth0.com",
    "ClientId": "YourDevClientId"
  }
```

Now you can start the app 😊