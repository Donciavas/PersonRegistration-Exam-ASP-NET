Final Exam Task description

User must be able to register.
After registration, a User is created with the default role 'User'.
The user must be able to create information about himself, in which ALL fields are mandatory (Personal information) and must not be able to generate information about more than one person.
There must be different endpoints to update EACH of the fields, e.g.: Name, social security code, phone number, city (cannot be updated to an empty field or whitespace)
When registering a person, it must be mandatory to upload a profile photo, its size must be reduced to 200x200 (if the photo is too small, it will be stretched to 200x200).
It must be possible to get all the information about the uploaded person according to his ID (the photo is returned as a byte array).
The user must not be able to update information other than his own, for the sake of convenience, let's say that with each request "from the frontend" the User's ID will come.
There must also be an 'Admin' role, which will be determined through the database and it will have an endpoint through which it can delete the user by ID (deleting the user also deletes the person's info)

Without authorization should only be able to register and log in.

Authentication and Authorization is done with Json Web Tokens.

Microsoft SQL Server Management Studio (SSMS) database is used.

Entity Framework is used. 

---*Important Notice*--- Result of the program code files and database script is in file 'PersonRegASPNET_CreateDBFile.sql'. Just copy n paste to SQL server database query.
In order to create new database, if needed, write 'Update-Database' in npm console.

NuGet packages were used: 

1) Microsoft.EntityFrameworkCore version 6.0.7

2) Microsoft.EntityFrameworkCore.SqlServer version 6.0.7

3) Microsoft.EntityFrameworkCore.Tools version 6.0.7

4) Microsoft.AspNetCore.Http.Features version 5.0.17

5) Microsoft.EntityFrameworkCore.Design version 6.0.7

6) Microsoft.AspNetCore.Authentication.JwtBearer version 6.0.7

7) Moq version 4.18.1

8) Moq.EntityFrameworkCore version 6.0.1.4

9) Microsoft.NET.Test.SDK version 17.4.0

10) AutoFixture.Xunit2 version 4.17.0

11) xUnit version 2.4.1

12) xunit.runner.visualstudio version 2.4.3

13) System.Drawing.Common version 6.0.0

14) Swashbuckle.AspNetCore version 6.2.3

15) coverlet.collector version 3.1.0

What need to be fixed in this program (working on it): 

1. Separate UnitsOfWork out of Repositories. After this I could easily separate all that Repository, Service 'Management<..>" blend into separate ones to accomplish single responsibility.
2. Implement Field update through generics. 
3. Redo XUnit tests :)

Adding structure img: ![image](https://user-images.githubusercontent.com/96888736/204161930-fbc7d931-2e80-487f-9c12-367f1413d605.png)

