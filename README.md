# Mobile-Shop-Management-System
As part of the Visual Programming module, we developed a Mobile Shop Management System using C# and Visual Studio, with MySQL for backend database management. 

## Features
- Secure login and authentication.
- Add, delete, and search for mobile phone records.
- Customer purchase management.
- User-friendly interface with seamless navigation.
- Inventory and sales tracking with detailed reports.

## Prerequisites
- **Visual Studio** (version 2019 or later).
- **MySQL Server** (version 8.0 or later).
- **MySQL Workbench** for database management (optional).
- .NET Framework (pre-installed with Visual Studio).

## Installation and Setup

### Step 1: Clone the Repository
```bash
git clone https://github.com/yourusername/mobile-shop-management.git
cd mobile-shop-management
```

### Step 2: Configure the Database
1. Install and set up **MySQL Server** on your machine.
2. Create a new database named `mobile_shop_db`.
3. Import the provided `database_schema.sql` file into your MySQL database using MySQL Workbench or the command line.
4. Update the connection string in the project to match your MySQL configuration. The connection string is located in `App.config`.

```xml
<connectionStrings>
    <add name="MyDBConnection" connectionString="Server=localhost;Database=mobile_shop_db;Uid=root;Pwd=yourpassword;" providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```

### Step 3: Open the Project in Visual Studio
1. Open **Visual Studio**.
2. Click on **File** > **Open** > **Project/Solution**.
3. Navigate to the cloned repository folder and select the `.sln` file.

### Step 4: Build and Run the Application
1. Build the solution by pressing `Ctrl + Shift + B` or clicking on **Build** > **Build Solution**.
2. Run the application by pressing `F5` or clicking on **Start Debugging**.

## How to Use
1. **Login**: Enter valid credentials to access the system.
2. **Add New Phone**: Navigate to the "Add New Phone" page to insert mobile phone details into the inventory.
3. **Manage Customers**: Register new customers and manage their purchase records.
4. **Delete Records**: Use the "Delete Phone" page to securely remove outdated or incorrect entries.
5. **Search Records**: Utilize the search functionality to find specific customer or inventory details quickly.

## File Structure
```
mobile-shop-management/
├── Database/
│   ├── database_schema.sql
├── Forms/
│   ├── LoginForm.cs
│   ├── AddPhoneForm.cs
│   ├── CustomerForm.cs
│   ├── DeletePhoneForm.cs
├── Properties/
├── bin/
├── obj/
├── MobileShopManagement.sln
└── README.md
```

## Contributors
- **Your Name** 
- EC/2020/053 - W.A.K.V.P. Sandakirani 
- EC/2020/032 - E.G.H. Tharanga 
- PS/2020/220 -M.S.S. Jinadasa 
- EC/2020/068 - R.A.D.D. Sithsirini 
- EC/2020/076 - R.M.H.I. Rathnayaka

## License
This project is licensed under the MIT License. See `LICENSE` for details.
