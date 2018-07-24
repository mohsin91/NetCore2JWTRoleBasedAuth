# NetCore2JWTRoleBasedAuth

This code is an implementation of JWT Role Base Authorization with Custom Tables. 

We are using EntityFramework with Sql. In order to use MySql, you just have to use options.UseMySql in ConfigureServices of Startup.cs
instead of options.UseSql.

Use Cases:

1. When a user log in with valid credentials, a token is returned.
2. When user tries to access and Api controller action decorated with [Authorize] with an invalid token or no token at all. It will return
   401 Unauthorized status code.
3. When user tries to access an action whom access is only provided to admin(with a valid token though), it will return a 403 Forbidden
   status code.
