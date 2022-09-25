Task description

User must be able to register.
After registration, a User is created with the default role 'User'.
The user must be able to generate information about himself, in which ALL fields are mandatory (Personal information), the user must not be able to generate information about more than one person.
There must be different endpoints to update EACH of the fields, e.g.: Name, social security code, phone number, city (cannot be updated to an empty field or whitespace)
When registering a person, it must be mandatory to upload a profile photo, its size must be reduced to 200x200 (if the photo is too small, it will be stretched to 200x200).
It must be possible to get all the information about the uploaded person according to his ID (the photo is returned as a byte array).
The user must not be able to update information other than his own, for the sake of convenience, let's say that with each request "from the frontend" the User's ID will come.
There must also be an 'Admin' role, which will be determined through the database and it will have an endpoint through which it can delete the user by ID (deleting the user also deletes the person's info)
Without authorization should only be able to register and log in.
Authentication and Authorization is done with Json Web Tokens.
Ms sql database is used.
Entity Framework is used. 

NuGet packages were used: 

1) Microsoft.EntityFrameworkCore version 6.0.8

2) Microsoft.EntityFrameworkCore.SqlServer version 6.0.8

3) Microsoft.EntityFrameworkCore.Tools version 6.0.8

4) Microsoft.AspNetCore.Http.Features version 5.0.17

5) Microsoft.EntityFrameworkCore.Design version 6.0.8

6) Microsoft.AspNetCore.Authentication.JwtBearer version 6.0.8

7) Moq version 4.18.2

8) Moq.EntityFrameworkCore version 6.0.1.4
