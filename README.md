# _Hair Salon_

#### By _**Thomas Bakken**_

#### _A web application for a Hair Salon to manage stylists and clients._

## Technologies Used

* _.NET_
* _C#_
* _MySQL_
* _Entity Framework Core_

## Description

_A website for a hair salon to manage stylists and clients. The user can view and create both stylists and clients. A database is used to store information about stylists and clients. A stylist works with many clients, whereas a client has only one stylist._

## Setup/Installation Requirements

* _Install .NET SDK 6_
* _Install MySQL Server_
* _Install MySQL Workbench_
* _Clone the repository_
* _Import database to MySQL_
  * _Open MySQL Workbench_
  * _Select the Administrator window_
  * _Select Data Import/Restore_
  * _Select Import From Self-Contained File_
  * _Input the path for the .sql file_
  * _Click New..._
  * _Input a database name_
  * _Start the import_
* _In the bash command line:_
  * _Navigate to the top-level directory_
  * _Create appsettings.json with: touch appsettings.json_
    * _Open the file in a text editor and copy the following line_
      * _\{"ConnectionStrings": \{"DefaultConnection": "Server=localhost;Port=3306;database=\[DB_NAME\];uid=\[USERNAME\];pwd=\[PASSWORD\];"\}\}_
    * _Replace \[DB_NAME\] with your imported database name_
    * _Replace \[USERNAME\] with your mysql username_
    * _Replace DB_NAME with your mysql password_
  * _Enter command: dotnet restore HairSalon_
  * _Run application with command: dotnet run --project HairSalon_


## Known Bugs

* _Submitting new client form with no stylist results in error_

## License

_MIT_

Copyright (c) _8/7/2023_ _Thomas Bakken_