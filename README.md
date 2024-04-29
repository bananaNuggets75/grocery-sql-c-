# SQL Database Backup Recovery Guide

This guide provides instructions for recovering a backup file using SQL Management Studio. Follow the steps below to successfully recover your backup file:

## Installation

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/yourUserName/grocery-sql-c-.git
    ```

2. Navigate to the project directory:

    ```bash
    cd grocery-sql-c-
    ```

3. Open the project in Visual Studio by opening the .sln file.


## Usage

1. Log in to SQL Management Studio.
2. Right-click on the database you want to recover and select "Recover".
3. Choose the backup file and add it to the recovery list.
4. Modify the destination database name if necessary.
5. Review the recovery settings and click "OK" to initiate the recovery process.

## Contributing

If you find any bugs or have suggestions for improvements, please open an issue or submit a pull request.

---

**Note**: Please ensure to replace 'Lastname' with whatever name you want before proceeding with the recovery process.

---

To configure the connection in Visual Studio:
1. Open the project in Visual Studio.
2. Update the `SetConnection` method based on your SQL server account.
3. Change the `initial catalog` parameter once you recover the database and replace it with your database name that you renamed.
