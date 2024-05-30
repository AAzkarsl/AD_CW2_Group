# EBook Management System

EBook Management System is a web application built with ASP.NET Core that allows users to manage orders, provide feedback on books, and manage other related activities. The application uses MySQL for data storage and Entity Framework Core for database operations.

## Features

- User authentication and authorization
- Order management
- Feedback system for books
- Admin panel for managing orders and feedback
- Responsive design

## Prerequisites

Before running the application, ensure you have the following software installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [XAMPP](https://www.apachefriends.org/index.html)
- [Git](https://git-scm.com/downloads)

## Installation

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/AAzkarsl/AD_CW2_Group.git
    cd AD_CW2_Group
    ```

2. Restore the necessary packages:

    ```bash
    dotnet restore
    ```

## Database Setup

1. Start XAMPP and start the MySQL service.

2. Create a new database:
   - Open phpMyAdmin by navigating to `http://localhost/phpmyadmin` in your web browser.
   - Click on "New" in the left sidebar to create a new database.
   - Name the database (e.g., `mydatabase`) and click "Create".

3. Apply database migrations to set up the database schema:
   ```
   dotnet ef database update


##Configuration
Open the appsettings.json file located in the root directory of the project.

Update the ConnectionStrings section with your MySQL database connection details:

	{
	  "ConnectionStrings": {
	    "DefaultConnection": "Server=localhost;Database=mydatabase;User=root;Password=;"
	  },
	}

##Configure any other settings as needed, such as logging, authentication, and external services.

##Running the Application.
##Build the application:

		dotnet build

##Run the application.

			dotnet run
