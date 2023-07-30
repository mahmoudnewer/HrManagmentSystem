# HrManagmentSystem
The ITI Graduation Project

HR Management System Web Application that streamlines employee attendance tracking, departure time management, and salary calculations, all in one comprehensive solution.
The application provides Two types of users, Admin and HR user. The application is built using Angular as the frontend and ASP.NET Core Web API as the backend.
The authentication process is implemented using JWT (JSON Web Token) authentication. The application generates a token to check the authenticated user.

## Prerequisites 
- Angular CLI
- Visual Studio 2020
- .NET Core 7
- SQL Server 2019 or later

## Getting Started

1. Clone the repository to your local machine.
2. Open the solution file in Visual Studio.
3. Open the `appsettings.json` file in the project and replace the database connection string with your own.
4. Open the Package Manager Console in Visual Studio and run the following command to create the database tables:

```
add-migrations 
Update-Database
```

5. Build and run the solution in Visual Studio. This will launch the API on `https://localhost:5001` and the Angular application on `http://localhost:4200`.

## Features

### Admin

The admin can perform the following actions:

- Login to the application.
- Add new users.
- Add, edit, delete Groups with specific pages and permissions also assign users to them. 

### HR User

The Hr user can perform the following actions based upon his group and permssions:

- login to the application.
- Add, edit, delete and view employees.
- Add, edit, delete and view employees' attendance and departure time.
- Add, edit, delete and view employees general settings that contains bonus-hour , deduction-hour and holidays.
- generate detailed reports for all employees that contains every thing related to there salaries.


## Authentication

The application uses password hashing and salting in the database to store user passwords securely.
 When a user logs in, the application generates a token that is used to check if the user is authenticated or not.(JWT Token)

## Built With

- Angular - A front-end web application framework.
- ASP.NET Core Web API - A back-end web application framework.
- SQL Server - A relational database management system.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

