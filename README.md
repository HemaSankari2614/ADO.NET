🎓 WPF ADO.NET Student Management System
A desktop-based Student Management System developed using C#, WPF, ADO.NET, and Azure SQL Database as a hands-on database programming practice project.

The application provides a simple interface to manage student records and practice database CRUD operations using SQL queries and parameterized commands.

Technologies Used
C# — Application logic
WPF (XAML) — Desktop user interface
ADO.NET — Database connectivity and data access
Microsoft.Data.SqlClient — SQL Server connectivity
Azure SQL Database — Cloud database
Features
Add Student: Insert student details into the database.
Read Student: Retrieve student details using Student ID.
Update Student: Modify existing student information.
Delete Student: Delete a student record using Student ID.
Clear Form: Clear the input fields.
Parameterized Queries: Use SQL parameters to pass user inputs to database commands.
Student Information
The application form contains the following fields:

Student ID
Full Name
Email Address
Department
Age
Phone Number
Database Operations
The project demonstrates the following SQL operations:

Operation	SQL Command
Create	INSERT INTO
Read	SELECT
Update	UPDATE
Delete	DELETE
Database Configuration
The application connects to an Azure SQL Database using Microsoft.Data.SqlClient.

Before running the application:

Create an Azure SQL Database or use an existing SQL Server database.
Create a Students table with columns matching the application fields.
Configure the database connection string securely.
Ensure the database firewall allows connections from your development environment.
Run the WPF application.
Security Note: Never commit database passwords, credentials, or connection strings containing secrets to a public repository. Store sensitive configuration separately from source code.

Learning Objectives
Understanding ADO.NET database connectivity.
Opening and closing SQL connections.
Executing SQL commands with SqlCommand.
Reading query results with SqlDataReader.
Using parameterized SQL queries.
Performing CRUD operations with SQL Server.
Connecting a WPF desktop application to Azure SQL Database.
Project Status
Developed as a hands-on practice project to improve C#, WPF, ADO.NET, and SQL database programming skills.
