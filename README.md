# ASP.NET-Web-Forms-Student-Management-Entity-Framework

The application is built with ASP.NET Web Forms and Entity Framework. It demonstrates how to perform database operations using Entity Framework with a SQL Server database (TestDB).
The system allows adding, viewing, editing, and updating student details such as Name and Age. The data is stored in a SQL Server database, and changes are persisted using Entity Framework.

Technologies Used
ASP.NET Web Forms
C#
Entity Framework (Code First)
SQL Server
ADO.NET

Features
Add Student → Save new student details to the database
View Students → Display all student records in a GridView
Edit Student → Select an existing student and update their details
Update Student → Save changes back to the database using Entity Framework

Project Structure
StudentDetails.cs → Entity class with properties Id, StudentName, and Age
UsersContext.cs → Database context class (DbContext) for managing StudentDetails
AddStudent.aspx → Web Form for adding and editing student data
AddStudent.aspx.cs → Code-behind file with CRUD operations

How It Works
On Page Load, student records are fetched from the database and bound to the GridView.
The Save button inserts a new student into the database.
The Edit button populates the form fields with existing data for editing.
The Update button saves changes back to the database using Entity Framework.
All database interactions are handled via DbSet<StudentDetails> in the UsersContext.

